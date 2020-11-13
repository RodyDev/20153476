using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Shared.QueryFilters;
using MySql.Data.MySqlClient;

namespace DogKeepers.Server.Repositories
{
    public class DogRepository : IDogRepository
    {
        private readonly IBaseRepository baseRepository;

        public DogRepository(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public async Task<Tuple<int, List<Dog>>> GetList(DogsQueryFilter model)
        {
            List<Dog> dogs = new List<Dog>();
            string order = "";
            string limit = "";
            string fromTable = @"
            from
                dogs
                join races
                    on races.Id = raceId
                join sizes
                    on sizes.Id = sizeId
            ";
            
            if (model.Random != 0)
            {
                limit = $" limit {model.Random}";
                order = " order by rand()";
            }
            else
            {
                var skipDogUntilItem = (model.PageNumber - 1) * model.PageSize;
                limit = $"limit {skipDogUntilItem}, {model.PageSize}";
            }

            var sqlCommand = $@"
                select
                    *
                {fromTable}
                {order}
                {limit}
            ";

            var sqlCountCommand = $@"
                select
                    count(*) 
                {fromTable}
            ";

            var count = await baseRepository.Count(sqlCountCommand);

            if (count > 0)
            using(var connection = new MySqlConnection("Server=localhost;Database=Dogkeepers;User Id=root")){
                var sqlResponse =
                    await connection.QueryAsync<Dog, Race, Size, Dog>(
                        sqlCommand,
                        (dg, ra, si) =>
                        {
                            dg.Race = ra;
                            dg.Size = si;

                            return dg;
                        },
                        splitOn: "id, id"
                    );
                
                dogs = sqlResponse.AsList();
            }

            return new Tuple<int, List<Dog>>(count, dogs);
        }
    }
}
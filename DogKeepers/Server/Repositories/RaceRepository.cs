using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using MySql.Data.MySqlClient;

namespace DogKeepers.Server.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        public async Task<List<Race>> Get()
        {
            List<Race> races = new List<Race>();
            var sqlCommand = "select * from races";

            using(var connection = new MySqlConnection("Server=localhost;Database=Dogkeepers;User Id=root"))
            {
                var sqlResponse =
                    await connection.QueryAsync<Race>
                    (
                        sqlCommand
                    );
                races = sqlResponse.AsList();
            }

            return races;
        }
    }
}
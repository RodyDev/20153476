using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using MySql.Data.MySqlClient;

namespace DogKeepers.Server.Repositories
{
    public class SizeRepository : ISizeRepository
    {
        public async Task<List<Size>> Get()
        {
            List<Size> sizes = new List<Size>();
            
            using (var connection = new MySqlConnection("Server=localhost;Database=Dogkeepers;User Id=root"))
            {
                var sqlCommand = "select * from sizes";

                var sqlResponse =
                    await connection.QueryAsync<Size>(
                        sqlCommand
                    );

                sizes = sqlResponse.AsList();
            }

            return sizes;
        }
    }
}
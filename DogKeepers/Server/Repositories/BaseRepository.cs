using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Options;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;



namespace DogKeepers.Server.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        private readonly string connectionString;
        public BaseRepository(IOptions<ConnectionStringsOptions> connectionString)
        {
            this.connectionString = connectionString.Value.Production;
        }

        public async Task<int> Count(string command)
        {
            var count = 0;

            using(var connection = new MySqlConnection(connectionString))
            {
                var sqlResponse =
                    await connection.QueryAsync<int>(
                        command
                    );
                
                count = sqlResponse.First();
            }
            return count;
        }
    }
}
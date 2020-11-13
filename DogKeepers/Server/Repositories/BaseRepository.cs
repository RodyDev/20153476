using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DogKeepers.Server.Interfaces.Repositories;
using MySql.Data.MySqlClient;



namespace DogKeepers.Server.Repositories
{
    public class BaseRepository : IBaseRepository
    {


        public async Task<int> Count(string command)
        {
            var count = 0;

            using(var connection = new MySqlConnection("Server=localhost;Database=Dogkeepers;User Id=root"))
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
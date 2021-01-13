using System.Threading.Tasks;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Options;
using DogKeepers.Shared.QueryFiltersame;
using Microsoft.Extensions.Options;
using DogKeepers.Server.Entities;
using MySql.Data.MySqlClient;
using Dapper;
using System.Linq;

namespace DogKeepers.Server.Repositories
{
    public class UserRepository : IUserRepository
    {

        private readonly string _connectionString;

        public UserRepository(IOptions<ConnectionStringsOptions> connectionString)
        {
            _connectionString = connectionString.Value.Production;
        }
        public async Task<User> GetByEmailPassword(SignInQueryFilter user)
        {
            User data = null;

            using(var connection = new MySqlConnection(_connectionString))
            {
                var sqlResponse = 
                    await connection.QueryAsync<User>(
                        $"select * from users where email = '{user.Email}' and password = '{user.Password}'"
                    );
                
                data = sqlResponse.FirstOrDefault();
            }

            return data;
        }
    }
}
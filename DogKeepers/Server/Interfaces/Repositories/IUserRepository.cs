using System.Threading.Tasks;
using DogKeepers.Shared.QueryFiltersame;
using DogKeepers.Server.Entities;

namespace DogKeepers.Server.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByEmailPassword(SignInQueryFilter user);
    }
}
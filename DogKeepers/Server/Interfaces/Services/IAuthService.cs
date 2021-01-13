using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Shared.QueryFiltersame;

namespace DogKeepers.Server.Interfaces.Services
{
    public interface IAuthService
    {
        Task<Jwt> Authenticate(SignInQueryFilter user);
    }
}
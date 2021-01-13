using System.Threading.Tasks;
using DogKeepers.Shared.DTOs;

namespace DogKeepers.Client.Interfaces
{
    public interface IJwtProvider
    {
        Task Login(JwtDto token);
        Task Logout();
    }
}
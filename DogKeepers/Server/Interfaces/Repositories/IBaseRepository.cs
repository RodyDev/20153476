using System.Threading.Tasks;

namespace DogKeepers.Server.Interfaces.Repositories
{
    public interface IBaseRepository
    {
        Task<int> Count(string command);
    }
}
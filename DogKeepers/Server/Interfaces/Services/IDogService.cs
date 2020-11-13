using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Shared.QueryFilters;
using DogKeepers.Server.Utils;


namespace DogKeepers.Server.Interfaces.Services
{
    public interface IDogService
    {
        Task<PagedList<Dog>>  GetList(DogsQueryFilter model);
    }
} 
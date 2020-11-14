
using System.Collections.Generic;
using System.Threading.Tasks;
using DogKeepers.Server.Entities;

namespace DogKeepers.Server.Interfaces.Repositories
{
    public interface ISizeRepository
    {
        Task<List<Size>> Get();
    }
}
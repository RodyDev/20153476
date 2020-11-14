using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using System.Collections.Generic;

namespace DogKeepers.Server.Interfaces.Services
{
    public interface ISizeService
    {
        Task<List<Size>> Get();
    }
}
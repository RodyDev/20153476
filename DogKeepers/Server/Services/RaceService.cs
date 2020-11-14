using System.Collections.Generic;
using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Interfaces.Services;

namespace DogKeepers.Server.Services
{
    public class RaceService : IRaceService
    {
        private readonly IRaceRepository raceRepository;
        
        public RaceService(IRaceRepository raceRepository)
        {
            this.raceRepository = raceRepository;
        }
        public async Task<List<Race>> Get()
        {
            var races = await raceRepository.Get();
            
            return races;
        }
    }
}

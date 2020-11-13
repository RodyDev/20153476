using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Utils;
using DogKeepers.Shared.QueryFilters;


namespace DogKeepers.Server.Services
{
    public class DogService : IDogService
    {
        private readonly IDogRepository  dogRepository;

        public DogService(IDogRepository dogRepository)
        {
            this.dogRepository = dogRepository;
        }
        
        public async Task<PagedList<Dog>> GetList(DogsQueryFilter model)
        {
            model.PageNumber = 1;
            model.PageSize = 10;
            
            var dogs = await dogRepository.GetList(model);
            var response = PagedList<Dog>.Create(
                dogs.Item2,
                (int)model.PageNumber,
                (int)model.PageSize,
                dogs.Item1
            );

            return response;
        }
    }
}
using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Utils;
using DogKeepers.Shared.QueryFilters;
using DogKeepers.Server.Options;
using Microsoft.Extensions.Options;

namespace DogKeepers.Server.Services
{
    public class DogService : IDogService
    {
        private readonly IDogRepository  dogRepository;
        private readonly PaginationOption paginationOption;

        public DogService(IDogRepository dogRepository, IOptions<PaginationOption> paginationOption)
        {
            this.dogRepository = dogRepository;
            this.paginationOption = paginationOption.Value;
        }
        
        public async Task<PagedList<Dog>> GetList(DogsQueryFilter model)
        {
            model.PageNumber = paginationOption.DefaultPageNumber;
            model.PageSize = paginationOption.DefaultPageSize;
            
            var dogs = await dogRepository.GetList(model);
            var response = PagedList<Dog>.Create(
                dogs.Item2,
                (int)model.PageNumber,
                (int)model.PageSize,
                dogs.Item1
            );

            return response;
        }
        public async Task<Dog> GetById(int id)
        {
            var dog= await dogRepository.GetById(id);

            return dog;
        }
    }
}
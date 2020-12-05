using System.Threading.Tasks;
using DogKeepers.Server.Entities;
using DogKeepers.Server.Interfaces.Services;
using DogKeepers.Server.Interfaces.Repositories;
using DogKeepers.Server.Utils;
using DogKeepers.Shared.QueryFilters;
using DogKeepers.Server.Options;
using Microsoft.Extensions.Options;
using DogKeepers.Server.Interfaces.Utils;

namespace DogKeepers.Server.Services
{
    public class DogService : IDogService
    {
        private readonly IFileUtil fileUtil;
        private readonly IDogRepository  dogRepository;
        private readonly PaginationOption paginationOption;
        private readonly PathOption pathOption;

        public DogService(IFileUtil fileUtil, IDogRepository dogRepository, IOptions<PaginationOption> paginationOption, IOptions<PathOption> pathOption)
        {
            this.fileUtil = fileUtil;
            this.dogRepository = dogRepository;
            this.paginationOption = paginationOption.Value;
            this.pathOption = pathOption.Value;
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

            dog.Picture=
                dog.Picture == null
                ?   pathOption.DefaultDogPicture
                :   $"{pathOption.DogsPicturesPath}{dog.Picture}";

                dog.PictureFile = fileUtil.GetFile(dog.Picture);

            return dog;
        }
    }
}
using System.Net.Http.Json;
using System.Net.Http;
using System.Threading.Tasks;
using DogKeepers.Shared.DTOs;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using DogKeepers.Shared.Metadata;
using DogKeepers.Shared.ApiResponses;
using DogKeepers.Shared.QueryFilters;

namespace DogKeepers.Client.Pages.Dogs
{
    public partial class Dogs
    {
        [Inject] public HttpClient httpClient { get; set; }

        public List<DogDto> DogsList { get; set; } = null;

        public bool IsLoadingDogsList { get; set; } = true;

        public PaginationMetadata PaginationData { get; set; }

        public DogsQueryFilter Filters = new DogsQueryFilter();
        

        protected override async Task OnInitializedAsync()
        {
            await LoadDogs();
        }

        private async Task LoadDogs()
        {
            DogsList = null;
            IsLoadingDogsList = true;

            Filters.PageNumberForce =
                PaginationData == null
                    ? 1
                    : Filters.PageNumberForce;
            
            var filterString = $"?pageNumber={Filters.PageNumber}&pageSize=8";

            var response=
                await httpClient.GetFromJsonAsync<ApiResponse<List<DogDto>>>($"/api/dog/getlist{filterString}");

                DogsList = response.Data;
                PaginationData = response.Pagination;
                
                IsLoadingDogsList = false;
        }

        private async Task OnSelectedPage(int pageNumberClicked)
        {
            Filters.PageNumberForce = pageNumberClicked;
            await LoadDogs();
        }
    }
}
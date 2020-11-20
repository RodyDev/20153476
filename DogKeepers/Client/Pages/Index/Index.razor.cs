using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using DogKeepers.Shared.DTOs;
using DogKeepers.Shared.ApiResponses;

namespace DogKeepers.Client.Pages.Index
{
    public partial class Index
    {
        [Inject] private HttpClient httpClient { get; set; }

        private List<DogDto> DogList { get; set; } = null;

        private bool IsLoadingDogsSuggestions { get; set; } = true;

        protected override async Task OnInitializedAsync(){
            await LoadSuggestions();
        }

        private async Task LoadSuggestions(){
            var response  =
                await httpClient.GetFromJsonAsync<ApiResponse<List<DogDto>>>("/api/dog/GetList?random=3");
                
                DogList = response.Data;

            IsLoadingDogsSuggestions = false;
        }
    }
}
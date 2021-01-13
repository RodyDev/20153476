using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using DogKeepers.Shared.DTOs;
using Microsoft.AspNetCore.Components;

namespace DogKeepers.Client.Pages.Dog
{
    public partial class Dog
    {
        [Parameter] public int DogId { get; set; }

        [Inject] public HttpClient httpClient { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await LoadDogInformation();
        }

        private DogDto DogInformation { get; set; } = new DogDto();
        private string DogPicture;
        private string DogPictureType;
        private async Task LoadDogInformation()
        {
            DogInformation = 
                await httpClient.GetFromJsonAsync<DogDto>($"/api/dog/getbyid?id={DogId}");

            DogPicture = Convert.ToBase64String(DogInformation.PictureFile);
            var extension = DogInformation.Picture.Substring(DogInformation.Picture.LastIndexOf(".") + 1);
            DogPictureType = extension == "svg" ? "svg+xml" : extension;
            
        }
    }
}
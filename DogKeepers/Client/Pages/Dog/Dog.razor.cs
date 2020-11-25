using Microsoft.AspNetCore.Components;

namespace DogKeepers.Client.Pages.Dog
{
    public partial class Dog
    {
        [Parameter] public int DogId { get; set; }
    } 
}
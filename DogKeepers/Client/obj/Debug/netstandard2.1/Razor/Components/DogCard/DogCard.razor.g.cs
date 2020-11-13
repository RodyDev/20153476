#pragma checksum "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Components\DogCard\DogCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f834b8413ca81809c2dc7b78d79c0307ac495f8"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Components.DogCard
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.Loading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Components\DogCard\DogCard.razor"
using Shared.DTOs;

#line default
#line hidden
#nullable disable
    public partial class DogCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card dog-card shadow");
            __builder.AddMarkupContent(2, "\r\n    <img src=\"images/GoldenRetriever.svg\" class=\"card-img-top\" alt=\"...\">\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "h4");
            __builder.AddAttribute(7, "class", "card-title text-center");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.AddContent(9, 
#nullable restore
#line 7 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Components\DogCard\DogCard.razor"
             Dog.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "list-group-item");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.AddMarkupContent(19, "<small>Edad:</small>\r\n            ");
            __builder.OpenElement(20, "span");
            __builder.AddContent(21, 
#nullable restore
#line 13 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Components\DogCard\DogCard.razor"
                   Dog.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "class", "list-group-item");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, "<small>Raza:</small>\r\n            ");
            __builder.OpenElement(28, "span");
            __builder.AddContent(29, 
#nullable restore
#line 17 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Components\DogCard\DogCard.razor"
                   Dog.Race.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "list-group-item");
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.AddMarkupContent(35, "<small>Talla:</small>\r\n            ");
            __builder.OpenElement(36, "span");
            __builder.AddContent(37, 
#nullable restore
#line 21 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Components\DogCard\DogCard.razor"
                   Dog.Size.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "card-body");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "href", "/Dog/" + (
#nullable restore
#line 25 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Components\DogCard\DogCard.razor"
                       Dog.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "class", "btn btn-light");
            __builder.AddMarkupContent(47, "Más...");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Components\DogCard\DogCard.razor"
 
    [Parameter] public DogDto Dog { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
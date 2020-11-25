#pragma checksum "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Pages\Index\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "080d5ae26caa3f227c5e169ea2b6c5a1f37010b0"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Pages.Index
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
#line 11 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.SectionPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Pages\Index\Index.razor"
using DogKeepers.Client.Components.DogCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Pages\Index\Index.razor"
using Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container-fluid index-page");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<div class=\"banner row\">\r\n        <div class=\"banner-image\"></div>\r\n        <div class=\"overlay\">\r\n            <div class=\"text\">\r\n                Dales un hogar, adopta.\r\n            </div>\r\n        </div>\r\n    </div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "suggestions");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<h2 class=\"text-center font-weight-bold p-3 mb-3\">\r\n                Mascotas en adopción.\r\n            </h2>\r\n            ");
            __builder.OpenComponent<DogKeepers.Client.Components.Loading.Loading>(11);
            __builder.AddAttribute(12, "IsLoading", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Pages\Index\Index.razor"
                            IsLoadingDogsSuggestions

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n");
#nullable restore
#line 23 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Pages\Index\Index.razor"
                 if (DogList != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(15, "                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.AddMarkupContent(18, "\r\n");
#nullable restore
#line 26 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Pages\Index\Index.razor"
                         foreach (DogDto dog in DogList)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(19, "                            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-12 col-md-4");
                __builder2.AddMarkupContent(22, "\r\n                                ");
                __builder2.OpenComponent<DogKeepers.Client.Components.DogCard.DogCard>(23);
                __builder2.AddAttribute(24, "Dog", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DogKeepers.Shared.DTOs.DogDto>(
#nullable restore
#line 29 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Pages\Index\Index.razor"
                                               dog

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n");
#nullable restore
#line 31 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Pages\Index\Index.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(27, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.AddMarkupContent(29, @"<div class=""row mt-5"">
                        <div class=""col-12 text-center"">
                            <a href=""/dogs"" class=""btn btn-dark btn-lg text-light"">
                                Ver más mascotas
                            </a>
                        </div>
                    </div>
");
#nullable restore
#line 40 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\DogKeepers\Client\Pages\Index\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(30, "            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

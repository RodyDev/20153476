#pragma checksum "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\Components\SectionPage\SectionPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f4df7626a31077af168188daddece8165efa170"
// <auto-generated/>
#pragma warning disable 1591
namespace DogKeepers.Client.Components.SectionPage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using DogKeepers.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using DogKeepers.Client.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.Loading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\_Imports.razor"
using DogKeepers.Client.Components.SectionPage;

#line default
#line hidden
#nullable disable
    public partial class SectionPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", 
#nullable restore
#line 1 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\Components\SectionPage\SectionPage.razor"
          PageName

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "class", "container-fluid p-5");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "id", "section-title");
            __builder.AddAttribute(6, "class", "row p-2 mb-4");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-12");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "h2");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddContent(13, 
#nullable restore
#line 5 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\Components\SectionPage\SectionPage.razor"
                 Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "text-muter");
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.AddContent(19, 
#nullable restore
#line 8 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\Components\SectionPage\SectionPage.razor"
                 Hint

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-12");
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.AddContent(30, 
#nullable restore
#line 14 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\Components\SectionPage\SectionPage.razor"
             ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\Dogkeepers\Client\Components\SectionPage\SectionPage.razor"
 
    [Parameter] public string PageName { get; set; }
    [Parameter] public string Title { get; set; }
    [Parameter] public string Hint { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

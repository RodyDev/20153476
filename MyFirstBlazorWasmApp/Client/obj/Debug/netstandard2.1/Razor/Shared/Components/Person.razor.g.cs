#pragma checksum "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "638f3b2692a0d9a02dcae7bfcc62deff8dd04085"
// <auto-generated/>
#pragma warning disable 1591
namespace MyFirstBlazorWasmApp.Client.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\_Imports.razor"
using MyFirstBlazorWasmApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\_Imports.razor"
using MyFirstBlazorWasmApp.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class Person : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
 if (Names.Count() == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 3 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
     Empty

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 3 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
          
}else{
    if(Names.Count() > 2)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 7 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
         LotPeople

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
                  
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.AddAttribute(5, "style", "width: 18rem;");
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 11 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
         foreach (string name in Names)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "list-group-item");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.AddContent(14, 
#nullable restore
#line 14 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
                 GreetingMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 14 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
                                  name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "!\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
#nullable restore
#line 16 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(19, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 19 "C:\Users\CESAR-PC\Documents\ProgramaciónWeb\MyFirstBlazorWasmApp\Client\Shared\Components\Person.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

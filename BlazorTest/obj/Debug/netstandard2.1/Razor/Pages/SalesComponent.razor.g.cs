#pragma checksum "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\SalesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dec995b9b871abb93764d3df089872c0a8eab056"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTestShared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.BaseComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Stores.CounterStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Stores;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/sales")]
    public partial class SalesComponent : DateBaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorTest.Controls.TitleComponent>(0);
            __builder.AddAttribute(1, "Title", "Sales");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n<br>\r\n<br>\r\n\r\nDate : ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\SalesComponent.razor"
        dateTime

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

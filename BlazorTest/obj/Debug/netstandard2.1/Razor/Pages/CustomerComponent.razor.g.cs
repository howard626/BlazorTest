#pragma checksum "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\CustomerComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c81f1b4f0d7a9a22bc9911987cb94c1577209c1"
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
#line 1 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.BaseComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Stores.CounterStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\_Imports.razor"
using BlazorTest.Stores;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/customer")]
    public partial class CustomerComponent : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CustomerComponent</h3>\r\n<br>\r\nCustomerService Id : ");
            __builder.AddContent(1, 
#nullable restore
#line 7 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\CustomerComponent.razor"
                      CustService.Uid

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(2, "\r\n<br>\r\nCustomer Name : ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\CustomerComponent.razor"
                 customer.Name

#line default
#line hidden
#nullable disable
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\CustomerComponent.razor"
       
    private Customer customer;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        if (customer == null)
        {
            customer = CustService.GetCustomerById(1);
        }
    }


    public void Dispose()
    {

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICustomerService CustService { get; set; }
    }
}
#pragma warning restore 1591
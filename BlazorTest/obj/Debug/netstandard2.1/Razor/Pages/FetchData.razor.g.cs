#pragma checksum "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "808c26ee9e351f8d7535193740a7006ab568a2f9"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Employees</h1>\r\n\r\n");
            __Blazor.BlazorTest.Pages.FetchData.TypeInference.CreateGridAutoComponent_0(__builder, 1, 2, 
#nullable restore
#line 5 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                          employees

#line default
#line hidden
#nullable disable
            , 3, "編號", 4, "is-striped is-hoverable");
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n");
            __Blazor.BlazorTest.Pages.FetchData.TypeInference.CreateRepeaterComponent_1(__builder, 6, 7, 
#nullable restore
#line 11 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                          customers

#line default
#line hidden
#nullable disable
            , 8, (__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, "<h3>\r\n            Customer\r\n        </h3>\r\n    ");
            }
            , 11, (customer) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "b");
                __builder2.AddContent(16, 
#nullable restore
#line 19 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                customer.CompanyName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "button");
                __builder2.AddAttribute(19, "class", "btn");
                __builder2.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                                            () =>
                                            {
                                                EditCustomer(customer);
                                            }

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(21, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "ml-5");
                __builder2.AddContent(26, 
#nullable restore
#line 25 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                           customer.ContactName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n        ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "ml-5");
                __builder2.AddContent(30, 
#nullable restore
#line 26 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                           customer.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        <br>\r\n    ");
            }
            , 32, (__builder2) => {
                __builder2.AddMarkupContent(33, "\r\n\r\n    ");
            }
            , 34, (customer) => (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddMarkupContent(37, "\r\n            ");
                __builder2.AddMarkupContent(38, "<text>Company Name:</text>");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "class", "form-control");
                __builder2.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                                                                               customer.CompanyName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.CompanyName = __value, customer.CompanyName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.AddMarkupContent(47, "<text>Contact Name:</text>");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                                                                               customer.ContactName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.ContactName = __value, customer.ContactName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.AddMarkupContent(56, "<text>Phone Number:</text>");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                                                                               customer.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => customer.PhoneNumber = __value, customer.PhoneNumber));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n    ");
            }
            , 63, (__value) => {
#nullable restore
#line 10 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
                         repeater = __value;

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\USER\source\repos\BlazorTest\BlazorTest\Pages\FetchData.razor"
       
    private RepeaterComponent<Customer> repeater;
    private List<Employee> employees;
    private List<Customer> customers;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        employees = new List<Employee>() {
            new Employee { 編號 = 1, 姓名 = "壹", 職位 = "一般員工", 公司 = "一般公司"},
            new Employee { 編號 = 2, 姓名 = "貳", 職位 = "一般員工", 公司 = "一般公司"},
            new Employee { 編號 = 3, 姓名 = "參", 職位 = "一般員工", 公司 = "一般公司"}
        };
    }

    protected override Task OnInitializedAsync()
    {
        customers = new List<Customer>() {
            new Customer { CompanyName = "ABC 有限公司", ContactName = "A",  PhoneNumber = "00-11122233"},
            new Customer { CompanyName = "告嘎低 有限公司", ContactName = "朱", PhoneNumber = "00-22233344"},
            new Customer { CompanyName = "什麼有限公司", ContactName = "做", PhoneNumber = "00-33344455"}
        };

        return base.OnInitializedAsync();
    }

    private void EditCustomer(Customer customer)
    {
        repeater.ItemToEdit = customer;
    }

    public class Customer
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorTest.Pages.FetchData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGridAutoComponent_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.String __arg2)
        {
        __builder.OpenComponent<global::BlazorTest.Controls.GridAutoComponent<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ColumnsToExcludeCSV", __arg1);
        __builder.AddAttribute(__seq2, "CssClass", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateRepeaterComponent_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg4, int __seq5, global::System.Action<global::BlazorTest.Controls.RepeaterComponent<TItem>> __arg5)
        {
        __builder.OpenComponent<global::BlazorTest.Controls.RepeaterComponent<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Header", __arg1);
        __builder.AddAttribute(__seq2, "Row", __arg2);
        __builder.AddAttribute(__seq3, "Footer", __arg3);
        __builder.AddAttribute(__seq4, "EditTemplate", __arg4);
        __builder.AddComponentReferenceCapture(__seq5, (__value) => { __arg5((global::BlazorTest.Controls.RepeaterComponent<TItem>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
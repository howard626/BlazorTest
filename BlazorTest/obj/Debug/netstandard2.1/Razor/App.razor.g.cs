#pragma checksum "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "875d79752ad78112851aa0ae51f9818eb9221e8a"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(2, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(3);
                __builder2.AddAttribute(4, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(7);
                    __builder3.AddAttribute(8, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(11, "\r\n");
#nullable restore
#line 6 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\App.razor"
                     if (!context.User.Identity.IsAuthenticated)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(12, "                        ");
                        __builder4.OpenComponent<BlazorTest.Shared.RedirectToLogin>(13);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(14, "\r\n");
#nullable restore
#line 9 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\App.razor"
                    }
                    else 
                    {

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(15, "                        ");
                        __builder4.AddMarkupContent(16, "<p> ?????????????????????????????????????????????????????? 0800062000 </p>\r\n");
#nullable restore
#line 13 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\App.razor"
                    }

#line default
#line hidden
#nullable disable
                        __builder4.AddContent(17, "                ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(18, "\r\n        ");
                }
                ));
                __builder2.AddAttribute(19, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(21);
                    __builder3.AddAttribute(22, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 18 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\App.razor"
                                 typeof(LoginLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(24, "\r\n                ");
                        __builder4.AddMarkupContent(25, "<p>Sorry, there\'s nothing at this address.</p>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

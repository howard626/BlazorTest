#pragma checksum "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamsComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "268a9cf8ffb565e814ed77ff8c1f87602d67942e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/teams")]
    public partial class TeamsComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3> Teams </h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<tr>\r\n        <th>Team</th>\r\n        <th>Region</th>\r\n    </tr>\r\n");
#nullable restore
#line 8 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamsComponent.razor"
     foreach (var team in teams)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "        ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n            ");
            __builder.OpenElement(8, "td");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "href", 
#nullable restore
#line 11 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamsComponent.razor"
                           $"/team/{team.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "class", "nav-link");
            __builder.AddContent(12, 
#nullable restore
#line 11 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamsComponent.razor"
                                                                  team.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 12 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamsComponent.razor"
                 team.Region

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 14 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamsComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamsComponent.razor"
       
    [CascadingParameter(Name="Color")]
    public string Color { get; set; }

    public List<Team> teams;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        teams = new List<Team>();
        teams.Add(new Team { Id = 1, Name = "Red", Region = "One" });
        teams.Add(new Team { Id = 2, Name = "Blue", Region = "Two" });
        teams.Add(new Team { Id = 3, Name = "Yellow", Region = "Three" });
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Region { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7a8ecc67c57f601f051c8fa622104b1e88de07b"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/team/{Id:int}")]
    public partial class TeamComponent : TeamsComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddMarkupContent(1, "\r\n    Name : ");
            __builder.AddContent(2, 
#nullable restore
#line 6 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamComponent.razor"
            team.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "   <br>\r\n    Region : ");
            __builder.AddContent(4, 
#nullable restore
#line 7 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamComponent.razor"
              team.Region

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.AddMarkupContent(10, "<tr>\r\n        <th>Name</th>\r\n        <th>Age</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamComponent.razor"
     foreach (var member in members)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "        ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 17 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamComponent.razor"
                 member.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 18 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamComponent.razor"
                 member.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
#nullable restore
#line 20 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamComponent.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\USER\Documents\GitHub\BlazorTest\BlazorTest\Pages\TeamComponent.razor"
       
    [Parameter]
    public int Id { get; set; }

    private Team team;
    private IEnumerable<Member> members;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        var allMembers = new List<Member>();
        allMembers.Add(new Member { Id = 1, Name = "壹", Age = 20, TeamId = 1 });
        allMembers.Add(new Member { Id = 2, Name = "貳", Age = 21, TeamId = 1 });
        allMembers.Add(new Member { Id = 3, Name = "參", Age = 22, TeamId = 2 });
        allMembers.Add(new Member { Id = 4, Name = "肆", Age = 23, TeamId = 2 });
        allMembers.Add(new Member { Id = 5, Name = "伍", Age = 24, TeamId = 3 });
        allMembers.Add(new Member { Id = 6, Name = "陸", Age = 25, TeamId = 3 });

        team = teams.FirstOrDefault(x => x.Id == Id);
        members = allMembers.Where(x => x.TeamId == Id);
    }

    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TeamId { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

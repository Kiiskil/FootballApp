#pragma checksum "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\SingleMatch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71c7571be0b9383a6c42ccdc3f2ec2c1e23a0831"
// <auto-generated/>
#pragma warning disable 1591
namespace FootballApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "G:\Prokkis\FootballApp\FootballApp\FootballApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Prokkis\FootballApp\FootballApp\FootballApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Prokkis\FootballApp\FootballApp\FootballApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Prokkis\FootballApp\FootballApp\FootballApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Prokkis\FootballApp\FootballApp\FootballApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Prokkis\FootballApp\FootballApp\FootballApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "G:\Prokkis\FootballApp\FootballApp\FootballApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "G:\Prokkis\FootballApp\FootballApp\FootballApp\_Imports.razor"
using FootballApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "G:\Prokkis\FootballApp\FootballApp\FootballApp\_Imports.razor"
using FootballApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\SingleMatch.razor"
using FootballApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\SingleMatch.razor"
using FootballApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/single/{MatchID}")]
    public partial class SingleMatch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Match ID ");
            __builder.AddContent(2, 
#nullable restore
#line 6 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\SingleMatch.razor"
              MatchID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.AddMarkupContent(4, "<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Date</th>\r\n            <th>HomeTeam</th>\r\n            <th>Score</th>\r\n            <th>AwayTeam</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\SingleMatch.razor"
       

    [Parameter]
    public string MatchID { get; set; }

    public Matchlist matchlist;
    public Match TargetMatch;


    //Matchlist matchlist = FootBallService.matchlist;
    protected override void OnInitialized()
    {
        //matchlist = FootballMatchService.matchlist;
        //foreach (Match match in matchlist.Matches)
        //{
        //    if (match.Id == Int32.Parse(MatchID))
        //    {
        //        match = match;
        //    }
        //}
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

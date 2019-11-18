#pragma checksum "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e88196231efea3a525131b6b236ca2efc6f1901"
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
#line 3 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
using FootballApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
using FootballApp.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Football Matches</h1>\r\n\r\n");
#nullable restore
#line 11 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
 if (matchlist == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 14 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "placeholder", "Search");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
                                       SearchText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchText = __value, SearchText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
                      Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.AddContent(13, "    ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "class", "table");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.AddMarkupContent(17, "<thead>\r\n            <tr>\r\n                <th>#</th>\r\n                <th>Date</th>\r\n                <th>HomeTeam</th>\r\n                <th>Score</th>\r\n                <th>AwayTeam</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(18, "tbody");
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 31 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
             foreach (Match match in matchlist)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                ");
            __builder.OpenElement(21, "tr");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
                              (()=> GetMatch(match))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 34 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
                         Matchlist.Matches.IndexOf(match)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 35 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
                         match.MatchDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 36 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
                         match.HomeTeam.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 37 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
                         match.HomeGoals

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, " - ");
            __builder.AddContent(36, 
#nullable restore
#line 37 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
                                            match.AwayGoals

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 38 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
                         match.AwayTeam.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 40 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 43 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "G:\Prokkis\FootballApp\FootballApp\FootballApp\Pages\Index.razor"
       
    public int MatchID { get; set; }
    public string SearchText;
    public List<Match> matchlist = new List<Match>();

    protected override async Task OnInitializedAsync()
    {
        Matchlist.Matches = await FootballMatchService.DownloadSerializesJsonData<List<Match>>();
        if(Matchlist.Matches != null)
        {
            foreach(Match match in Matchlist.Matches)
            {
                matchlist.Add(match);
            }
        }
    }

    private void GetMatch(FootballApp.Models.Match match)
    {
        //Add routing to singlematch page
        MatchID = match.Id;
        NavigationManager.NavigateTo("/single/" + MatchID);
    }
    //TODO: add a filter for the match list using a single textbox
    private void Search()
    {
        if (!string.IsNullOrWhiteSpace(SearchText))
        {
            SearchText = SearchText.ToLower();
            foreach(Match match in Matchlist.Matches)
            {
                matchlist.Add(match);
            }
            foreach(Match match in matchlist.ToList())
            {
                if(!match.HomeTeam.Name.ToLower().Contains(SearchText) & !match.AwayTeam.Name.ToLower().Contains(SearchText))
                {
                    matchlist.Remove(match);
                }
            }
        }
        else
        {
            foreach(Match match in Matchlist.Matches)
            {
                matchlist.Add(match);
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FootballMatchService FootballService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

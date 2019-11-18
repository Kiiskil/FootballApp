# FootballApp

*Blazor & .NET Core Exercise*

The point of this exercise it to create an ASP.NET Core 3 based website which displays football match results using Blazor. The data for the site is available from the following API: https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json 

*Functional Requirements*
The web app should include two web pages: One for showing a list of matches and one for showing details of a single match. For both pages, clean and modern UI is preferred though not required. List of matches The list view (which can be implemented as a table or as a list of some sorts) should contain all the matches available from the API. The following info should be available for each match: Date, Teams, Score.  
The match in the list view should be clickable or each match should contain “Details”-button. When user clicks the match/the details button, web app should move to the match details page. 

Optionally, the user should be able to filter the match list using a single textbox. In the textbox user could write the name of the team (or part of it), for example “IFK” and the list would filter out all the games except those where “IFK Mariehamn” or “HIFK” has played. 
Details of a single match The details page of a single match should contain the following information about the selected match:  Date, Teams, Team Logos, Score, List of match events (EventMinute, EventTypeIcon and Description is enough). 

*Implementation*

Required technologies are C# and ASP.NET Core 3’s Blazor. You can create a single web app which handles everything, or you can split the app into two ASP.NET Core projects: One for the backend (Web Api server) and one for the UI (Blazor). Tests are optional. It’s OK to use 3rd party libraries and Nuget packages. You can use CSS frameworks if you want. Blazor templates by default use Bootstrap 4. 
Tools JSONLint can be used to understand the structure of the data: https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json. 

Latest version of Visual Studio 2019 is needed. Community Version is available for free. Blazor documentation is available from https://docs.microsoft.com/en-us/aspnet/core/blazor/?view=aspnetcore3.0. For Blazor, make sure to use the Server version of it.

Simple REST-API that fetches a list of footballmatches from https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json as JSON and handles it through GET-requests.




API URLS:

    //GET /footballmatch/
        Returns a list of all matches

    //GET /footballmatch/list/ID
    */footballmatch/list/0/*
        Returns one match by listindex

    //GET /footballmatch/match/ID
    */footballmatch/match/316146/*
        Returns one match by its ID
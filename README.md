# FootballApp

Simple REST-API that fetches a list of footballmatches from https://functionapp2018071101324.blob.core.windows.net/data/matches_latest.json as JSON and handles it through GET-requests.

//All models were generated using Visual Studios tool
//copy JSON data to clipboard, go to EDIT > Paste Special > Paste JSON as classes
//https://devblogs.microsoft.com/aspnet/paste-json-as-classes-in-asp-net-and-web-tools-2012-2-rc/

API URLS:

    //GET /footballmatch/
        Returns a list of all matches

    //GET /footballmatch/list/ID
    */footballmatch/list/0/*
        Returns one match by listindex

    //GET /footballmatch/match/ID
    */footballmatch/match/316146/*
        Returns one match by its ID
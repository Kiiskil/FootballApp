using System;
using System.Collections.Generic;

namespace FootballAPI.Models{
    public class Match {
        public int ID {get;set;}
        public string Round {get;set;}
        public int RoundNumber {get;set;}
        public string MatchDate {get;set;}
        public Team HomeTeam {get;set;}
        public Team AwayTeam {get;set;}
        public int HomeGoals {get;set;}
        public int AwayGoals {get;set;}
        public int Status {get;set;}
        public int PlayedMinutes {get;set;}
        public bool SecondHalfStarted {get;set;}
        public string GameStarted {get;set;}
        public List<MatchEvent> MatchEvents {get;set;}
        public Array PeriodResults {get;set;}
        public bool OnlyResultsAvailable {get;set;}
        public int Season {get;set;}
        public string Country {get;set;}
        public string League {get;set;}
    }
}
using System;
using System.Collections.Generic;

namespace FootballAPI.Models{

    public class Matchlist
    {
        public List<Match> Matches { get; set; }
    }
    public class Match {
       public int Id { get; set; }
        public object Round { get; set; }
        public int RoundNumber { get; set; }
        public DateTime MatchDate { get; set; }
        public Hometeam HomeTeam { get; set; }
        public Awayteam AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public int Status { get; set; }
        public int PlayedMinutes { get; set; }
        public object SecondHalfStarted { get; set; }
        public DateTime? GameStarted { get; set; }
        public Matchevent[] MatchEvents { get; set; }
        public object[] PeriodResults { get; set; }
        public bool OnlyResultAvailable { get; set; }
        public int Season { get; set; }
        public string Country { get; set; }
        public string League { get; set; }
    }
}
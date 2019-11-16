namespace FootballAPI.Models{
    public class Match {
        public int ID {get;set;}
        public int Round {get;set;}
        public string MatchDate {get;set;}
        public int HomeGoals {get;set;}
        public int AwayGoals {get;set;}
        public int Status {get;set;}
        public int PlayedMinutes {get;set;}
        public bool SecondHalfStarted {get;set;}
        public string GameStarted {get;set;}
        public bool OnlyResultsAvailable {get;set;}
        public int Season {get;set;}
        public string Country {get;set;}
        public string League {get;set;}
    }
}
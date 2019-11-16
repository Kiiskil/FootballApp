namespace FootballAPI.Models{
    public class MatchEvent {
        public int ID {get;set;}
        public int MatchID {get;set;}
        public int EventMinute {get;set;}
        public int ElapsedSeconds {get;set;}
        public int TeamID {get;set;}
        public string Description {get;set;}
        public string FullDescription {get;set;}
        public string EventTypeIcon {get;set;}
        public string EventType {get;set;}
        public int EventTypeEnum {get;set;}
        public int PlayerID {get;set;}
        public string Player {get;set;}
        public string Identifier {get;set;}
        public string AssistPlayers {get;set;}
        public string AssistPlayersNames {get;set;}
        public string Modifier {get;set;}
        public int Score {get;set;}
        public bool IsGoal {get;set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Model
{
    [DataContract]
    public class FootballMatch
    {
        [DataMember(Name = "venue")]
        public string Venue { get; set; }

        [DataMember(Name = "location")]
        public string Location { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "time")]
        public string Time { get; set; }

        [DataMember(Name = "fifa_id")]
        public string FifaId { get; set; }

        [DataMember(Name = "attendance")]
        public string Attendance { get; set; }

        [DataMember(Name = "officials")]
        public string[] Officials { get; set; }

        [DataMember(Name = "stage_name")]
        public string StageName { get; set; }

        [DataMember(Name = "home_team_country")]
        public string HomeTeamCountry { get; set; }

        [DataMember(Name = "away_team_country")]
        public string AwayTeamCountry { get; set; }

        public DateTime Datetime { get; set; }

        [DataMember(Name = "winner")]
        public string Winner { get; set; }

        [DataMember(Name = "winner_code")]
        public string WinnerCode { get; set; }

        [DataMember(Name = "home_team")]
        public Country HomeTeam { get; set; }

        [DataMember(Name = "away_team")]
        public Country AwayTeam { get; set; }

        [DataMember(Name = "home_team_events")]
        public TeamEvent[] HomeTeamEvents { get; set; }

        [DataMember(Name = "away_team_events")]
        public TeamEvent[] AwayTeamEvents { get; set; }

        [DataMember(Name = "home_team_statistics")]
        public TeamStatistics HomeTeamStatistics { get; set; }

        [DataMember(Name = "away_team_statistics")]
        public TeamStatistics AwayTeamStatistics { get; set; }

        public DateTime LastEventUpdateAt { get; set; }
        public DateTime LastScoreUpdateAt { get; set; }

        public int AttendanceInt { get; set; }

        public override string ToString() => $"{HomeTeamCountry} vs {AwayTeamCountry} with {AttendanceInt}";
    }
}

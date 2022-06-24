using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Model
{
    [DataContract]
    public class Country
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "country")]
        public string CountryName { get; set; }

        [DataMember(Name = "alternate_name")]
        public string AlternateName { get; set; }

        [DataMember(Name = "code")]
        public string Code { get; set; }

        [DataMember(Name = "fifa_code")]
        public string FifaCode { get; set; }

        [DataMember(Name = "goals")]
        public int Goals { get; set; }

        [DataMember(Name = "group_id")]
        public int GroupId { get; set; }
        
        [DataMember(Name = "group_letter")]
        public string GroupLetter { get; set; }
                
        [DataMember(Name = "wins")]
        public int Wins { get; set; } 
        
        [DataMember(Name = "losses")]
        public int Losses { get; set; }
        
        [DataMember(Name = "games_played")]
        public int GamesPlayed { get; set; }

        [DataMember(Name = "points")]
        public int Points { get; set; }

        [DataMember(Name = "goals_for")]
        public int GoalsFor { get; set; }

        [DataMember(Name = "goals_against")]
        public int GoalsAgainst { get; set; }

        [DataMember(Name = "goal_differential")]
        public int GoalDifferential { get; set; }

        [DataMember(Name = "draws")]
        public int Draws { get; set; }

        public override string ToString() => $"{CountryName} ({FifaCode})";
    }
}

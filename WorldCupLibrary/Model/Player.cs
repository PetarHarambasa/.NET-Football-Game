using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Model
{
    [DataContract]
    public class Player
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "captain")]
        public bool Captain { get; set; }

        [DataMember(Name = "shirt_number")]
        public int ShirtNumber { get; set; }

        [DataMember(Name = "position")]
        public string Position { get; set; }
        public int Goals { get; set; }
        public int GoalsPenalty { get; set; }
        public int OwnGoals { get; set; }
        public int SubstitutionsIn { get; set; }
        public int SubstitutionsOut { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public bool Favourite { get; set; }

    }
}

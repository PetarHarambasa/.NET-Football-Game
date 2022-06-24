using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Model
{
    [DataContract]
    public class TeamStatistics
    {
        [DataMember(Name = "country")]
        public string Country { get; set; }

        [DataMember(Name = "starting_eleven")]
        public Player[] StartingEleven { get; set; }

        [DataMember(Name = "substitutes")]
        public Player[] Substitutes { get; set; }
    }
}

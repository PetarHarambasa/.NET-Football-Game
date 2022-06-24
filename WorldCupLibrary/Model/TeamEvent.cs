using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Model
{
    [DataContract]
    public class TeamEvent
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name ="type_of_event")]
        public string TypeOfEvent { get; set; } 

        [DataMember(Name = "player")]
        public string Player { get; set; } 

        [DataMember(Name = "time")]
        public string Time { get; set; }


    }
}

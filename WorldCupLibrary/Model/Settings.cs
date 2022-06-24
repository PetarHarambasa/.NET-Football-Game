using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Model
{
    [DataContract]
    public class Settings
    {
        [DataMember(Name = "language")]
        public string Language { get; set; }

        [DataMember(Name = "gender")]
        public string Gender { get; set; }

        [DataMember(Name = "favouriteCountry")]
        public string FavouriteCountry { get; set; }

        [DataMember(Name = "favouritePlayers")]
        public string[] FavouritePlayers { get; set; }

        [DataMember(Name = "windowSize")]
        public string WindowSize { get; set; }
    }
}

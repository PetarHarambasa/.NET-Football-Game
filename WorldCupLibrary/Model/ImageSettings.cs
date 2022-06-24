using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Model
{
    [DataContract]
    public class ImageSettings
    {
        [DataMember(Name = "FifaCode")]
        public string FifaCode { get; set; }

        [DataMember(Name = "Player")]
        public IList<PlayerImage> Player { get; set; }
    }
}

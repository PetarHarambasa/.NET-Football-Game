using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Model
{
    [DataContract]
    public class PlayerImage
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Path")]
        public string Path{ get; set; }

        public PlayerImage(string name, string path)
        {
            this.Name = name;
            this.Path = path;
        }
    }
}

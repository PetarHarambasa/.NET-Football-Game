using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCupLibrary.Model
{
    public class CountryMatches
    {
        public IList<Match> Data { get; set; }

        public IList<Player> StaringEleven { get; set; }
    }
}

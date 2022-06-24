using System.Collections;
using System.Collections.Generic;

namespace WorldCupLibrary.Model
{
    public class Match
    {
        public string AwayTeam{ get; set; }
        public string HomeTeam{ get; set; }
        public string FifaCodeAwayTeam { get; set; }
        public string FifaCodeHomeTeam { get; set; }
        public IList<Player> AwayPlayers { get; set; }
        public IList<Player> HomePlayers { get; set; }
        public int AwayTeamGoals { get; set; }
        public int HomeTeamGoals { get; set; }

        public override string ToString() => $"{AwayTeam} ({FifaCodeAwayTeam})";
    }
}
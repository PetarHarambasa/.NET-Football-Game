using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Model;

namespace WorldCupLibrary.Utils
{
    public class OrderListUtils
    {
        public static async Task<List<FootballMatch>> GetPopularFootballMatches(string fifaCode, string gender, string countryName)
        {
            IList<FootballMatch> footballMatches = await DataUtils.ReciveGameAsync(fifaCode, gender);
            footballMatches.ToList().ForEach(x => x.AttendanceInt = int.Parse(x.Attendance));
            
            return await Task.Run(() => footballMatches.OrderByDescending(match => match.AttendanceInt).ToList());
        }

        public static async Task<List<Player>> GetMostYellowCards(string fifaCode, string gender, string countryName)
        {
            IList<Player> players = await GetDataForSorting(fifaCode, gender, countryName);

            return (from player in players orderby player.YellowCards descending select player).ToList();
        }

        private static async Task<IList<Player>> GetDataForSorting(string fifaCode, string gender, string countryName)
        {
            IList<FootballMatch> footballMatches = await DataUtils.ReciveGameAsync(fifaCode, gender);
            IList<TeamEvent> teamEvents = GetTeamEvent(footballMatches, countryName);

            var players = await DataUtils.RecivePlayerAsync(fifaCode, gender);

            return GetPlayerEvent(players, teamEvents);
        }

        public static IList<Player> GetPlayerEvent(IList<Player> players, IList<TeamEvent> teamEvents)
        {
            IList<Player> playersEvent = players;

            foreach (var teamEvent in teamEvents)
            {
                Player playerEvent = (from player in players where player.Name == teamEvent.Player select player).FirstOrDefault();

                if (playerEvent != null)
                {
                    playersEvent.Remove(playerEvent);

                    switch (teamEvent.TypeOfEvent)
                    {
                        case "yellow-card":
                            ++playerEvent.YellowCards;
                            break; 
                        case "red-card":
                            ++playerEvent.RedCards;
                            break; 
                        case "substitution-in":
                            ++playerEvent.SubstitutionsIn;
                            break; 
                        case "substitution-out":
                            ++playerEvent.SubstitutionsOut;
                            break; 
                        case "goal-penalty":
                            ++playerEvent.GoalsPenalty;
                            break;
                        case "goal-own":
                            ++playerEvent.OwnGoals;
                            break;
                        case "goal":
                            ++playerEvent.Goals;
                            break;
                        default:
                            break;
                    }

                    playersEvent.Add(playerEvent);
                }

            }
                return playersEvent;
        }

        private static IList<TeamEvent> GetTeamEvent(IList<FootballMatch> footballMatches, string countryName)
        {
            TeamEvent[] teamEvents = null;
            IList<TeamEvent> events = new List<TeamEvent>();

            foreach (var match in footballMatches)
            {
                if (match.AwayTeamCountry == countryName)
                {
                    teamEvents = match.AwayTeamEvents;
                }
                else
                {
                    teamEvents = match.HomeTeamEvents;
                }

                foreach (var teamEvent in teamEvents)
                {
                    events.Add(teamEvent);
                }
            }
            return teamEvents;
        }

        public static async Task<List<Player>> GetMostGoalsPlayers(string fifaCode, string gender, string countryName)
        {
            IList<Player> players = await GetDataForSorting(fifaCode, gender, countryName);

            return (from player in players orderby player.Goals descending select player).ToList();
        }
    }
}

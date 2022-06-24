using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCupLibrary.Factory;
using WorldCupLibrary.Model;

namespace WorldCupLibrary.Utils
{
    public class DataUtils
    {
        private const string femaleCountry = @"http://worldcup.sfg.io/teams/results";
        private const string femaleMatch = @"http://worldcup.sfg.io/matches/country?fifa_code=";

        private const string maleCountry = @"https://world-cup-json-2018.herokuapp.com/teams/results";
        private const string maleMatch = @"https://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";

        public static async Task<IList<Country>> ReciveCountriesAsync(string gender) =>
            gender == "Male" ? await UrlConectionFactory<IList<Country>>.Load(maleCountry) : await UrlConectionFactory<IList<Country>>.Load(femaleCountry);

        public static async Task<IList<Player>> RecivePlayerAsync(string countryCode, string gender)
        {
            var contries = await ReciveCountriesAsync(gender);
            IList<Player> players = new List<Player>();

            foreach (var country in contries)
            {
                if (country.FifaCode == countryCode)
                {
                    var game = (await ReciveGameAsync(countryCode, gender)).First();
                    players = RecivePlayersFromGame(game, countryCode);
                }
            }

            return players;
        }

        private static IList<Player> RecivePlayersFromGame(FootballMatch game, string countryCode)
        {
            IList<Player> players = new List<Player>();
            TeamStatistics teamStatistics = game.AwayTeam.Code == countryCode ? game.AwayTeamStatistics : game.HomeTeamStatistics;

            foreach (var player in teamStatistics.StartingEleven)
            {
                players.Add(player);
            }

            foreach (var player in teamStatistics.Substitutes)
            {
                players.Add(player);
            }

            return players;
        }

        public static async Task<IList<FootballMatch>> ReciveGameAsync(string countryCode, string gender) => gender == "Male" ?
            await UrlConectionFactory<IList<FootballMatch>>.Load(maleMatch + countryCode) : await UrlConectionFactory<IList<FootballMatch>>.Load(femaleMatch + countryCode);

        public static async Task<Country> ReciveCountryTeamAsync(string countryCode, string gender)
        {
            IList<Country> countries = await ReciveCountriesAsync(gender);

            foreach (var country in countries)
            {
                if (country.FifaCode == countryCode)
                {
                    return country;
                }
            }

            return null;
        }

        public static async Task<CountryMatches> ReciveDataForMatchAsync(Country homeTeam, string gender)
        {
            IList<FootballMatch> footballMatches = await ReciveGameAsync(homeTeam.FifaCode, gender);
            CountryMatches matchData = new CountryMatches
            {
                StaringEleven = footballMatches[0].HomeTeamStatistics.StartingEleven.ToList(),
                Data = new List<Match>()
            };

            foreach (var match in footballMatches)
            {
                var data = new Match();

                if (match.AwayTeamCountry == homeTeam.CountryName)
                {
                    data.HomeTeam = match.AwayTeamCountry;
                    data.FifaCodeHomeTeam = match.AwayTeam.Code;
                    data.HomeTeamGoals = match.AwayTeam.Goals;
                    data.HomePlayers = OrderListUtils.GetPlayerEvent(match.AwayTeamStatistics.StartingEleven.ToList(), match.AwayTeamEvents);
                }
                else
                {
                    data.AwayTeam = match.AwayTeamCountry;
                    data.FifaCodeAwayTeam = match.AwayTeam.Code;
                    data.AwayTeamGoals = match.AwayTeam.Goals;
                    data.AwayPlayers = OrderListUtils.GetPlayerEvent(match.AwayTeamStatistics.StartingEleven.ToList(), match.AwayTeamEvents);
                }

                if (match.HomeTeamCountry == homeTeam.CountryName)
                {
                    data.HomeTeam = match.HomeTeamCountry;
                    data.FifaCodeHomeTeam = match.HomeTeam.Code;
                    data.HomeTeamGoals = match.HomeTeam.Goals;
                    data.HomePlayers = OrderListUtils.GetPlayerEvent(match.HomeTeamStatistics.StartingEleven.ToList(), match.HomeTeamEvents);
                }
                else
                {
                    data.AwayTeam = match.HomeTeamCountry;
                    data.FifaCodeAwayTeam = match.HomeTeam.Code;
                    data.AwayTeamGoals = match.HomeTeam.Goals;
                    data.AwayPlayers = OrderListUtils.GetPlayerEvent(match.HomeTeamStatistics.StartingEleven.ToList(), match.HomeTeamEvents);
                }
                matchData.Data.Add(data);
            }

            return matchData;
        }
    }

}

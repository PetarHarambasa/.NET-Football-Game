using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WorldCupLibrary.Model;
using WorldCupLibrary.User;
using WorldCupLibrary.Utils;
using WpfApp.Controls;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for FootballMatch.xaml
    /// </summary>
    public partial class FootballMatch : Window
    {
        private const string DEFAULT_RES = "0";
        private const string HOMETEAM = "Home";
        private const string AWAYTEAM = "Away";
        private const string WINDOW_SIZE = "Maximized";
        private const char DEL = 'x';
        private bool changeChampionship = false;

        private IList<ImageSettings> imageSettings = new List<ImageSettings>();
        public CountryMatches CountryMatches { get; set; }
        public string HomeCountryCode { get; set; }
        public string AwayCountryCode { get; set; }
        public Country HomeTeam { get; set; }
        public IList<Country> Teams { get; set; }
        public FootballMatch()
        {
            if (User.settings.WindowSize == WINDOW_SIZE)
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                string[] details = User.settings.WindowSize.Split(DEL);

                this.Width = int.Parse(details[0]);
                this.Height = int.Parse(details[1]);
            }
            InitializeComponent();
        }

        public FootballMatch(bool changeChampionship, WindowState screenResoultion)
        {
            InitializeComponent();
            this.changeChampionship = changeChampionship;
            this.WindowState = screenResoultion;
            imageSettings = User.LoadImageSettings();
        }

        public FootballMatch(bool changeChampionship, int width, int height)
        {
            InitializeComponent();
            this.changeChampionship = changeChampionship;
            this.Width = width;
            this.Height = height;
            imageSettings = User.LoadImageSettings();
        }

        private void btnHomeTeam_Click(object sender, RoutedEventArgs e)
        {
            if (cbHomeTeam.SelectedItem != null)
            {
                Country country = cbHomeTeam.SelectedItem as Country;
                TeamStatistics teamStatistics = new TeamStatistics(country);
                teamStatistics.Show();
            }
        }

        private async void cbHomeTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearResults();
            string countryCode = GetCountryCodeFromComboBox(sender);
            HomeCountryCode = countryCode;

            if (countryCode != null)
            {
                ClearAwayTeam();
                ClearHomeTeam();

                try
                {
                    HomeTeam = await DataUtils.ReciveCountryTeamAsync(countryCode, User.settings.Gender);
                    await FillCountryAwayTeamComboBox(HomeTeam);
                    FillPanel(CountryMatches.StaringEleven, HOMETEAM);
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message);
                    Application.Current.Shutdown();
                }
            }
        }

        private void FillPanel(IList<Player> staringEleven, string teamType)
        {
            foreach (var player in staringEleven)
            {
                PlayerCard playCard = new PlayerCard(player);

                if (imageSettings.Count != 0)
                {
                    foreach (ImageSettings imageSettings in imageSettings)
                    {
                        if (imageSettings.FifaCode == HomeCountryCode)
                        {
                            foreach (PlayerImage playerImage in imageSettings.Player)
                            {
                                if (player.Name == playerImage.Name)
                                {
                                    playCard.SetImage(playerImage.Path);
                                    break;
                                }
                            }
                            break;
                        }

                        if (imageSettings.FifaCode == AwayCountryCode)
                        {
                            foreach (PlayerImage playerImage in imageSettings.Player)
                            {
                                if (player.Name == playerImage.Name)
                                {
                                    playCard.SetImage(playerImage.Path);
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
                if (teamType == HOMETEAM)
                {
                    SetHomeTeamPanel(player.Position, playCard);
                }
                else
                {
                    SetAwayTeamPanel(player.Position, playCard);
                }
            }
        }

        private void SetHomeTeamPanel(string position, PlayerCard playCard)
        {
            switch (position)
            {
                case "Defender":
                    spDefendHome.Children.Add(playCard);
                    break;
                case "Forward":
                    spForwardHome.Children.Add(playCard);
                    break;
                case "Goalie":
                    spGoalHome.Children.Add(playCard);
                    break;
                case "Midfield":
                    spMiddleHome.Children.Add(playCard);
                    break;
                default:
                    break;
            }
        }

        private void SetAwayTeamPanel(string position, PlayerCard playCard)
        {
            switch (position)
            {
                case "Defender":
                    spDefendAway.Children.Add(playCard);
                    break;
                case "Forward":
                    spForwardAway.Children.Add(playCard);
                    break;
                case "Goalie":
                    spGoalAway.Children.Add(playCard);
                    break;
                case "Midfield":
                    spMiddleAway.Children.Add(playCard);
                    break;
                default:
                    break;
            }
        }

        private async Task FillCountryAwayTeamComboBox(Country homeTeam)
        {
            cbAwayTeam.SelectedItem = null;
            CountryMatches = await DataUtils.ReciveDataForMatchAsync(homeTeam, User.settings.Gender);
            cbAwayTeam.ItemsSource = CountryMatches.Data;
        }

        private string GetCountryCodeFromComboBox(object sender)
        {
            ComboBox comboBox = sender as ComboBox;

            string countryCode = null;

            if (comboBox.SelectedItem != null)
            {
                countryCode = User.GetCountryCode(comboBox.SelectedValue.ToString());
            }

            return countryCode;
        }

        private void ClearResults()
        {
            lbHomeTeamRes.Content = DEFAULT_RES;
            lbAwayTeamRes.Content = DEFAULT_RES;
        }

        private async void btnAwayTeam_Click(object sender, RoutedEventArgs e)
        {
            if (cbAwayTeam.SelectedItem != null)
            {
                Match match = cbAwayTeam.SelectedItem as Match;
                Country country = await DataUtils.ReciveCountryTeamAsync(match.FifaCodeAwayTeam, User.settings.Gender);
                TeamStatistics teamStatistics = new TeamStatistics(country);
                teamStatistics.Show();
            }
        }

        private void cbAwayTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearAwayTeam();
            ClearHomeTeam();

            string countryCode = GetCountryCodeFromComboBox(sender);
            AwayCountryCode = countryCode;

            if (countryCode != null)
            {
                foreach (var team in CountryMatches.Data)
                {
                    if (team.FifaCodeAwayTeam == countryCode)
                    {
                        try
                        {
                            FillPanel(team.AwayPlayers, AWAYTEAM);
                            FillPanel(team.HomePlayers, HOMETEAM);
                            SetMatchResults(team.HomeTeamGoals, team.AwayTeamGoals);
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.Message);
                            Application.Current.Shutdown();
                        }
                    }
                }
            }
        }

        private void SetMatchResults(int homeTeamGoals, int awayTeamGoals)
        {
            lbHomeTeamRes.Content = homeTeamGoals.ToString();
            lbAwayTeamRes.Content = awayTeamGoals.ToString();
        }

        protected async override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);
            ClearHomeTeam();
            ClearAwayTeam();

            try
            {
                HomeCountryCode = User.settings.FavouriteCountry != null ? User.GetCountryCode(User.settings.FavouriteCountry) : null;
                Teams = await DataUtils.ReciveCountriesAsync(User.settings.Gender);
                cbHomeTeam.ItemsSource = Teams;

                if (HomeCountryCode != null)
                {
                    if (!changeChampionship)
                    {
                        HomeTeam = await DataUtils.ReciveCountryTeamAsync(HomeCountryCode, User.settings.Gender);

                        if (HomeTeam != null)
                        {
                            await FillCountryAwayTeamComboBox(HomeTeam);
                            FillPanel(CountryMatches.StaringEleven, HOMETEAM);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                Application.Current.Shutdown();
            }
        }

        private void ClearAwayTeam()
        {
            spGoalAway.Children.Clear();
            spDefendAway.Children.Clear();
            spForwardAway.Children.Clear();
            spMiddleAway.Children.Clear();
        }

        private void ClearHomeTeam()
        {
            spGoalHome.Children.Clear();
            spDefendHome.Children.Clear();
            spForwardHome.Children.Clear();
            spMiddleHome.Children.Clear();
        }

        protected override void OnClosed(EventArgs e)
        {
            User.SaveSettings();
            base.OnClosed(e);
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            Settings settingsWindow = new Settings();
            Hide();
            settingsWindow.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            AreYouSureWindow areYouSureWindow = new AreYouSureWindow();
            areYouSureWindow.Show();
        }
    }
}

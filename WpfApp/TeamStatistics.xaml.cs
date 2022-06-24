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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for TeamStatistics.xaml
    /// </summary>
    public partial class TeamStatistics : Window
    {
        public TeamStatistics(Country country)
        {
            InitializeComponent();
            lbCountry.Content = country.CountryName;
            lbFifaCode.Content = $"({country.FifaCode})";
            lbTotalMatchesNumber.Content = country.GamesPlayed;
            lbWinsNumber.Content = country.Wins;
            lbLosesNumber.Content = country.Losses;
            lbUndecidedNumber.Content = country.Draws;
            lbGoalsScoredNumber.Content = country.GoalsFor;
            lbGoalsConcededNumber.Content = country.GoalsAgainst;
            lbGoalsDiffNumber.Content = country.GoalDifferential;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

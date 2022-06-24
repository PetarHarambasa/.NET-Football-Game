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
    /// Interaction logic for PlayerStatistics.xaml
    /// </summary>
    public partial class PlayerStatistics : Window
    {

        public PlayerStatistics(Player player)
        {
            InitializeComponent();
            lbNumber.Content = player.ShirtNumber;
            lbNumberOfGoals.Content = player.Goals;
            lbNumberOfYellowCards.Content = player.YellowCards;
            lbIsCaptain.Content = player.Captain ? Properties.Resources.btnYes : Properties.Resources.btnNo;
            lbPlayerName.Content = player.Name;
        }

        public Player Player { get; }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void SetImage(string imagePath)
        {
            BitmapImage image = new BitmapImage(new Uri(imagePath, UriKind.Absolute));
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.Freeze();

            imgPlayer.Source = image;
        }
    }
}

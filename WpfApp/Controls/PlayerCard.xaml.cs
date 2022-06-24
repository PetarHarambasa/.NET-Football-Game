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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorldCupLibrary.Model;

namespace WpfApp.Controls
{
    /// <summary>
    /// Interaction logic for PlayerCard.xaml
    /// </summary>
    public partial class PlayerCard : UserControl
    {
        private Player player;
        private string imagePath;

        public PlayerCard(Player player)
        {
            InitializeComponent();
            this.player = player;

            lblName.Content = player.Name;
            lblNumber.Content = player.ShirtNumber.ToString();
            
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PlayerStatistics playerStatistics = new PlayerStatistics(player);

            if (imagePath != null)
            {
                playerStatistics.SetImage(imagePath);
            }
            playerStatistics.Show();
        }

        public void SetImage(string path)
        {
            imagePath = path;
            BitmapImage image = new BitmapImage(new Uri(path, UriKind.Absolute));
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.Freeze();
            imgPlayer.Source = image;
        }
    }
}

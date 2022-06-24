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
using WorldCupLibrary.User;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for AreYouSureWindow.xaml
    /// </summary>
    public partial class AreYouSureWindow : Window
    {
        private const char DEL = 'x';
        private bool changeChampionship = false;
        public AreYouSureWindow()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            User.LoadSettings();
            string screenResolution = User.settings.WindowSize;
            string[] details = screenResolution.Split(DEL);
            FootballMatch footballMatch = new FootballMatch(changeChampionship, int.Parse(details[0]), int.Parse(details[1]));
            Close();
            footballMatch.Show();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Application.Current.Shutdown();
            }

            if (e.Key == Key.Escape)
            {
                User.LoadSettings();
                string screenResolution = User.settings.WindowSize;
                string[] details = screenResolution.Split(DEL);
                FootballMatch footballMatch = new FootballMatch(changeChampionship, int.Parse(details[0]), int.Parse(details[1]));
                Close();
                footballMatch.Show();
            }
        }
    }
}

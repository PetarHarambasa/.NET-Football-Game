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
    /// Interaction logic for SaveForm.xaml
    /// </summary>
    public partial class SaveForm : Window
    {
        private const char DEL = 'x';

        private bool changeChampionship = false;
        private int width;
        private int height;
        private WindowState windowSize;
        private Window parent;

        public SaveForm(bool changeChampionships, WindowState screenResolution, Window window)
        {
            InitializeComponent();
            this.changeChampionship = changeChampionships;
            this.windowSize = screenResolution;
            this.parent = window;
        }

        public SaveForm(bool changeChampionships, int width, int height, Window window)
        {
            InitializeComponent();
            this.changeChampionship = changeChampionships;
            this.width = width;
            this.height = height;
            this.parent = window;
        }

        private void btnYes_Click(object sender, RoutedEventArgs e)
        {
            if (this.windowSize != WindowState.Normal)
            {
                User.settings.WindowSize = windowSize.ToString();
                FootballMatch footballMatch = new FootballMatch(changeChampionship, windowSize);
                Close();
                parent.Close();
                footballMatch.Show();
            }
            else
            {
                User.settings.WindowSize = width.ToString() + DEL + height.ToString();
                FootballMatch footballMatch = new FootballMatch(changeChampionship, width, height);
                Close();
                parent.Close();
                footballMatch.Show();
            }
        }

        private void btnNo_Click(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            Close();
            parent.Close();
            settings.Show();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (this.windowSize != WindowState.Normal)
                {
                    User.settings.WindowSize = windowSize.ToString();
                    FootballMatch footballMatch = new FootballMatch(changeChampionship, windowSize);
                    Close();
                    parent.Close();
                    footballMatch.Show();
                }
                else
                {
                    User.settings.WindowSize = width.ToString() + DEL + height.ToString();
                    FootballMatch footballMatch = new FootballMatch(changeChampionship, width, height);
                    Close();
                    parent.Close();
                    footballMatch.Show();
                }
            }
            if (e.Key == Key.Escape)
            {
                Settings settings = new Settings();
                Close();
                parent.Close();
                settings.Show();
            }
        }
    }
}

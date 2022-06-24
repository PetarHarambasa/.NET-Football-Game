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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        private const string HR = "hr-HR";
        private const string ENG = "en-US";

        private const string MALE = "Male";
        private const string FEMALE = "Female";

        private const char DEL = 'x';
        private bool changeChampionship = false;

        public Settings()
        {
            InitializeComponent();
        }

        private void btnSaveSettings_Click(object sender, RoutedEventArgs e)
        {
            if (rbCro.IsChecked == true)
            {
                SetLangauge(HR);
            }
            if (rbEng.IsChecked == true)
            {
                SetLangauge(ENG);
            }
            if (rbMale.IsChecked == true)
            {
                SetGender(MALE);
            }
            if (rbFemale.IsChecked == true)
            {
                SetGender(FEMALE);
            }
            if (rb1280x720.IsChecked == true)
            {
                NewFormResolution("1280x720");
            }
            if (rb1366x768.IsChecked == true)
            {
                NewFormResolution("1366x768");
            }
            if (rb1440x900.IsChecked == true)
            {
                NewFormResolution("1440x900");
            }
            if (rbFullScreen.IsChecked == true)
            {
                NewFormFullScreen(WindowState.Maximized);
            }
        }

        private void NewFormFullScreen(WindowState screenResolution)
        {
            SaveForm saveForm = new SaveForm(changeChampionship, screenResolution, this);
            saveForm.Show();
        }

        private void NewFormResolution(string screenResolution)
        {
            string[] details = screenResolution.Split(DEL);
            User.settings.WindowSize = screenResolution;
            SaveForm saveForm = new SaveForm(changeChampionship, int.Parse(details[0]), int.Parse(details[1]), this);
            saveForm.Show();
        }

        private void SetGender(string gender)
        {
            if (User.settings.Gender != gender)
            {
                changeChampionship = true;
            }
            else
            {
                changeChampionship = false;
            }
            User.settings.Gender = gender;
        }

        private void SetLangauge(string language)
        {
            User.settings.Language = language;
            User.SetLanguage(language);
        }

        private void btnCloseSettings_Click(object sender, RoutedEventArgs e)
        {
            FootballMatch footballMatch = new FootballMatch();
            this.Hide();
            footballMatch.Show();
            Close();
        }
    }
}

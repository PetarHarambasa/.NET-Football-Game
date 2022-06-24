using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Controls;
using WorldCupLibrary.Model;
using WorldCupLibrary.User;
using WorldCupLibrary.Utils;

namespace WindowsFormsApp
{
    public partial class RankListForm : Form
    {
        private const string GOAl = "Goal";
        private const string CARD = "Card";

        private string gender;
        private string fifaCode;
        private string countryName;
        private ImageSettings imageSettings = new ImageSettings();


        public RankListForm()
        {
            InitializeComponent();
        }

        private async void RangListForm_Load(object sender, EventArgs e)
        {
            User.SetLanguage(User.settings.Language);

            lbRankListMenu.Text = Resources.Resource.lbRankListMenu;
            lbMostGoals.Text = Resources.Resource.lbMostGoals;
            lbYellowCards.Text = Resources.Resource.lbYellowCards;
            lbPopularMatches.Text = Resources.Resource.lbPopularMatches;
            lbRankListMenu.Text = Resources.Resource.lbRankListMenu;
            btnExit.Text = Resources.Resource.btnExit;
            btnPrint.Text = Resources.Resource.btnPrint;
            btnSettings.Text = Resources.Resource.btnSettings;
            this.Text = Resources.Resource.RankListForm;

            gender = User.settings.Gender;
            fifaCode = User.GetCountryCode(User.settings.FavouriteCountry);
            countryName = User.CountryName;
            imageSettings = User.imageSettings.FirstOrDefault(x => x.FifaCode == fifaCode);


            try
            {
                await MostGoalsList();
                await MostYelloCards();
                await PopularMatches();
            }
            catch (Exception error) 
            {

                if (MessageBox.Show(error.Message + "\n" + Resources.Resource.lbError2, "Error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    StartForm startForm = new StartForm();
                    Close();
                    startForm.Show();
                }
            }
        }

        private async Task PopularMatches()
        {
            var popularMatches = await OrderListUtils.GetPopularFootballMatches(fifaCode, gender, countryName);
            foreach (var match in popularMatches)
            {
                flpPopularMatches.Controls.Add(FootballMatchCard.Set(match));
            }
        }

        private async Task MostYelloCards()
        {
            var mostYellowCardsPlayer = await OrderListUtils.GetMostYellowCards(fifaCode, gender, countryName);

            foreach (var player in mostYellowCardsPlayer)
            {
                bool existsPlayerImage = false;

                if (imageSettings != null && imageSettings.Player != null)
                {
                    foreach (PlayerImage playerImage in imageSettings.Player)
                    {
                        if (player.Name == playerImage.Name)
                        {
                            flpMostYellowCards.Controls.Add(PlayerCardRankList.SetPlayerWithImage(player, playerImage.Path, CARD));
                            existsPlayerImage = true;
                            break;
                        }
                    }
                }
                if (!existsPlayerImage || imageSettings.Player == null)
                {
                    flpMostYellowCards.Controls.Add(PlayerCardRankList.Set(player, CARD));
                }
            }
        }

        private async Task MostGoalsList()
        {
            var mostGoalsPlayers = await OrderListUtils.GetMostGoalsPlayers(fifaCode, gender, countryName);

            foreach (var player in mostGoalsPlayers)
            {
                bool existPlayerImage = false;

                if (imageSettings != null && imageSettings.Player != null)
                {
                    foreach (PlayerImage playerImage in imageSettings.Player)
                    {
                        if (player.Name == playerImage.Name)
                        {
                            flpMostGoals.Controls.Add(PlayerCardRankList.SetPlayerWithImage(player, playerImage.Path, GOAl));
                            existPlayerImage = true;
                            break;
                        }
                    }
                }

                if (!existPlayerImage || imageSettings.Player == null)
                {
                    flpMostGoals.Controls.Add(PlayerCardRankList.Set(player, GOAl));
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            PrintDialog printDialog = new PrintDialog{ Document = printDocument };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            float X = e.MarginBounds.Left + flpMostYellowCards.Width;
            float Y = e.MarginBounds.Top + flpMostYellowCards.Height;

            Bitmap bitmap1 = new Bitmap(500, 600);
            lbMostGoals.DrawToBitmap(bitmap1, new Rectangle(0, 0, flpMostGoals.Width, flpMostGoals.Height));
            flpMostGoals.DrawToBitmap(bitmap1, new Rectangle(0, 30, flpMostGoals.Width, flpMostGoals.Height));

            Bitmap bitmap2 = new Bitmap(500, 600);
            lbYellowCards.DrawToBitmap(bitmap2, new Rectangle(0, 0, flpMostGoals.Width, flpMostGoals.Height));
            flpMostYellowCards.DrawToBitmap(bitmap2, new Rectangle(0, 30, flpMostYellowCards.Width, flpMostYellowCards.Height));
            
            Bitmap bitmap3 = new Bitmap(500, 600);
            lbPopularMatches.DrawToBitmap(bitmap3, new Rectangle(0, 0, flpMostGoals.Width, flpMostGoals.Height));
            flpPopularMatches.DrawToBitmap(bitmap3, new Rectangle(0, 30, flpPopularMatches.Width, flpPopularMatches.Height));

            e.Graphics.DrawImage(bitmap1, 0, 0);
            e.Graphics.DrawImage(bitmap2, X, 0);
            e.Graphics.DrawImage(bitmap3, X - 250, Y - 45);


        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm(this);
            Hide();
            settings.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            User.SaveSettings();
            Application.Exit();
        }
    }
}

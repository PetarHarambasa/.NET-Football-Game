using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Controls;
using WindowsFormsApp.Resources;
using WorldCupLibrary.Model;
using WorldCupLibrary.User;
using WorldCupLibrary.Utils;

namespace WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private const int SELECTEDCARDS = 3;
        private string selectedCountry;
        private static IList<ImageSettings> imageSettings = new List<ImageSettings>();
        private static ImageSettings playerImage = new ImageSettings();
        private static IList<string> loadedFavouritePlayers = new List<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            lbPlayerMenu.Text = Resource.lbPlayerMenu;
            lbChooseCountry.Text = Resource.lbChooseCountry;
            lbAllPlayers.Text = Resource.lbAllPlayers;
            lbFavouritePlayers.Text = Resource.lbFavouritePlayers;
            btnSaveChanges.Text = Resource.btnSaveChanges;
            btnAddFavouritePlayer.Text = Resource.btnAddFavouritePlayer;
            btnRemovePlayer.Text = Resource.btnRemovePlayer;

            try
            {
                imageSettings = User.LoadImageSettings();
                loadedFavouritePlayers = User.settings.FavouritePlayers;
                await LoadCountry();
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

        private async Task LoadCountry()
        {
            IList<Country> countries = await DataUtils.ReciveCountriesAsync(User.settings.Gender);

            foreach (Country country in countries)
            {
                cbChoosedCountry.Items.Add(country);
            }
        }

        public static void SavePlayerPicture(string name, string fileName)
        {
            if (fileName != string.Empty)
            {
                PlayerImage playerImageExists = playerImage.Player.ToList().Find(obj => obj.Name.Equals(name));

                if (playerImageExists != null)
                {
                    playerImageExists.Path = fileName;
                } 
                else
                {
                    playerImage.Player.Add(new PlayerImage(name, fileName));
                }
            }
        }

        private void cbChoosedCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (playerImage.FifaCode != null)
            {
                if (imageSettings.ToList().FindIndex(x => x.FifaCode == playerImage.FifaCode) == -1)
                {
                    imageSettings.Add(playerImage);
                }
                imageSettings[imageSettings.ToList().FindIndex(x => x.FifaCode == playerImage.FifaCode)] = playerImage;
            }

            playerImage = new ImageSettings();
            playerImage.Player = new List<PlayerImage>();
            playerImage.FifaCode = User.GetCountryCode(cbChoosedCountry.Text);

            if (imageSettings != null)
            {
                foreach (ImageSettings image in imageSettings)
                {
                    if (image.FifaCode == playerImage.FifaCode)
                    {
                        image.Player.ToList().ForEach(x => playerImage.Player.Add(x));
                    }
                }
            }

            selectedCountry = cbChoosedCountry.Text;
            LoadPlayers();
        }

        private async void LoadPlayers()
        {
            try
            {
                IList<Player> players = await DataUtils.RecivePlayerAsync(User.GetCountryCode(selectedCountry), User.settings.Gender);
                LoadPanels(players);
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

        private void LoadPanels(IList<Player> players)
        {
            flpAllPlayers.Controls.Clear();
            flpFavouritePlayers.Controls.Clear();

            ImageSettings selectedImage = imageSettings.Where(x => x.FifaCode == User.GetCountryCode(cbChoosedCountry.Text)).FirstOrDefault();

            foreach (Player player in players)
            {
                bool existsPlayer = false;
                bool existsFavouritePlayer = false;

                if (selectedImage != null && selectedImage.Player.Count != 0 && loadedFavouritePlayers.Count == 0)
                {
                    foreach (PlayerImage playerImage in selectedImage.Player)
                    {
                        if (player.Name == playerImage.Name)
                        {
                            existsPlayer = true;
                            flpAllPlayers.Controls.Add(PlayerCard.SetPlayerWithImage(player, playerImage.Path));
                            break;
                        }
                    }
                }

                if (selectedImage != null && selectedImage.Player.Count == 0 && loadedFavouritePlayers.Count != 0)
                {
                    foreach (string favouritePlayer in loadedFavouritePlayers)
                    {
                        if (player.Name == favouritePlayer)
                        {
                            player.Favourite = true;
                            existsFavouritePlayer = true;
                            flpFavouritePlayers.Controls.Add(PlayerCard.Set(player));
                            break;
                        }
                    }
                }

                if (selectedImage != null && selectedImage.Player.Count != 0 && loadedFavouritePlayers.Count != 0)
                {
                    foreach (string favouritePlayers in loadedFavouritePlayers)
                    {
                        foreach (PlayerImage playerImage in selectedImage.Player)
                        {
                            if (player.Name == favouritePlayers && player.Name == playerImage.Name && favouritePlayers == playerImage.Name)
                            {
                                player.Favourite = true;
                                existsFavouritePlayer = true;
                                existsPlayer = true;
                                flpFavouritePlayers.Controls.Add(PlayerCard.SetPlayerWithImage(player, playerImage.Path));
                                break;
                            }
                        }

                        if (player.Name == favouritePlayers && !existsFavouritePlayer)
                        {
                            player.Favourite = true;
                            existsFavouritePlayer = true;
                            flpFavouritePlayers.Controls.Add(PlayerCard.Set(player));
                            break;
                        }

                        if (existsFavouritePlayer && existsPlayer)
                        {
                            break;
                        }
                    }
                }
                if (!existsPlayer && !existsFavouritePlayer)
                {
                    PlayerImage playerImageExists = playerImage.Player.ToList().Find(obj => obj.Name.Equals(player.Name));

                    if (playerImageExists != null)
                    {
                        flpAllPlayers.Controls.Add(PlayerCard.SetPlayerWithImage(player, playerImageExists.Path));
                    } 
                    else
                    {
                        flpAllPlayers.Controls.Add(PlayerCard.Set(player));
                    }
                }
            }
        }


        private void btnAddFavouritePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                IList<PlayerCard> playerCardsToMove = GetSelectedPlayersFromPanel(flpAllPlayers);
                if (!CheckNumberOfPlayerCard(playerCardsToMove))
                {
                    return;
                }
                SetFavouriteIcon(playerCardsToMove, true);
                MovePlayer(playerCardsToMove, flpAllPlayers, flpFavouritePlayers);

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

        private void flpAllPlayers_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flpAllPlayers_DragOver(object sender, DragEventArgs e)
        {
            try
            {
                PlayerCard playerCard = (PlayerCard)e.Data.GetData(typeof(PlayerCard));
                IList<PlayerCard> playerCardToMove = GetSelectedPlayersFromPanel(flpFavouritePlayers);
                playerCardToMove.Add(playerCard);

                SetFavouriteIcon(playerCardToMove, false);
                MovePlayer(playerCardToMove, flpFavouritePlayers, flpAllPlayers);
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

        private void flpFavouritePlayers_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                PlayerCard playerCard = (PlayerCard)e.Data.GetData(typeof(PlayerCard));
                IList<PlayerCard> playerCardsToMove = GetSelectedPlayersFromPanel(flpAllPlayers);
                playerCardsToMove.Add(playerCard);

                if (!CheckNumberOfPlayerCard(playerCardsToMove))
                {
                    return;
                }

                SetFavouriteIcon(playerCardsToMove, true);
                MovePlayer(playerCardsToMove, flpAllPlayers, flpFavouritePlayers);
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

        private void flpFavouritePlayers_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private bool CheckNumberOfPlayerCard(IList<PlayerCard> playerCardsToMove)
        {
            if (flpFavouritePlayers.Controls.Count + playerCardsToMove.Count > SELECTEDCARDS)
            {
                MessageBox.Show(Resource.lblErrorNumberSelectedPlayer);
                return false;
            }
            return true;
        }

        private IList<PlayerCard> GetSelectedPlayersFromPanel(FlowLayoutPanel panel)
        {
            IList<PlayerCard> playerCardsToMove = new List<PlayerCard>();

            foreach (PlayerCard playerCard in panel.Controls)
            {
                if (playerCard.Selected)
                {
                    playerCardsToMove.Add(playerCard);
                }
            }

            return playerCardsToMove;
        }

        private void MovePlayer(IList<PlayerCard> playerCardsToMove, FlowLayoutPanel fromPanel, FlowLayoutPanel toPanel)
        {
            foreach (PlayerCard playerCard in playerCardsToMove)
            {
                if (playerCard.Selected)
                {
                    playerCard.UnSelected();
                }
                fromPanel.Controls.Remove(playerCard);
                toPanel.Controls.Add(playerCard);
            }
        }

        private void SetFavouriteIcon(IList<PlayerCard> playerCardsToMove, bool favourite)
        {
            foreach (PlayerCard playerCard in playerCardsToMove)
            {
                playerCard.SetFavourite(favourite);
            }
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            try
            {
                IList<PlayerCard> playerCardsToMove = GetSelectedPlayersFromPanel(flpFavouritePlayers);
                SetFavouriteIcon(playerCardsToMove, false);
                MovePlayer(playerCardsToMove, flpFavouritePlayers, flpAllPlayers);
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

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedCountry == null)
                {
                    MessageBox.Show(Resources.Resource.lbError,"Error");
                    return;
                }

                if (imageSettings.ToList().FindIndex(x => x.FifaCode == playerImage.FifaCode) == -1)
                {
                    imageSettings.Add(playerImage);
                }
                imageSettings[imageSettings.ToList().FindIndex(x => x.FifaCode == playerImage.FifaCode)] = playerImage;

                User.settings.FavouritePlayers = SaveFavouritePlayers();
                User.settings.FavouriteCountry = selectedCountry;
                User.imageSettings = imageSettings;

                User.SaveImageSettings();
                User.SaveSettings();

                RankListForm rankListForm = new RankListForm();
                Hide();
                rankListForm.Show();
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

        private string[] SaveFavouritePlayers()
        {
            IList<string> favouritePlayers = new List<string>();

            foreach (PlayerCard playerCard in flpFavouritePlayers.Controls)
            {
                favouritePlayers.Add(playerCard.GetPlayerName());
            }
            return favouritePlayers.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupLibrary.Model;

namespace WindowsFormsApp.Controls
{
    public partial class PlayerCard : UserControl
    {
        private const char DEL = '.';
        private IList<string> extensions = new List<string>() 
        {
            "jpg",
            "jpeg",
            "png",
            "gif"
        };

        public bool Selected { get; set; }
        public PlayerCard()
        {
            InitializeComponent();
        }

        public static Control SetPlayerWithImage(Player player, string path)
        {
            PlayerCard playerCard = new PlayerCard();
            SetPlayerCardProp(playerCard, player);
            playerCard.pbPlayerImage.ImageLocation = path;

            return playerCard;
        }

        private static void SetPlayerCardProp(PlayerCard playerCard, Player player)
        {
            playerCard.lbName.Text = player.Name;
            playerCard.lbNumber.Text = player.ShirtNumber.ToString();
            playerCard.lbPosition.Text = player.Position;
            playerCard.lbIsCaptain.Text = player.Captain ? Resources.Resource.lbIsCaptainTrue : Resources.Resource.lbIsCaptainFalse;
            playerCard.pbStar.Image = player.Favourite ? Resources.Image.star : Resources.Image.starempty;

        }

        public static Control Set(Player player)
        {
            PlayerCard playerCard = new PlayerCard();
            SetPlayerCardProp(playerCard, player);

            playerCard.pbPlayerImage.Image = Resources.Image.player;

            return playerCard;
        }

        private void SetPlayerPicture(string filePath)
        {
            if (filePath != null)
            {
                pbPlayerImage.ImageLocation = filePath;
            }
            else
            {
                pbPlayerImage.Image = Resources.Image.player;
            }
        }

        public void SetFavourite(bool favourite)
        {
            if (favourite)
            {
                pbStar.Image = Resources.Image.star;
            }
            else
            {
                pbStar.Image = Resources.Image.starempty;
            }
        }

        public void UnSelected()
        {
            BackColor = Color.PaleGreen;
            pbPlayerImage.BackColor = Color.PaleGreen;
            Selected = false;
        }

        private void PlayerCard_Load(object sender, EventArgs e)
        {
            lbCaptain.Text = Resources.Resource.lbCaptain;
            btnAddPlayerImage.Text = Resources.Resource.btnAddPlayerImage;
        }

        private void PlayerCard_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.PaleGreen)
            {
                BackColor = Color.DarkRed;
                pbPlayerImage.BackColor = Color.DarkRed;
                Selected = true;
            }
            else
            {
                BackColor = Color.PaleGreen;
                pbPlayerImage.BackColor = Color.PaleGreen;
                Selected = false;
            }
        }

        private void PlayerCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Control control = sender as Control;
                control.DoDragDrop(this, DragDropEffects.Move);
            }
        }

        public string GetPlayerName() => lbName.Text;

        private void btnChangePlayerImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Odaberi format|*.jpg;*.jpeg;*.png;*.gif|Sve|*.*";
            fileDialog.ShowDialog();

            if (fileDialog.FileName != string.Empty)
            {
                string[] fileName = fileDialog.FileName.Split(DEL);

                string name = fileName[0];
                string fileNameExt = fileName[1];

                if (extensions.Contains(fileNameExt))
                {
                    SetPlayerPicture(fileDialog.FileName);
                    MainForm.SavePlayerPicture(lbName.Text, fileDialog.FileName);
                } 
                else
                {
                    MessageBox.Show("Error wrong type of file");
                }
            }
        }
    }
}

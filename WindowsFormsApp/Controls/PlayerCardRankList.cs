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
    public partial class PlayerCardRankList : UserControl
    {
        private const string GOAL = "Goal";
        private static string GOALS;
        private static string CARD;
        public PlayerCardRankList()
        {
            InitializeComponent();
        }

        internal static Control SetPlayerWithImage(Player player, string path, string typeCard)
        {
            PlayerCardRankList playerCardRankList = new PlayerCardRankList();

            SetPlayerCardRankListProp(playerCardRankList, player, typeCard);
            playerCardRankList.pbPlayerImage.ImageLocation = path;

            return playerCardRankList;
        }

        private static void SetPlayerCardRankListProp(PlayerCardRankList playerCardRankList, Player player, string typeCard)
        {
            GOALS = Resources.Resource.lbGoals;
            CARD = Resources.Resource.lbYellowCard;

            playerCardRankList.lbPlayerFullName.Text = player.Name;
            playerCardRankList.lbNumberOfGoals.Text = typeCard == GOAL ? player.Goals.ToString() : player.YellowCards.ToString();
            playerCardRankList.lbGoals.Text = typeCard == GOAL ? GOALS : CARD;
        }

        internal static Control Set(Player player, string typeCard)
        {
            PlayerCardRankList playerCardRankList = new PlayerCardRankList();

            SetPlayerCardRankListProp(playerCardRankList, player, typeCard);
            playerCardRankList.pbPlayerImage.Image = Resources.Image.player;

            return playerCardRankList;
        }
    }
}

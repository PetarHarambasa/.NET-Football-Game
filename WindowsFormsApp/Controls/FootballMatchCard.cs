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
    public partial class FootballMatchCard : UserControl
    {
        public FootballMatchCard()
        {
            InitializeComponent();
        }

        public static Control Set(FootballMatch match)
        {
            FootballMatchCard footballMatchCard = new FootballMatchCard();

            footballMatchCard.pbStadiumPicture.Image = Resources.Image.stadium;
            footballMatchCard.lbStadiumName.Text = match.Location;
            footballMatchCard.lbHomeTeam.Text = match.HomeTeamCountry;
            footballMatchCard.lbAwayTeam.Text = match.AwayTeamCountry;
            footballMatchCard.lbNumberVisitors.Text = match.AttendanceInt.ToString();

            return footballMatchCard;
        }

        private void FootballMatchCard_Load(object sender, EventArgs e)
        {
            lbVisitors.Text = Resources.Resource.lbVisitors;
        }
    }
}

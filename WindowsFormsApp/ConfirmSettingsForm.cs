using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorldCupLibrary.User;

namespace WindowsFormsApp
{
    public partial class ConfirmSettingsForm : Form
    {
        private const string HR = "hr-HR";
        private const string ENG = "en-US";

        private const string MALE = "Male";
        private const string FEMALE = "Female";

        private SettingsForm settingsForm;

        private string language;
        private string championship;
        public ConfirmSettingsForm(SettingsForm settingsForm)
        {
            InitializeComponent();
            this.settingsForm = settingsForm;
        }

        public void ConfirmData(RadioButton radioButtonChampionship, RadioButton radioButtonLanguage)
        {
            language = radioButtonLanguage.Text == Resources.Resource.rbHrv ? HR : ENG;
            championship = radioButtonChampionship.Text == Resources.Resource.rbMale ? MALE : FEMALE;
        }

        private void ConfirmSettingsForm_Load(object sender, EventArgs e)
        {
            lbAreYouSure.Text = Resources.Resource.lbAreYouSure;
            btnYes.Text = Resources.Resource.btnYes;
            btnNo.Text = Resources.Resource.btnNo;
            this.Text = Resources.Resource.ConfirmSettingsForm;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            User.settings.Language = language;
            User.SetLanguage(language);
            User.settings.Gender = championship;

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
            this.settingsForm.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConfirmSettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                User.settings.Language = language;
                User.SetLanguage(language);
                User.settings.Gender = championship;

                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
                this.settingsForm.Close();
            }
        }
    }
}

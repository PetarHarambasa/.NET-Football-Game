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
    public partial class StartForm : Form
    {
        private const string HR = "hr-HR";
        private const string ENG = "en-US";

        private const string MALE = "Male";
        private const string FEMALE = "Female";


        public StartForm()
        {
            User.LoadSettings();
            InitializeComponent();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbHrv.Checked)
                {
                    User.settings.Language = HR;
                    User.SetLanguage(HR);
                }
                if (rbEng.Checked)
                {
                    User.settings.Language = ENG;
                    User.SetLanguage(ENG);
                }
                if (rbMale.Checked)
                {
                    User.settings.Gender = MALE;
                }
                if (rbFemale.Checked)
                {
                    User.settings.Gender = FEMALE;
                }

                MainForm mainForm = new MainForm();
                Hide();
                mainForm.Show();
            }
            catch (Exception error)
            {
                if (MessageBox.Show(error.Message + "\nReturning to start point of this application.", "Error", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    StartForm startForm = new StartForm();
                    Close();
                    startForm.Show();
                }
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (User.settings.Language != null)
            {
                User.SetLanguage(User.settings.Language);
            }

            lbChooseSettings.Text = Resources.Resource.lbChooseSettings;
            gbChampionship.Text = Resources.Resource.gbChampionship;
            gbLanguage.Text = Resources.Resource.gbLanguage;
            rbEng.Text = Resources.Resource.rbEng;
            rbHrv.Text = Resources.Resource.rbHrv;
            rbMale.Text = Resources.Resource.rbMale;
            rbFemale.Text = Resources.Resource.rbFemale;
            btnSaveSettings.Text = Resources.Resource.btnSaveSettings;
            this.Text = Resources.Resource.StartForm;
        }
    }
}

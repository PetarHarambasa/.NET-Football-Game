using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class SettingsForm : Form
    {
        private RankListForm rankListForm;
        
        public SettingsForm()
        {
            InitializeComponent();
        }

        public SettingsForm(RankListForm rankListForm)
        {
            InitializeComponent();
            this.rankListForm = rankListForm;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            btnConfirm.Text = Resources.Resource.btnConfirm;
            btnCancel.Text = Resources.Resource.btnCancel;
            lbSettings.Text = Resources.Resource.lbSettings;
            gbChampionship.Text = Resources.Resource.gbChampionship;
            gbLanguage.Text = Resources.Resource.gbLanguage;
            rbEng.Text = Resources.Resource.rbEng;
            rbHrv.Text = Resources.Resource.rbHrv;
            rbFemale.Text = Resources.Resource.rbFemale;
            rbMale.Text = Resources.Resource.rbMale;
            this.Text = Resources.Resource.SettingsForm;
        }

        private void lbConfirm_Click(object sender, EventArgs e)
        {
            ConfirmSettingsForm confirmSettingsForm = new ConfirmSettingsForm(this);
            confirmSettingsForm.ConfirmData(gbChampionship.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked),
                gbLanguage.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked));
            confirmSettingsForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            this.rankListForm.Show();
        }

        private void SettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Hide();
                this.rankListForm.Show();
            }

            if (e.KeyCode == Keys.Enter)
            {
                ConfirmSettingsForm confirmSettingsForm = new ConfirmSettingsForm(this);
                confirmSettingsForm.ConfirmData(gbChampionship.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked),
                    gbLanguage.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked));
                confirmSettingsForm.Show();
            }
        }
    }
}

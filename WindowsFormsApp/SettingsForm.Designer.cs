namespace WindowsFormsApp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.rbHrv = new System.Windows.Forms.RadioButton();
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.gbChampionship = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lbSettings = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbLanguage.SuspendLayout();
            this.gbChampionship.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.rbHrv);
            this.gbLanguage.Controls.Add(this.rbEng);
            this.gbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbLanguage.Location = new System.Drawing.Point(47, 112);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(219, 227);
            this.gbLanguage.TabIndex = 14;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Choose language";
            // 
            // rbHrv
            // 
            this.rbHrv.AutoSize = true;
            this.rbHrv.Checked = true;
            this.rbHrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbHrv.Location = new System.Drawing.Point(54, 49);
            this.rbHrv.Name = "rbHrv";
            this.rbHrv.Size = new System.Drawing.Size(87, 24);
            this.rbHrv.TabIndex = 5;
            this.rbHrv.TabStop = true;
            this.rbHrv.Text = "Croatian";
            this.rbHrv.UseVisualStyleBackColor = true;
            // 
            // rbEng
            // 
            this.rbEng.AutoSize = true;
            this.rbEng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbEng.Location = new System.Drawing.Point(54, 162);
            this.rbEng.Name = "rbEng";
            this.rbEng.Size = new System.Drawing.Size(79, 24);
            this.rbEng.TabIndex = 6;
            this.rbEng.Text = "English";
            this.rbEng.UseVisualStyleBackColor = true;
            // 
            // gbChampionship
            // 
            this.gbChampionship.Controls.Add(this.rbFemale);
            this.gbChampionship.Controls.Add(this.rbMale);
            this.gbChampionship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbChampionship.Location = new System.Drawing.Point(510, 112);
            this.gbChampionship.Name = "gbChampionship";
            this.gbChampionship.Size = new System.Drawing.Size(243, 227);
            this.gbChampionship.TabIndex = 15;
            this.gbChampionship.TabStop = false;
            this.gbChampionship.Text = "Choose championship";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbFemale.Location = new System.Drawing.Point(62, 162);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(80, 24);
            this.rbFemale.TabIndex = 8;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbMale.Location = new System.Drawing.Point(62, 49);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(61, 24);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lbSettings
            // 
            this.lbSettings.AutoSize = true;
            this.lbSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbSettings.Location = new System.Drawing.Point(336, 49);
            this.lbSettings.Name = "lbSettings";
            this.lbSettings.Size = new System.Drawing.Size(128, 33);
            this.lbSettings.TabIndex = 18;
            this.lbSettings.Text = "Settings";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(220, 367);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(115, 39);
            this.btnConfirm.TabIndex = 19;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.lbConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(465, 367);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(115, 39);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lbSettings);
            this.Controls.Add(this.gbLanguage);
            this.Controls.Add(this.gbChampionship);
            this.KeyPreview = true;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsForm_KeyDown);
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.gbChampionship.ResumeLayout(false);
            this.gbChampionship.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLanguage;
        private System.Windows.Forms.RadioButton rbHrv;
        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.GroupBox gbChampionship;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lbSettings;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}
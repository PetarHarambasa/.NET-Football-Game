namespace WindowsFormsApp
{
    partial class StartForm
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
            this.lbChooseSettings = new System.Windows.Forms.Label();
            this.rbHrv = new System.Windows.Forms.RadioButton();
            this.rbEng = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.gbChampionship = new System.Windows.Forms.GroupBox();
            this.gbLanguage.SuspendLayout();
            this.gbChampionship.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbChooseSettings
            // 
            this.lbChooseSettings.AutoSize = true;
            this.lbChooseSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbChooseSettings.Location = new System.Drawing.Point(357, 9);
            this.lbChooseSettings.Name = "lbChooseSettings";
            this.lbChooseSettings.Size = new System.Drawing.Size(186, 29);
            this.lbChooseSettings.TabIndex = 4;
            this.lbChooseSettings.Text = "Choose settings";
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
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveSettings.Location = new System.Drawing.Point(380, 295);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(135, 40);
            this.btnSaveSettings.TabIndex = 9;
            this.btnSaveSettings.Text = "Save settings";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // gbLanguage
            // 
            this.gbLanguage.Controls.Add(this.rbHrv);
            this.gbLanguage.Controls.Add(this.rbEng);
            this.gbLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbLanguage.Location = new System.Drawing.Point(97, 55);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(219, 227);
            this.gbLanguage.TabIndex = 12;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Choose language";
            // 
            // gbChampionship
            // 
            this.gbChampionship.Controls.Add(this.rbFemale);
            this.gbChampionship.Controls.Add(this.rbMale);
            this.gbChampionship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbChampionship.Location = new System.Drawing.Point(560, 55);
            this.gbChampionship.Name = "gbChampionship";
            this.gbChampionship.Size = new System.Drawing.Size(243, 227);
            this.gbChampionship.TabIndex = 13;
            this.gbChampionship.TabStop = false;
            this.gbChampionship.Text = "Choose championship";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 363);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.lbChooseSettings);
            this.Controls.Add(this.gbLanguage);
            this.Controls.Add(this.gbChampionship);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.gbLanguage.ResumeLayout(false);
            this.gbLanguage.PerformLayout();
            this.gbChampionship.ResumeLayout(false);
            this.gbChampionship.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbChooseSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbEng;
        private System.Windows.Forms.RadioButton rbHrv;
        private System.Windows.Forms.GroupBox gbLanguage;
        private System.Windows.Forms.GroupBox gbChampionship;
    }
}


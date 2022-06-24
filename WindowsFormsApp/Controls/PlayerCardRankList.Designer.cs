namespace WindowsFormsApp.Controls
{
    partial class PlayerCardRankList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPlayerImage = new System.Windows.Forms.PictureBox();
            this.lbGoals = new System.Windows.Forms.Label();
            this.lbNumberOfGoals = new System.Windows.Forms.Label();
            this.lbPlayerFullName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerImage
            // 
            this.pbPlayerImage.Location = new System.Drawing.Point(16, 13);
            this.pbPlayerImage.Name = "pbPlayerImage";
            this.pbPlayerImage.Size = new System.Drawing.Size(134, 116);
            this.pbPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerImage.TabIndex = 0;
            this.pbPlayerImage.TabStop = false;
            // 
            // lbGoals
            // 
            this.lbGoals.AutoSize = true;
            this.lbGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbGoals.Location = new System.Drawing.Point(13, 164);
            this.lbGoals.Name = "lbGoals";
            this.lbGoals.Size = new System.Drawing.Size(46, 16);
            this.lbGoals.TabIndex = 1;
            this.lbGoals.Text = "Goals:";
            // 
            // lbNumberOfGoals
            // 
            this.lbNumberOfGoals.AutoSize = true;
            this.lbNumberOfGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNumberOfGoals.Location = new System.Drawing.Point(102, 162);
            this.lbNumberOfGoals.Name = "lbNumberOfGoals";
            this.lbNumberOfGoals.Size = new System.Drawing.Size(61, 18);
            this.lbNumberOfGoals.TabIndex = 2;
            this.lbNumberOfGoals.Text = "Number";
            // 
            // lbPlayerFullName
            // 
            this.lbPlayerFullName.AutoSize = true;
            this.lbPlayerFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPlayerFullName.Location = new System.Drawing.Point(13, 132);
            this.lbPlayerFullName.Name = "lbPlayerFullName";
            this.lbPlayerFullName.Size = new System.Drawing.Size(102, 16);
            this.lbPlayerFullName.TabIndex = 3;
            this.lbPlayerFullName.Text = "Player full name";
            // 
            // PlayerCardRankList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.lbPlayerFullName);
            this.Controls.Add(this.lbNumberOfGoals);
            this.Controls.Add(this.lbGoals);
            this.Controls.Add(this.pbPlayerImage);
            this.Name = "PlayerCardRankList";
            this.Size = new System.Drawing.Size(166, 197);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayerImage;
        private System.Windows.Forms.Label lbGoals;
        private System.Windows.Forms.Label lbNumberOfGoals;
        private System.Windows.Forms.Label lbPlayerFullName;
    }
}

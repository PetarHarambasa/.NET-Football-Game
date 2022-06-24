namespace WindowsFormsApp.Controls
{
    partial class FootballMatchCard
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
            this.lbStadiumName = new System.Windows.Forms.Label();
            this.lbHomeTeam = new System.Windows.Forms.Label();
            this.lbVs = new System.Windows.Forms.Label();
            this.lbAwayTeam = new System.Windows.Forms.Label();
            this.lbVisitors = new System.Windows.Forms.Label();
            this.lbNumberVisitors = new System.Windows.Forms.Label();
            this.pbStadiumPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStadiumPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStadiumName
            // 
            this.lbStadiumName.AutoSize = true;
            this.lbStadiumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbStadiumName.Location = new System.Drawing.Point(3, 120);
            this.lbStadiumName.Name = "lbStadiumName";
            this.lbStadiumName.Size = new System.Drawing.Size(93, 16);
            this.lbStadiumName.TabIndex = 1;
            this.lbStadiumName.Text = "Stadium name";
            // 
            // lbHomeTeam
            // 
            this.lbHomeTeam.AutoSize = true;
            this.lbHomeTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbHomeTeam.Location = new System.Drawing.Point(62, 145);
            this.lbHomeTeam.Name = "lbHomeTeam";
            this.lbHomeTeam.Size = new System.Drawing.Size(86, 16);
            this.lbHomeTeam.TabIndex = 2;
            this.lbHomeTeam.Text = "Home team";
            // 
            // lbVs
            // 
            this.lbVs.AutoSize = true;
            this.lbVs.Location = new System.Drawing.Point(95, 161);
            this.lbVs.Name = "lbVs";
            this.lbVs.Size = new System.Drawing.Size(19, 13);
            this.lbVs.TabIndex = 3;
            this.lbVs.Text = "Vs";
            // 
            // lbAwayTeam
            // 
            this.lbAwayTeam.AutoSize = true;
            this.lbAwayTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAwayTeam.Location = new System.Drawing.Point(66, 174);
            this.lbAwayTeam.Name = "lbAwayTeam";
            this.lbAwayTeam.Size = new System.Drawing.Size(82, 16);
            this.lbAwayTeam.TabIndex = 4;
            this.lbAwayTeam.Text = "Away team";
            // 
            // lbVisitors
            // 
            this.lbVisitors.AutoSize = true;
            this.lbVisitors.Location = new System.Drawing.Point(3, 205);
            this.lbVisitors.Name = "lbVisitors";
            this.lbVisitors.Size = new System.Drawing.Size(43, 13);
            this.lbVisitors.TabIndex = 5;
            this.lbVisitors.Text = "Visitors:";
            // 
            // lbNumberVisitors
            // 
            this.lbNumberVisitors.AutoSize = true;
            this.lbNumberVisitors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNumberVisitors.Location = new System.Drawing.Point(58, 203);
            this.lbNumberVisitors.Name = "lbNumberVisitors";
            this.lbNumberVisitors.Size = new System.Drawing.Size(55, 16);
            this.lbNumberVisitors.TabIndex = 6;
            this.lbNumberVisitors.Text = "Number";
            // 
            // pbStadiumPicture
            // 
            this.pbStadiumPicture.Location = new System.Drawing.Point(3, 3);
            this.pbStadiumPicture.Name = "pbStadiumPicture";
            this.pbStadiumPicture.Size = new System.Drawing.Size(188, 114);
            this.pbStadiumPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStadiumPicture.TabIndex = 0;
            this.pbStadiumPicture.TabStop = false;
            // 
            // FootballMatchCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.lbNumberVisitors);
            this.Controls.Add(this.lbVisitors);
            this.Controls.Add(this.lbAwayTeam);
            this.Controls.Add(this.lbVs);
            this.Controls.Add(this.lbHomeTeam);
            this.Controls.Add(this.lbStadiumName);
            this.Controls.Add(this.pbStadiumPicture);
            this.Name = "FootballMatchCard";
            this.Size = new System.Drawing.Size(194, 234);
            this.Load += new System.EventHandler(this.FootballMatchCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStadiumPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStadiumPicture;
        private System.Windows.Forms.Label lbStadiumName;
        private System.Windows.Forms.Label lbHomeTeam;
        private System.Windows.Forms.Label lbVs;
        private System.Windows.Forms.Label lbAwayTeam;
        private System.Windows.Forms.Label lbVisitors;
        private System.Windows.Forms.Label lbNumberVisitors;
    }
}

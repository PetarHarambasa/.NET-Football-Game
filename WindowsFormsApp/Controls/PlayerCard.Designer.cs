namespace WindowsFormsApp.Controls
{
    partial class PlayerCard
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbCaptain = new System.Windows.Forms.Label();
            this.lbNumber = new System.Windows.Forms.Label();
            this.lbIsCaptain = new System.Windows.Forms.Label();
            this.btnAddPlayerImage = new System.Windows.Forms.Button();
            this.pbStar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPlayerImage
            // 
            this.pbPlayerImage.BackColor = System.Drawing.Color.PaleGreen;
            this.pbPlayerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlayerImage.Location = new System.Drawing.Point(13, 3);
            this.pbPlayerImage.Name = "pbPlayerImage";
            this.pbPlayerImage.Size = new System.Drawing.Size(117, 117);
            this.pbPlayerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayerImage.TabIndex = 0;
            this.pbPlayerImage.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(10, 133);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(10, 158);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(44, 13);
            this.lbPosition.TabIndex = 2;
            this.lbPosition.Text = "Position";
            // 
            // lbCaptain
            // 
            this.lbCaptain.AutoSize = true;
            this.lbCaptain.Location = new System.Drawing.Point(10, 181);
            this.lbCaptain.Name = "lbCaptain";
            this.lbCaptain.Size = new System.Drawing.Size(46, 13);
            this.lbCaptain.TabIndex = 3;
            this.lbCaptain.Text = "Captain:";
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNumber.Location = new System.Drawing.Point(120, 128);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(65, 20);
            this.lbNumber.TabIndex = 4;
            this.lbNumber.Text = "Number";
            // 
            // lbIsCaptain
            // 
            this.lbIsCaptain.AutoSize = true;
            this.lbIsCaptain.Location = new System.Drawing.Point(62, 181);
            this.lbIsCaptain.Name = "lbIsCaptain";
            this.lbIsCaptain.Size = new System.Drawing.Size(43, 13);
            this.lbIsCaptain.TabIndex = 5;
            this.lbIsCaptain.Text = "Captain";
            // 
            // btnAddPlayerImage
            // 
            this.btnAddPlayerImage.Location = new System.Drawing.Point(13, 197);
            this.btnAddPlayerImage.Name = "btnAddPlayerImage";
            this.btnAddPlayerImage.Size = new System.Drawing.Size(165, 23);
            this.btnAddPlayerImage.TabIndex = 6;
            this.btnAddPlayerImage.Text = "Add player image";
            this.btnAddPlayerImage.UseVisualStyleBackColor = true;
            this.btnAddPlayerImage.Click += new System.EventHandler(this.btnChangePlayerImage_Click);
            // 
            // pbStar
            // 
            this.pbStar.Location = new System.Drawing.Point(136, 3);
            this.pbStar.Name = "pbStar";
            this.pbStar.Size = new System.Drawing.Size(49, 50);
            this.pbStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar.TabIndex = 7;
            this.pbStar.TabStop = false;
            // 
            // PlayerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.Controls.Add(this.pbStar);
            this.Controls.Add(this.btnAddPlayerImage);
            this.Controls.Add(this.pbPlayerImage);
            this.Controls.Add(this.lbIsCaptain);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.lbCaptain);
            this.Controls.Add(this.lbPosition);
            this.Controls.Add(this.lbName);
            this.Name = "PlayerCard";
            this.Size = new System.Drawing.Size(193, 226);
            this.Load += new System.EventHandler(this.PlayerCard_Load);
            this.Click += new System.EventHandler(this.PlayerCard_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerCard_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPlayerImage;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbCaptain;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbIsCaptain;
        private System.Windows.Forms.Button btnAddPlayerImage;
        private System.Windows.Forms.PictureBox pbStar;
    }
}

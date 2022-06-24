namespace WindowsFormsApp
{
    partial class RankListForm
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
            this.flpMostGoals = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbMostGoals = new System.Windows.Forms.Label();
            this.flpMostYellowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPopularMatches = new System.Windows.Forms.FlowLayoutPanel();
            this.lbYellowCards = new System.Windows.Forms.Label();
            this.lbPopularMatches = new System.Windows.Forms.Label();
            this.lbRankListMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpMostGoals
            // 
            this.flpMostGoals.AutoScroll = true;
            this.flpMostGoals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMostGoals.Location = new System.Drawing.Point(12, 105);
            this.flpMostGoals.Name = "flpMostGoals";
            this.flpMostGoals.Size = new System.Drawing.Size(354, 526);
            this.flpMostGoals.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1137, 584);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(117, 47);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(1137, 531);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(117, 47);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1137, 478);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(117, 47);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lbMostGoals
            // 
            this.lbMostGoals.AutoSize = true;
            this.lbMostGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMostGoals.Location = new System.Drawing.Point(144, 61);
            this.lbMostGoals.Name = "lbMostGoals";
            this.lbMostGoals.Size = new System.Drawing.Size(100, 24);
            this.lbMostGoals.TabIndex = 5;
            this.lbMostGoals.Text = "Most goals";
            // 
            // flpMostYellowCards
            // 
            this.flpMostYellowCards.AutoScroll = true;
            this.flpMostYellowCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpMostYellowCards.Location = new System.Drawing.Point(372, 105);
            this.flpMostYellowCards.Name = "flpMostYellowCards";
            this.flpMostYellowCards.Size = new System.Drawing.Size(347, 526);
            this.flpMostYellowCards.TabIndex = 1;
            // 
            // flpPopularMatches
            // 
            this.flpPopularMatches.AutoScroll = true;
            this.flpPopularMatches.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpPopularMatches.Location = new System.Drawing.Point(725, 105);
            this.flpPopularMatches.Name = "flpPopularMatches";
            this.flpPopularMatches.Size = new System.Drawing.Size(406, 526);
            this.flpPopularMatches.TabIndex = 1;
            // 
            // lbYellowCards
            // 
            this.lbYellowCards.AutoSize = true;
            this.lbYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbYellowCards.Location = new System.Drawing.Point(462, 61);
            this.lbYellowCards.Name = "lbYellowCards";
            this.lbYellowCards.Size = new System.Drawing.Size(159, 24);
            this.lbYellowCards.TabIndex = 6;
            this.lbYellowCards.Text = "Most yellow cards";
            // 
            // lbPopularMatches
            // 
            this.lbPopularMatches.AutoSize = true;
            this.lbPopularMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPopularMatches.Location = new System.Drawing.Point(858, 61);
            this.lbPopularMatches.Name = "lbPopularMatches";
            this.lbPopularMatches.Size = new System.Drawing.Size(151, 24);
            this.lbPopularMatches.TabIndex = 7;
            this.lbPopularMatches.Text = "Popular matches";
            // 
            // lbRankListMenu
            // 
            this.lbRankListMenu.AutoSize = true;
            this.lbRankListMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRankListMenu.Location = new System.Drawing.Point(545, 9);
            this.lbRankListMenu.Name = "lbRankListMenu";
            this.lbRankListMenu.Size = new System.Drawing.Size(177, 25);
            this.lbRankListMenu.TabIndex = 8;
            this.lbRankListMenu.Text = "Rang List Menu";
            // 
            // RankListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 648);
            this.Controls.Add(this.lbRankListMenu);
            this.Controls.Add(this.lbPopularMatches);
            this.Controls.Add(this.lbYellowCards);
            this.Controls.Add(this.flpPopularMatches);
            this.Controls.Add(this.flpMostYellowCards);
            this.Controls.Add(this.lbMostGoals);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.flpMostGoals);
            this.Name = "RankListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RankList";
            this.Load += new System.EventHandler(this.RangListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMostGoals;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lbMostGoals;
        private System.Windows.Forms.FlowLayoutPanel flpMostYellowCards;
        private System.Windows.Forms.FlowLayoutPanel flpPopularMatches;
        private System.Windows.Forms.Label lbYellowCards;
        private System.Windows.Forms.Label lbPopularMatches;
        private System.Windows.Forms.Label lbRankListMenu;
    }
}
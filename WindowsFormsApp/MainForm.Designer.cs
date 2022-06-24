namespace WindowsFormsApp
{
    partial class MainForm
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
            this.flpAllPlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFavouritePlayers = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFavouritePlayer = new System.Windows.Forms.Button();
            this.btnRemovePlayer = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.cbChoosedCountry = new System.Windows.Forms.ComboBox();
            this.lbChooseCountry = new System.Windows.Forms.Label();
            this.lbAllPlayers = new System.Windows.Forms.Label();
            this.lbFavouritePlayers = new System.Windows.Forms.Label();
            this.lbPlayerMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpAllPlayers
            // 
            this.flpAllPlayers.AllowDrop = true;
            this.flpAllPlayers.AutoScroll = true;
            this.flpAllPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpAllPlayers.Location = new System.Drawing.Point(12, 144);
            this.flpAllPlayers.Name = "flpAllPlayers";
            this.flpAllPlayers.Size = new System.Drawing.Size(413, 467);
            this.flpAllPlayers.TabIndex = 0;
            this.flpAllPlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpAllPlayers_DragDrop);
            this.flpAllPlayers.DragOver += new System.Windows.Forms.DragEventHandler(this.flpAllPlayers_DragOver);
            // 
            // flpFavouritePlayers
            // 
            this.flpFavouritePlayers.AllowDrop = true;
            this.flpFavouritePlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpFavouritePlayers.Location = new System.Drawing.Point(710, 144);
            this.flpFavouritePlayers.Name = "flpFavouritePlayers";
            this.flpFavouritePlayers.Size = new System.Drawing.Size(413, 467);
            this.flpFavouritePlayers.TabIndex = 1;
            this.flpFavouritePlayers.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavouritePlayers_DragDrop);
            this.flpFavouritePlayers.DragOver += new System.Windows.Forms.DragEventHandler(this.flpFavouritePlayers_DragOver);
            // 
            // btnAddFavouritePlayer
            // 
            this.btnAddFavouritePlayer.Location = new System.Drawing.Point(454, 144);
            this.btnAddFavouritePlayer.Name = "btnAddFavouritePlayer";
            this.btnAddFavouritePlayer.Size = new System.Drawing.Size(222, 69);
            this.btnAddFavouritePlayer.TabIndex = 2;
            this.btnAddFavouritePlayer.Text = "Add favourite player";
            this.btnAddFavouritePlayer.UseVisualStyleBackColor = true;
            this.btnAddFavouritePlayer.Click += new System.EventHandler(this.btnAddFavouritePlayer_Click);
            // 
            // btnRemovePlayer
            // 
            this.btnRemovePlayer.Location = new System.Drawing.Point(454, 542);
            this.btnRemovePlayer.Name = "btnRemovePlayer";
            this.btnRemovePlayer.Size = new System.Drawing.Size(222, 69);
            this.btnRemovePlayer.TabIndex = 3;
            this.btnRemovePlayer.Text = "Remove favourite player";
            this.btnRemovePlayer.UseVisualStyleBackColor = true;
            this.btnRemovePlayer.Click += new System.EventHandler(this.btnRemovePlayer_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(454, 343);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(222, 69);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // cbChoosedCountry
            // 
            this.cbChoosedCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChoosedCountry.FormattingEnabled = true;
            this.cbChoosedCountry.Location = new System.Drawing.Point(443, 62);
            this.cbChoosedCountry.Name = "cbChoosedCountry";
            this.cbChoosedCountry.Size = new System.Drawing.Size(349, 21);
            this.cbChoosedCountry.TabIndex = 5;
            this.cbChoosedCountry.SelectedIndexChanged += new System.EventHandler(this.cbChoosedCountry_SelectedIndexChanged);
            // 
            // lbChooseCountry
            // 
            this.lbChooseCountry.AutoSize = true;
            this.lbChooseCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbChooseCountry.Location = new System.Drawing.Point(252, 59);
            this.lbChooseCountry.Name = "lbChooseCountry";
            this.lbChooseCountry.Size = new System.Drawing.Size(185, 24);
            this.lbChooseCountry.TabIndex = 6;
            this.lbChooseCountry.Text = "Choose your country";
            // 
            // lbAllPlayers
            // 
            this.lbAllPlayers.AutoSize = true;
            this.lbAllPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAllPlayers.Location = new System.Drawing.Point(158, 107);
            this.lbAllPlayers.Name = "lbAllPlayers";
            this.lbAllPlayers.Size = new System.Drawing.Size(96, 24);
            this.lbAllPlayers.TabIndex = 7;
            this.lbAllPlayers.Text = "All players";
            // 
            // lbFavouritePlayers
            // 
            this.lbFavouritePlayers.AutoSize = true;
            this.lbFavouritePlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbFavouritePlayers.Location = new System.Drawing.Point(860, 107);
            this.lbFavouritePlayers.Name = "lbFavouritePlayers";
            this.lbFavouritePlayers.Size = new System.Drawing.Size(153, 24);
            this.lbFavouritePlayers.TabIndex = 8;
            this.lbFavouritePlayers.Text = "Favourite players";
            // 
            // lbPlayerMenu
            // 
            this.lbPlayerMenu.AutoSize = true;
            this.lbPlayerMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbPlayerMenu.Location = new System.Drawing.Point(488, 9);
            this.lbPlayerMenu.Name = "lbPlayerMenu";
            this.lbPlayerMenu.Size = new System.Drawing.Size(158, 29);
            this.lbPlayerMenu.TabIndex = 9;
            this.lbPlayerMenu.Text = "Player Menu";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 623);
            this.Controls.Add(this.lbPlayerMenu);
            this.Controls.Add(this.lbFavouritePlayers);
            this.Controls.Add(this.lbAllPlayers);
            this.Controls.Add(this.lbChooseCountry);
            this.Controls.Add(this.cbChoosedCountry);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnRemovePlayer);
            this.Controls.Add(this.btnAddFavouritePlayer);
            this.Controls.Add(this.flpFavouritePlayers);
            this.Controls.Add(this.flpAllPlayers);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldCup App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpAllPlayers;
        private System.Windows.Forms.FlowLayoutPanel flpFavouritePlayers;
        private System.Windows.Forms.Button btnAddFavouritePlayer;
        private System.Windows.Forms.Button btnRemovePlayer;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ComboBox cbChoosedCountry;
        private System.Windows.Forms.Label lbChooseCountry;
        private System.Windows.Forms.Label lbAllPlayers;
        private System.Windows.Forms.Label lbFavouritePlayers;
        private System.Windows.Forms.Label lbPlayerMenu;
    }
}
namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.tournamentPlayersLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPlayers = new System.Windows.Forms.Button();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(11, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(231, 37);
            this.headerLabel.TabIndex = 2;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(18, 101);
            this.tournamentNameValue.Multiline = true;
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(290, 30);
            this.tournamentNameValue.TabIndex = 15;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentNameLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tournamentNameLabel.Location = new System.Drawing.Point(12, 61);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(236, 37);
            this.tournamentNameLabel.TabIndex = 14;
            this.tournamentNameLabel.Text = "Tournament Name";
            this.tournamentNameLabel.Click += new System.EventHandler(this.teamOneScoreLabel_Click);
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.entryFeeValue.Location = new System.Drawing.Point(143, 166);
            this.entryFeeValue.Multiline = true;
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(67, 30);
            this.entryFeeValue.TabIndex = 17;
            this.entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(12, 159);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(125, 37);
            this.entryFeeLabel.TabIndex = 16;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(18, 272);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(291, 25);
            this.selectTeamDropDown.TabIndex = 19;
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamLabel.Location = new System.Drawing.Point(12, 222);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(156, 37);
            this.selectTeamLabel.TabIndex = 18;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(209, 231);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 28);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "create new";
            // 
            // addTeamButton
            // 
            this.addTeamButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(112, 336);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(152, 44);
            this.addTeamButton.TabIndex = 21;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(112, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 44);
            this.button1.TabIndex = 22;
            this.button1.Text = "Create Prize";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 28;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(390, 91);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(309, 144);
            this.tournamentPlayersListBox.TabIndex = 23;
            // 
            // tournamentPlayersLabel
            // 
            this.tournamentPlayersLabel.AutoSize = true;
            this.tournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.tournamentPlayersLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentPlayersLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tournamentPlayersLabel.Location = new System.Drawing.Point(384, 52);
            this.tournamentPlayersLabel.Name = "tournamentPlayersLabel";
            this.tournamentPlayersLabel.Size = new System.Drawing.Size(191, 36);
            this.tournamentPlayersLabel.TabIndex = 24;
            this.tournamentPlayersLabel.Text = "Teams / Players";
            // 
            // deleteSelectedPlayers
            // 
            this.deleteSelectedPlayers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPlayers.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPlayers.Location = new System.Drawing.Point(731, 117);
            this.deleteSelectedPlayers.Name = "deleteSelectedPlayers";
            this.deleteSelectedPlayers.Size = new System.Drawing.Size(105, 79);
            this.deleteSelectedPlayers.TabIndex = 25;
            this.deleteSelectedPlayers.Text = "Delete Selected";
            this.deleteSelectedPlayers.UseVisualStyleBackColor = false;
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(731, 336);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(105, 76);
            this.deleteSelectedPrizeButton.TabIndex = 28;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = false;
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizesLabel.Location = new System.Drawing.Point(384, 261);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(71, 36);
            this.prizesLabel.TabIndex = 27;
            this.prizesLabel.Text = "Prize";
            // 
            // prizesListBox
            // 
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 28;
            this.prizesListBox.Location = new System.Drawing.Point(390, 300);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(309, 144);
            this.prizesListBox.TabIndex = 26;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(313, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 70);
            this.button2.TabIndex = 29;
            this.button2.Text = "Create Tournament";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.deleteSelectedPlayers);
            this.Controls.Add(this.tournamentPlayersLabel);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label tournamentPlayersLabel;
        private System.Windows.Forms.Button deleteSelectedPlayers;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.Button button2;
    }
}
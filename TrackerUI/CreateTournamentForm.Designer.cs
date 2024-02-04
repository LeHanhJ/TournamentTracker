namespace TrackerUI
{
    partial class CreateTournament
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
            ListBox TournamentPlayersListBox;
            ListBox PrizesListBox;
            headerLabel = new Label();
            EntryFeeValue = new TextBox();
            EntryFeeLabel = new Label();
            teamOneScoreValue = new TextBox();
            TournamentName = new Label();
            SelectTeamDropdown = new ComboBox();
            SelectTeamLabel = new Label();
            CreateNewTeamLink = new LinkLabel();
            AddTeamButton = new Button();
            CreatePrizeButton = new Button();
            Tournament = new Label();
            DeleteSelectedPlayerButton = new Button();
            DeleteSelectedPrizeButton = new Button();
            PrizesLabel = new Label();
            CreateTournamentButton = new Button();
            TournamentPlayersListBox = new ListBox();
            PrizesListBox = new ListBox();
            SuspendLayout();
            // 
            // TournamentPlayersListBox
            // 
            TournamentPlayersListBox.BorderStyle = BorderStyle.FixedSingle;
            TournamentPlayersListBox.FormattingEnabled = true;
            TournamentPlayersListBox.ItemHeight = 30;
            TournamentPlayersListBox.Location = new Point(530, 99);
            TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            TournamentPlayersListBox.Size = new Size(383, 182);
            TournamentPlayersListBox.TabIndex = 21;
            // 
            // PrizesListBox
            // 
            PrizesListBox.BorderStyle = BorderStyle.FixedSingle;
            PrizesListBox.FormattingEnabled = true;
            PrizesListBox.ItemHeight = 30;
            PrizesListBox.Location = new Point(530, 343);
            PrizesListBox.Name = "PrizesListBox";
            PrizesListBox.Size = new Size(383, 182);
            PrizesListBox.TabIndex = 24;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            headerLabel.Location = new Point(40, 59);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(333, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "Create tournament: ";
            headerLabel.Click += headerLabel_Click;
            // 
            // EntryFeeValue
            // 
            EntryFeeValue.Location = new Point(171, 247);
            EntryFeeValue.Name = "EntryFeeValue";
            EntryFeeValue.Size = new Size(128, 35);
            EntryFeeValue.TabIndex = 15;
            EntryFeeValue.Text = "0";
            // 
            // EntryFeeLabel
            // 
            EntryFeeLabel.AutoSize = true;
            EntryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EntryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            EntryFeeLabel.Location = new Point(40, 244);
            EntryFeeLabel.Name = "EntryFeeLabel";
            EntryFeeLabel.Size = new Size(125, 37);
            EntryFeeLabel.TabIndex = 14;
            EntryFeeLabel.Text = "Entry Fee";
            EntryFeeLabel.Click += EntryFeeLabel_Click;
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(52, 175);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(373, 35);
            teamOneScoreValue.TabIndex = 13;
            // 
            // TournamentName
            // 
            TournamentName.AutoSize = true;
            TournamentName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentName.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentName.Location = new Point(40, 135);
            TournamentName.Name = "TournamentName";
            TournamentName.Size = new Size(236, 37);
            TournamentName.TabIndex = 12;
            TournamentName.Text = "Tournament Name";
            TournamentName.Click += TournamentName_Click;
            // 
            // SelectTeamDropdown
            // 
            SelectTeamDropdown.FormattingEnabled = true;
            SelectTeamDropdown.Location = new Point(52, 343);
            SelectTeamDropdown.Name = "SelectTeamDropdown";
            SelectTeamDropdown.Size = new Size(373, 38);
            SelectTeamDropdown.TabIndex = 17;
            // 
            // SelectTeamLabel
            // 
            SelectTeamLabel.AutoSize = true;
            SelectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            SelectTeamLabel.Location = new Point(40, 303);
            SelectTeamLabel.Name = "SelectTeamLabel";
            SelectTeamLabel.Size = new Size(156, 37);
            SelectTeamLabel.TabIndex = 16;
            SelectTeamLabel.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            CreateNewTeamLink.AutoSize = true;
            CreateNewTeamLink.Location = new Point(301, 309);
            CreateNewTeamLink.Name = "CreateNewTeamLink";
            CreateNewTeamLink.Size = new Size(124, 30);
            CreateNewTeamLink.TabIndex = 18;
            CreateNewTeamLink.TabStop = true;
            CreateNewTeamLink.Text = "Create New";
            CreateNewTeamLink.LinkClicked += CreateNewTeamLink_LinkClicked;
            // 
            // AddTeamButton
            // 
            AddTeamButton.FlatAppearance.BorderColor = Color.Silver;
            AddTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AddTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddTeamButton.FlatStyle = FlatStyle.Flat;
            AddTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            AddTeamButton.Location = new Point(144, 412);
            AddTeamButton.Name = "AddTeamButton";
            AddTeamButton.Size = new Size(185, 54);
            AddTeamButton.TabIndex = 19;
            AddTeamButton.Text = "Add Team";
            AddTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeButton
            // 
            CreatePrizeButton.FlatAppearance.BorderColor = Color.Silver;
            CreatePrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreatePrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreatePrizeButton.FlatStyle = FlatStyle.Flat;
            CreatePrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreatePrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            CreatePrizeButton.Location = new Point(144, 472);
            CreatePrizeButton.Name = "CreatePrizeButton";
            CreatePrizeButton.Size = new Size(185, 54);
            CreatePrizeButton.TabIndex = 20;
            CreatePrizeButton.Text = "Create Prize";
            CreatePrizeButton.UseVisualStyleBackColor = true;
            CreatePrizeButton.Click += button1_Click;
            // 
            // Tournament
            // 
            Tournament.AutoSize = true;
            Tournament.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tournament.ForeColor = Color.FromArgb(51, 153, 255);
            Tournament.Location = new Point(519, 59);
            Tournament.Name = "Tournament";
            Tournament.Size = new Size(187, 37);
            Tournament.TabIndex = 22;
            Tournament.Text = "Team / Players";
            Tournament.Click += Tournament_Click;
            // 
            // DeleteSelectedPlayerButton
            // 
            DeleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPlayerButton.ForeColor = Color.FromArgb(51, 153, 255);
            DeleteSelectedPlayerButton.Location = new Point(939, 128);
            DeleteSelectedPlayerButton.Name = "DeleteSelectedPlayerButton";
            DeleteSelectedPlayerButton.Size = new Size(112, 113);
            DeleteSelectedPlayerButton.TabIndex = 23;
            DeleteSelectedPlayerButton.Text = "Delete Selected";
            DeleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // DeleteSelectedPrizeButton
            // 
            DeleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            DeleteSelectedPrizeButton.Location = new Point(939, 383);
            DeleteSelectedPrizeButton.Name = "DeleteSelectedPrizeButton";
            DeleteSelectedPrizeButton.Size = new Size(112, 113);
            DeleteSelectedPrizeButton.TabIndex = 26;
            DeleteSelectedPrizeButton.Text = "Delete Selected";
            DeleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // PrizesLabel
            // 
            PrizesLabel.AutoSize = true;
            PrizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PrizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PrizesLabel.Location = new Point(519, 302);
            PrizesLabel.Name = "PrizesLabel";
            PrizesLabel.Size = new Size(187, 37);
            PrizesLabel.TabIndex = 25;
            PrizesLabel.Text = "Team / Players";
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            CreateTournamentButton.Location = new Point(268, 596);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(438, 83);
            CreateTournamentButton.TabIndex = 27;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournament
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 733);
            Controls.Add(CreateTournamentButton);
            Controls.Add(DeleteSelectedPrizeButton);
            Controls.Add(PrizesLabel);
            Controls.Add(PrizesListBox);
            Controls.Add(DeleteSelectedPlayerButton);
            Controls.Add(Tournament);
            Controls.Add(TournamentPlayersListBox);
            Controls.Add(CreatePrizeButton);
            Controls.Add(AddTeamButton);
            Controls.Add(CreateNewTeamLink);
            Controls.Add(SelectTeamDropdown);
            Controls.Add(SelectTeamLabel);
            Controls.Add(EntryFeeValue);
            Controls.Add(EntryFeeLabel);
            Controls.Add(teamOneScoreValue);
            Controls.Add(TournamentName);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournament";
            Text = "Create Tournament";
            Load += CreateTournamentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox EntryFeeValue;
        private Label EntryFeeLabel;
        private TextBox teamOneScoreValue;
        private Label TournamentName;
        private ComboBox SelectTeamDropdown;
        private Label SelectTeamLabel;
        private LinkLabel CreateNewTeamLink;
        private Button AddTeamButton;
        private Button CreatePrizeButton;
        private Label Tournament;
        private Button DeleteSelectedPlayerButton;
        private Button DeleteSelectedPrizeButton;
        private Label PrizesLabel;
        private Button CreateTournamentButton;
    }
}
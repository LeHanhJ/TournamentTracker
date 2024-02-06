namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            TournamentDashboardLabel = new Label();
            LoadExistingTournamentDropdown = new ComboBox();
            LoadExistingTournamentLabel = new Label();
            LoadTournamentButton = new Button();
            CreateTournamentButton = new Button();
            SuspendLayout();
            // 
            // TournamentDashboardLabel
            // 
            TournamentDashboardLabel.AutoSize = true;
            TournamentDashboardLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TournamentDashboardLabel.ForeColor = Color.FromArgb(51, 153, 255);
            TournamentDashboardLabel.Location = new Point(103, 60);
            TournamentDashboardLabel.Name = "TournamentDashboardLabel";
            TournamentDashboardLabel.Size = new Size(385, 50);
            TournamentDashboardLabel.TabIndex = 2;
            TournamentDashboardLabel.Text = "Tournament Dashboard";
            TournamentDashboardLabel.Click += headerLabel_Click;
            // 
            // LoadExistingTournamentDropdown
            // 
            LoadExistingTournamentDropdown.FormattingEnabled = true;
            LoadExistingTournamentDropdown.Location = new Point(89, 218);
            LoadExistingTournamentDropdown.Name = "LoadExistingTournamentDropdown";
            LoadExistingTournamentDropdown.Size = new Size(412, 38);
            LoadExistingTournamentDropdown.TabIndex = 23;
            LoadExistingTournamentDropdown.SelectedIndexChanged += SelectTeamMemberDropdown_SelectedIndexChanged;
            // 
            // LoadExistingTournamentLabel
            // 
            LoadExistingTournamentLabel.AutoSize = true;
            LoadExistingTournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoadExistingTournamentLabel.ForeColor = Color.FromArgb(51, 153, 255);
            LoadExistingTournamentLabel.Location = new Point(134, 149);
            LoadExistingTournamentLabel.Name = "LoadExistingTournamentLabel";
            LoadExistingTournamentLabel.Size = new Size(322, 37);
            LoadExistingTournamentLabel.TabIndex = 22;
            LoadExistingTournamentLabel.Text = "Load Existing Tournament";
            // 
            // LoadTournamentButton
            // 
            LoadTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            LoadTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            LoadTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            LoadTournamentButton.FlatStyle = FlatStyle.Flat;
            LoadTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoadTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            LoadTournamentButton.Location = new Point(203, 277);
            LoadTournamentButton.Name = "LoadTournamentButton";
            LoadTournamentButton.Size = new Size(185, 46);
            LoadTournamentButton.TabIndex = 24;
            LoadTournamentButton.Text = "Load Tournament";
            LoadTournamentButton.UseVisualStyleBackColor = true;
            LoadTournamentButton.Click += LoadTournamentButton_Click;
            // 
            // CreateTournamentButton
            // 
            CreateTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTournamentButton.FlatStyle = FlatStyle.Flat;
            CreateTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            CreateTournamentButton.Location = new Point(76, 372);
            CreateTournamentButton.Name = "CreateTournamentButton";
            CreateTournamentButton.Size = new Size(438, 83);
            CreateTournamentButton.TabIndex = 28;
            CreateTournamentButton.Text = "Create Tournament";
            CreateTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(612, 550);
            Controls.Add(CreateTournamentButton);
            Controls.Add(LoadTournamentButton);
            Controls.Add(LoadExistingTournamentDropdown);
            Controls.Add(LoadExistingTournamentLabel);
            Controls.Add(TournamentDashboardLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentDashboardLabel;
        private ComboBox LoadExistingTournamentDropdown;
        private Label LoadExistingTournamentLabel;
        private Button LoadTournamentButton;
        private Button CreateTournamentButton;
    }
}
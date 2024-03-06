
namespace TrackerUI
{
    partial class CreateTeamForm
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
            TeamNameValue = new TextBox();
            TeamName = new Label();
            CreateTeamLabel = new Label();
            AddMemberButton = new Button();
            SelectTeamMemberDropdown = new ComboBox();
            SelectMemberTeamLabel = new Label();
            groupBox1 = new GroupBox();
            CreateMemberButton = new Button();
            CellNumberValue = new TextBox();
            PhoneNumberLabel = new Label();
            EmailValue = new TextBox();
            EmailLabel = new Label();
            LastNameValue = new TextBox();
            LastNameLabel = new Label();
            FirstNameValue = new TextBox();
            FirstNameLabel = new Label();
            DeleteSelectedMemberButton = new Button();
            CreateTeamButton = new Button();
            TeamMembersListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TeamMembersListBox
            // 
            TeamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
            TeamMembersListBox.FormattingEnabled = true;
            TeamMembersListBox.ItemHeight = 30;
            TeamMembersListBox.Location = new Point(541, 133);
            TeamMembersListBox.Name = "TeamMembersListBox";
            TeamMembersListBox.Size = new Size(409, 632);
            TeamMembersListBox.TabIndex = 25;
            // 
            // TeamNameValue
            // 
            TeamNameValue.Location = new Point(63, 133);
            TeamNameValue.Name = "TeamNameValue";
            TeamNameValue.Size = new Size(412, 35);
            TeamNameValue.TabIndex = 16;
            // 
            // TeamName
            // 
            TeamName.AutoSize = true;
            TeamName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TeamName.ForeColor = Color.FromArgb(51, 153, 255);
            TeamName.Location = new Point(54, 93);
            TeamName.Name = "TeamName";
            TeamName.Size = new Size(157, 37);
            TeamName.TabIndex = 15;
            TeamName.Text = "Team Name";
            // 
            // CreateTeamLabel
            // 
            CreateTeamLabel.AutoSize = true;
            CreateTeamLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreateTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            CreateTeamLabel.Location = new Point(54, 30);
            CreateTeamLabel.Name = "CreateTeamLabel";
            CreateTeamLabel.Size = new Size(219, 50);
            CreateTeamLabel.TabIndex = 14;
            CreateTeamLabel.Text = "Create team:";
            // 
            // AddMemberButton
            // 
            AddMemberButton.FlatAppearance.BorderColor = Color.Silver;
            AddMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            AddMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            AddMemberButton.FlatStyle = FlatStyle.Flat;
            AddMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            AddMemberButton.Location = new Point(158, 297);
            AddMemberButton.Name = "AddMemberButton";
            AddMemberButton.Size = new Size(185, 54);
            AddMemberButton.TabIndex = 22;
            AddMemberButton.Text = "Add Member";
            AddMemberButton.UseVisualStyleBackColor = true;
            // 
            // SelectTeamMemberDropdown
            // 
            SelectTeamMemberDropdown.FormattingEnabled = true;
            SelectTeamMemberDropdown.Location = new Point(63, 230);
            SelectTeamMemberDropdown.Name = "SelectTeamMemberDropdown";
            SelectTeamMemberDropdown.Size = new Size(412, 38);
            SelectTeamMemberDropdown.TabIndex = 21;
            // 
            // SelectMemberTeamLabel
            // 
            SelectMemberTeamLabel.AutoSize = true;
            SelectMemberTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SelectMemberTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            SelectMemberTeamLabel.Location = new Point(55, 190);
            SelectMemberTeamLabel.Name = "SelectMemberTeamLabel";
            SelectMemberTeamLabel.Size = new Size(263, 37);
            SelectMemberTeamLabel.TabIndex = 20;
            SelectMemberTeamLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CreateMemberButton);
            groupBox1.Controls.Add(CellNumberValue);
            groupBox1.Controls.Add(PhoneNumberLabel);
            groupBox1.Controls.Add(EmailValue);
            groupBox1.Controls.Add(EmailLabel);
            groupBox1.Controls.Add(LastNameValue);
            groupBox1.Controls.Add(LastNameLabel);
            groupBox1.Controls.Add(FirstNameValue);
            groupBox1.Controls.Add(FirstNameLabel);
            groupBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(51, 153, 255);
            groupBox1.Location = new Point(63, 382);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 383);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // CreateMemberButton
            // 
            CreateMemberButton.FlatAppearance.BorderColor = Color.Silver;
            CreateMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateMemberButton.FlatStyle = FlatStyle.Flat;
            CreateMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            CreateMemberButton.Location = new Point(95, 298);
            CreateMemberButton.Name = "CreateMemberButton";
            CreateMemberButton.Size = new Size(185, 54);
            CreateMemberButton.TabIndex = 32;
            CreateMemberButton.Text = "Create Member";
            CreateMemberButton.UseVisualStyleBackColor = true;
            CreateMemberButton.Click += CreateMemberButton_Click;
            // 
            // CellNumberValue
            // 
            CellNumberValue.Location = new Point(195, 239);
            CellNumberValue.Name = "CellNumberValue";
            CellNumberValue.Size = new Size(192, 43);
            CellNumberValue.TabIndex = 31;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PhoneNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            PhoneNumberLabel.Location = new Point(18, 236);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(166, 37);
            PhoneNumberLabel.TabIndex = 30;
            PhoneNumberLabel.Text = "Cell Number";
            // 
            // EmailValue
            // 
            EmailValue.Location = new Point(195, 179);
            EmailValue.Name = "EmailValue";
            EmailValue.Size = new Size(192, 43);
            EmailValue.TabIndex = 29;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmailLabel.ForeColor = Color.FromArgb(51, 153, 255);
            EmailLabel.Location = new Point(18, 176);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(82, 37);
            EmailLabel.TabIndex = 28;
            EmailLabel.Text = "Email";
            // 
            // LastNameValue
            // 
            LastNameValue.Location = new Point(195, 119);
            LastNameValue.Name = "LastNameValue";
            LastNameValue.Size = new Size(192, 43);
            LastNameValue.TabIndex = 27;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LastNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            LastNameLabel.Location = new Point(18, 116);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(142, 37);
            LastNameLabel.TabIndex = 26;
            LastNameLabel.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            FirstNameValue.Location = new Point(195, 60);
            FirstNameValue.Name = "FirstNameValue";
            FirstNameValue.Size = new Size(192, 43);
            FirstNameValue.TabIndex = 25;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FirstNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            FirstNameLabel.Location = new Point(18, 57);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(144, 37);
            FirstNameLabel.TabIndex = 24;
            FirstNameLabel.Text = "First Name";
            // 
            // DeleteSelectedMemberButton
            // 
            DeleteSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            DeleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            DeleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            DeleteSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            DeleteSelectedMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteSelectedMemberButton.ForeColor = Color.FromArgb(51, 153, 255);
            DeleteSelectedMemberButton.Location = new Point(994, 297);
            DeleteSelectedMemberButton.Name = "DeleteSelectedMemberButton";
            DeleteSelectedMemberButton.Size = new Size(112, 113);
            DeleteSelectedMemberButton.TabIndex = 26;
            DeleteSelectedMemberButton.Text = "Delete Selected";
            DeleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamButton
            // 
            CreateTeamButton.FlatAppearance.BorderColor = Color.Silver;
            CreateTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            CreateTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            CreateTeamButton.FlatStyle = FlatStyle.Flat;
            CreateTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreateTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            CreateTeamButton.Location = new Point(364, 789);
            CreateTeamButton.Name = "CreateTeamButton";
            CreateTeamButton.Size = new Size(304, 83);
            CreateTeamButton.TabIndex = 28;
            CreateTeamButton.Text = "Create  Team";
            CreateTeamButton.UseVisualStyleBackColor = true;
            // 
            // AddNewPerson
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1138, 929);
            Controls.Add(CreateTeamButton);
            Controls.Add(DeleteSelectedMemberButton);
            Controls.Add(TeamMembersListBox);
            Controls.Add(groupBox1);
            Controls.Add(AddMemberButton);
            Controls.Add(SelectTeamMemberDropdown);
            Controls.Add(SelectMemberTeamLabel);
            Controls.Add(TeamNameValue);
            Controls.Add(TeamName);
            Controls.Add(CreateTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AddNewPerson";
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        
         
        private TextBox TeamNameValue;
        private Label TeamName;
        private Label CreateTeamLabel;
        private Button AddMemberButton;
        private ComboBox SelectTeamMemberDropdown;
        private Label SelectMemberTeamLabel;
        private GroupBox groupBox1;
        private TextBox FirstNameValue;
        private Label FirstNameLabel;
        private TextBox EmailValue;
        private Label EmailLabel;
        private TextBox LastNameValue;
        private Label LastNameLabel;
        private TextBox CellNumberValue;
        private Label PhoneNumberLabel;
        private Button CreateMemberButton;
        private Button DeleteSelectedMemberButton;
        private Button CreateTeamButton;
        private ListBox TeamMembersListBox;
    }
}
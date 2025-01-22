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
            tournamentName = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            selectTeamLabel = new Label();
            addMemberButton = new Button();
            AddNewMembergroupBox = new GroupBox();
            cellphone = new TextBox();
            createMemberButton = new Button();
            cellphoneLabel = new Label();
            email = new TextBox();
            emailLabel = new Label();
            lastName = new TextBox();
            lastNameLabel = new Label();
            firstName = new TextBox();
            firstNameLabel = new Label();
            tournamentPlayersListBox = new ListBox();
            createTeamButton = new Button();
            roundDropDown = new ComboBox();
            deleteSelectedMember = new Button();
            AddNewMembergroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tournamentName
            // 
            tournamentName.Location = new Point(32, 136);
            tournamentName.Margin = new Padding(5, 6, 5, 6);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(483, 35);
            tournamentName.TabIndex = 5;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(32, 86);
            teamNameLabel.Margin = new Padding(5, 0, 5, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(127, 30);
            teamNameLabel.TabIndex = 4;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = SystemColors.MenuHighlight;
            createTeamLabel.Location = new Point(24, 28);
            createTeamLabel.Margin = new Padding(5, 0, 5, 0);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(163, 37);
            createTeamLabel.TabIndex = 3;
            createTeamLabel.Text = "Create Team";
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(32, 197);
            selectTeamLabel.Margin = new Padding(5, 0, 5, 0);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(213, 30);
            selectTeamLabel.TabIndex = 4;
            selectTeamLabel.Text = "Select Team Member";
            // 
            // addMemberButton
            // 
            addMemberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMemberButton.ForeColor = SystemColors.MenuHighlight;
            addMemberButton.Location = new Point(183, 304);
            addMemberButton.Margin = new Padding(5, 6, 5, 6);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(187, 42);
            addMemberButton.TabIndex = 6;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            // 
            // AddNewMembergroupBox
            // 
            AddNewMembergroupBox.Controls.Add(cellphone);
            AddNewMembergroupBox.Controls.Add(createMemberButton);
            AddNewMembergroupBox.Controls.Add(cellphoneLabel);
            AddNewMembergroupBox.Controls.Add(email);
            AddNewMembergroupBox.Controls.Add(emailLabel);
            AddNewMembergroupBox.Controls.Add(lastName);
            AddNewMembergroupBox.Controls.Add(lastNameLabel);
            AddNewMembergroupBox.Controls.Add(firstName);
            AddNewMembergroupBox.Controls.Add(firstNameLabel);
            AddNewMembergroupBox.Location = new Point(32, 373);
            AddNewMembergroupBox.Name = "AddNewMembergroupBox";
            AddNewMembergroupBox.Size = new Size(483, 341);
            AddNewMembergroupBox.TabIndex = 7;
            AddNewMembergroupBox.TabStop = false;
            AddNewMembergroupBox.Text = "Add New Member";
            // 
            // cellphone
            // 
            cellphone.Location = new Point(172, 211);
            cellphone.Name = "cellphone";
            cellphone.Size = new Size(223, 35);
            cellphone.TabIndex = 9;
            // 
            // createMemberButton
            // 
            createMemberButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(138, 275);
            createMemberButton.Margin = new Padding(5, 6, 5, 6);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(187, 42);
            createMemberButton.TabIndex = 6;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cellphoneLabel.ForeColor = SystemColors.MenuHighlight;
            cellphoneLabel.Location = new Point(7, 208);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(138, 37);
            cellphoneLabel.TabIndex = 8;
            cellphoneLabel.Text = "Cellphone";
            cellphoneLabel.Click += label2_Click;
            // 
            // email
            // 
            email.Location = new Point(172, 154);
            email.Name = "email";
            email.Size = new Size(223, 35);
            email.TabIndex = 9;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailLabel.ForeColor = SystemColors.MenuHighlight;
            emailLabel.Location = new Point(7, 151);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email";
            emailLabel.Click += label2_Click;
            // 
            // lastName
            // 
            lastName.Location = new Point(172, 103);
            lastName.Name = "lastName";
            lastName.Size = new Size(223, 35);
            lastName.TabIndex = 9;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastNameLabel.ForeColor = SystemColors.MenuHighlight;
            lastNameLabel.Location = new Point(7, 100);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(142, 37);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "Last Name";
            lastNameLabel.Click += label2_Click;
            // 
            // firstName
            // 
            firstName.Location = new Point(172, 47);
            firstName.Name = "firstName";
            firstName.Size = new Size(223, 35);
            firstName.TabIndex = 9;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstNameLabel.ForeColor = SystemColors.MenuHighlight;
            firstNameLabel.Location = new Point(7, 44);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(144, 37);
            firstNameLabel.TabIndex = 8;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += label2_Click;
            // 
            // tournamentPlayersListBox
            // 
            tournamentPlayersListBox.ForeColor = SystemColors.MenuHighlight;
            tournamentPlayersListBox.FormattingEnabled = true;
            tournamentPlayersListBox.ItemHeight = 30;
            tournamentPlayersListBox.Location = new Point(592, 127);
            tournamentPlayersListBox.Margin = new Padding(5, 6, 5, 6);
            tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            tournamentPlayersListBox.Size = new Size(340, 574);
            tournamentPlayersListBox.TabIndex = 8;
            // 
            // createTeamButton
            // 
            createTeamButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(468, 730);
            createTeamButton.Margin = new Padding(5, 6, 5, 6);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(187, 42);
            createTeamButton.TabIndex = 6;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(32, 245);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(483, 38);
            roundDropDown.TabIndex = 9;
            // 
            // deleteSelectedMember
            // 
            deleteSelectedMember.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedMember.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedMember.Font = new Font("Segoe UI", 12F);
            deleteSelectedMember.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedMember.Location = new Point(958, 127);
            deleteSelectedMember.Margin = new Padding(5, 6, 5, 6);
            deleteSelectedMember.Name = "deleteSelectedMember";
            deleteSelectedMember.Size = new Size(99, 63);
            deleteSelectedMember.TabIndex = 10;
            deleteSelectedMember.Text = "Delete Selected";
            deleteSelectedMember.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1091, 822);
            Controls.Add(deleteSelectedMember);
            Controls.Add(roundDropDown);
            Controls.Add(tournamentPlayersListBox);
            Controls.Add(AddNewMembergroupBox);
            Controls.Add(createTeamButton);
            Controls.Add(addMemberButton);
            Controls.Add(tournamentName);
            Controls.Add(selectTeamLabel);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTeamForm";
            Text = "Create Team";
            AddNewMembergroupBox.ResumeLayout(false);
            AddNewMembergroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tournamentName;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Label selectTeamLabel;
        private Button addMemberButton;
        private GroupBox AddNewMembergroupBox;
        private TextBox firstName;
        private Label firstNameLabel;
        private TextBox cellphone;
        private Button createMemberButton;
        private Label cellphoneLabel;
        private TextBox email;
        private Label emailLabel;
        private TextBox lastName;
        private Label lastNameLabel;
        private ListBox tournamentPlayersListBox;
        private Button createTeamButton;
        private ComboBox roundDropDown;
        private Button deleteSelectedMember;
    }
}
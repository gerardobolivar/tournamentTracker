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
            createTournamentLabel = new Label();
            tournamentNameLabel = new Label();
            tournamentName = new TextBox();
            entryFeeLabel = new Label();
            entryFee = new TextBox();
            selectTeamLabel = new Label();
            createNewLinkedLabel = new LinkLabel();
            selectTeamComboBox = new ComboBox();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            playersLabel = new Label();
            teamsListBox = new ListBox();
            deleteSelectedTeam = new Button();
            prizesLabel = new Label();
            deleteSelectedPrize = new Button();
            prizesListBox = new ListBox();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // createTournamentLabel
            // 
            createTournamentLabel.AutoSize = true;
            createTournamentLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTournamentLabel.ForeColor = SystemColors.MenuHighlight;
            createTournamentLabel.Location = new Point(21, 18);
            createTournamentLabel.Margin = new Padding(5, 0, 5, 0);
            createTournamentLabel.Name = "createTournamentLabel";
            createTournamentLabel.Size = new Size(242, 37);
            createTournamentLabel.TabIndex = 0;
            createTournamentLabel.Text = "Create Tournament";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tournamentNameLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentNameLabel.Location = new Point(29, 76);
            tournamentNameLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(192, 30);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "Tournament Name";
            tournamentNameLabel.Click += label2_Click;
            // 
            // tournamentName
            // 
            tournamentName.Location = new Point(29, 122);
            tournamentName.Margin = new Padding(5, 6, 5, 6);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(431, 35);
            tournamentName.TabIndex = 2;
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            entryFeeLabel.ForeColor = SystemColors.MenuHighlight;
            entryFeeLabel.Location = new Point(29, 198);
            entryFeeLabel.Margin = new Padding(5, 0, 5, 0);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(103, 30);
            entryFeeLabel.TabIndex = 1;
            entryFeeLabel.Text = "Entry Fee";
            entryFeeLabel.Click += label2_Click;
            // 
            // entryFee
            // 
            entryFee.Location = new Point(156, 198);
            entryFee.Margin = new Padding(5, 6, 5, 6);
            entryFee.Name = "entryFee";
            entryFee.Size = new Size(304, 35);
            entryFee.TabIndex = 2;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectTeamLabel.ForeColor = SystemColors.MenuHighlight;
            selectTeamLabel.Location = new Point(29, 287);
            selectTeamLabel.Margin = new Padding(5, 0, 5, 0);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(126, 30);
            selectTeamLabel.TabIndex = 1;
            selectTeamLabel.Text = "Select Team";
            selectTeamLabel.Click += label2_Click;
            // 
            // createNewLinkedLabel
            // 
            createNewLinkedLabel.AutoSize = true;
            createNewLinkedLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createNewLinkedLabel.Location = new Point(225, 292);
            createNewLinkedLabel.Margin = new Padding(5, 0, 5, 0);
            createNewLinkedLabel.Name = "createNewLinkedLabel";
            createNewLinkedLabel.Size = new Size(104, 25);
            createNewLinkedLabel.TabIndex = 3;
            createNewLinkedLabel.TabStop = true;
            createNewLinkedLabel.Text = "create new";
            // 
            // selectTeamComboBox
            // 
            selectTeamComboBox.FormattingEnabled = true;
            selectTeamComboBox.Location = new Point(29, 352);
            selectTeamComboBox.Margin = new Padding(5, 6, 5, 6);
            selectTeamComboBox.Name = "selectTeamComboBox";
            selectTeamComboBox.Size = new Size(431, 38);
            selectTeamComboBox.TabIndex = 4;
            // 
            // addTeamButton
            // 
            addTeamButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTeamButton.ForeColor = SystemColors.MenuHighlight;
            addTeamButton.Location = new Point(142, 419);
            addTeamButton.Margin = new Padding(5, 6, 5, 6);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(187, 62);
            addTeamButton.TabIndex = 5;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            addTeamButton.Click += button1_Click;
            // 
            // createPrizeButton
            // 
            createPrizeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(142, 526);
            createPrizeButton.Margin = new Padding(5, 6, 5, 6);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(187, 62);
            createPrizeButton.TabIndex = 5;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += button1_Click;
            // 
            // playersLabel
            // 
            playersLabel.AutoSize = true;
            playersLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playersLabel.ForeColor = SystemColors.MenuHighlight;
            playersLabel.Location = new Point(569, 65);
            playersLabel.Margin = new Padding(5, 0, 5, 0);
            playersLabel.Name = "playersLabel";
            playersLabel.Size = new Size(161, 30);
            playersLabel.TabIndex = 1;
            playersLabel.Text = "Teams / Players";
            playersLabel.Click += label2_Click;
            // 
            // teamsListBox
            // 
            teamsListBox.ForeColor = SystemColors.MenuHighlight;
            teamsListBox.FormattingEnabled = true;
            teamsListBox.ItemHeight = 30;
            teamsListBox.Location = new Point(569, 122);
            teamsListBox.Margin = new Padding(5, 6, 5, 6);
            teamsListBox.Name = "teamsListBox";
            teamsListBox.Size = new Size(482, 184);
            teamsListBox.TabIndex = 6;
            // 
            // deleteSelectedTeam
            // 
            deleteSelectedTeam.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedTeam.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedTeam.Font = new Font("Segoe UI", 12F);
            deleteSelectedTeam.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedTeam.Location = new Point(1061, 122);
            deleteSelectedTeam.Margin = new Padding(5, 6, 5, 6);
            deleteSelectedTeam.Name = "deleteSelectedTeam";
            deleteSelectedTeam.Size = new Size(99, 63);
            deleteSelectedTeam.TabIndex = 5;
            deleteSelectedTeam.Text = "Delete Selected";
            deleteSelectedTeam.UseVisualStyleBackColor = true;
            deleteSelectedTeam.Click += button1_Click;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prizesLabel.ForeColor = SystemColors.MenuHighlight;
            prizesLabel.Location = new Point(569, 352);
            prizesLabel.Margin = new Padding(5, 0, 5, 0);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(68, 30);
            prizesLabel.TabIndex = 1;
            prizesLabel.Text = "Prizes";
            prizesLabel.Click += label2_Click;
            // 
            // deleteSelectedPrize
            // 
            deleteSelectedPrize.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrize.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrize.Font = new Font("Segoe UI", 12F);
            deleteSelectedPrize.ForeColor = SystemColors.MenuHighlight;
            deleteSelectedPrize.Location = new Point(1061, 404);
            deleteSelectedPrize.Margin = new Padding(5, 6, 5, 6);
            deleteSelectedPrize.Name = "deleteSelectedPrize";
            deleteSelectedPrize.Size = new Size(99, 63);
            deleteSelectedPrize.TabIndex = 5;
            deleteSelectedPrize.Text = "Delete Selected";
            deleteSelectedPrize.UseVisualStyleBackColor = true;
            deleteSelectedPrize.Click += button1_Click;
            // 
            // prizesListBox
            // 
            prizesListBox.ForeColor = SystemColors.MenuHighlight;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(569, 404);
            prizesListBox.Margin = new Padding(5, 6, 5, 6);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(482, 184);
            prizesListBox.TabIndex = 6;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(388, 613);
            createTournamentButton.Margin = new Padding(5, 6, 5, 6);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(342, 58);
            createTournamentButton.TabIndex = 5;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += button1_Click;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1207, 694);
            Controls.Add(prizesListBox);
            Controls.Add(teamsListBox);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPrize);
            Controls.Add(createPrizeButton);
            Controls.Add(deleteSelectedTeam);
            Controls.Add(addTeamButton);
            Controls.Add(selectTeamComboBox);
            Controls.Add(createNewLinkedLabel);
            Controls.Add(entryFee);
            Controls.Add(tournamentName);
            Controls.Add(selectTeamLabel);
            Controls.Add(prizesLabel);
            Controls.Add(entryFeeLabel);
            Controls.Add(playersLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(createTournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "CreateTournamentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createTournamentLabel;
        private Label tournamentNameLabel;
        private TextBox tournamentName;
        private Label entryFeeLabel;
        private TextBox entryFee;
        private Label selectTeamLabel;
        private LinkLabel createNewLinkedLabel;
        private ComboBox selectTeamComboBox;
        private Button addTeamButton;
        private Button createPrizeButton;
        private Label playersLabel;
        private ListBox teamsListBox;
        private Button deleteSelectedTeam;
        private Label prizesLabel;
        private Button deleteSelectedPrize;
        private ListBox prizesListBox;
        private Button createTournamentButton;
    }
}
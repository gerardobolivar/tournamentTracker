namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            tournamentLabel = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamTwoName = new Label();
            scoreTeamOneLabel = new Label();
            scoreTeamOne = new TextBox();
            scoreTeamTwoLabel = new Label();
            scoreTeamTwo = new TextBox();
            vsLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // tournamentLabel
            // 
            tournamentLabel.AutoSize = true;
            tournamentLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentLabel.Location = new Point(22, 27);
            tournamentLabel.Name = "tournamentLabel";
            tournamentLabel.Size = new Size(214, 50);
            tournamentLabel.TabIndex = 0;
            tournamentLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(242, 27);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(150, 50);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundLabel.ForeColor = SystemColors.MenuHighlight;
            roundLabel.Location = new Point(22, 99);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(100, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round:";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(128, 98);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(246, 38);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unplayedOnlyCheckbox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckbox.Location = new Point(128, 176);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(212, 41);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.ForeColor = SystemColors.MenuHighlight;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(22, 251);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(352, 242);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneName.ForeColor = SystemColors.MenuHighlight;
            teamOneName.Location = new Point(417, 213);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(165, 37);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoName.ForeColor = SystemColors.MenuHighlight;
            teamTwoName.Location = new Point(417, 377);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(165, 37);
            teamTwoName.TabIndex = 6;
            teamTwoName.Text = "<team two>";
            // 
            // scoreTeamOneLabel
            // 
            scoreTeamOneLabel.AutoSize = true;
            scoreTeamOneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreTeamOneLabel.ForeColor = SystemColors.MenuHighlight;
            scoreTeamOneLabel.Location = new Point(431, 271);
            scoreTeamOneLabel.Name = "scoreTeamOneLabel";
            scoreTeamOneLabel.Size = new Size(82, 37);
            scoreTeamOneLabel.TabIndex = 6;
            scoreTeamOneLabel.Text = "Score";
            // 
            // scoreTeamOne
            // 
            scoreTeamOne.Location = new Point(519, 274);
            scoreTeamOne.Name = "scoreTeamOne";
            scoreTeamOne.Size = new Size(200, 35);
            scoreTeamOne.TabIndex = 7;
            // 
            // scoreTeamTwoLabel
            // 
            scoreTeamTwoLabel.AutoSize = true;
            scoreTeamTwoLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreTeamTwoLabel.ForeColor = SystemColors.MenuHighlight;
            scoreTeamTwoLabel.Location = new Point(431, 447);
            scoreTeamTwoLabel.Name = "scoreTeamTwoLabel";
            scoreTeamTwoLabel.Size = new Size(82, 37);
            scoreTeamTwoLabel.TabIndex = 6;
            scoreTeamTwoLabel.Text = "Score";
            // 
            // scoreTeamTwo
            // 
            scoreTeamTwo.Location = new Point(519, 450);
            scoreTeamTwo.Name = "scoreTeamTwo";
            scoreTeamTwo.Size = new Size(200, 35);
            scoreTeamTwo.TabIndex = 7;
            // 
            // vsLabel
            // 
            vsLabel.AutoSize = true;
            vsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vsLabel.ForeColor = SystemColors.MenuHighlight;
            vsLabel.Location = new Point(583, 336);
            vsLabel.Name = "vsLabel";
            vsLabel.Size = new Size(70, 37);
            vsLabel.TabIndex = 6;
            vsLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(759, 350);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(124, 45);
            scoreButton.TabIndex = 8;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(922, 535);
            Controls.Add(scoreButton);
            Controls.Add(scoreTeamTwo);
            Controls.Add(scoreTeamOne);
            Controls.Add(teamTwoName);
            Controls.Add(scoreTeamTwoLabel);
            Controls.Add(vsLabel);
            Controls.Add(scoreTeamOneLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(tournamentLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentLabel;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamTwoName;
        private Label scoreTeamOneLabel;
        private TextBox scoreTeamOne;
        private Label scoreTeamTwoLabel;
        private TextBox scoreTeamTwo;
        private Label vsLabel;
        private Button scoreButton;
    }
}

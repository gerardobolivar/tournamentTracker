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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            tournamentDashboardLabel = new Label();
            teamNameLabel = new Label();
            loadTournamentButton = new Button();
            createTournamentButton = new Button();
            tournamentDropDown = new ComboBox();
            SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            tournamentDashboardLabel.AutoSize = true;
            tournamentDashboardLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentDashboardLabel.ForeColor = SystemColors.MenuHighlight;
            tournamentDashboardLabel.Location = new Point(109, 38);
            tournamentDashboardLabel.Margin = new Padding(5, 0, 5, 0);
            tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            tournamentDashboardLabel.Size = new Size(295, 37);
            tournamentDashboardLabel.TabIndex = 1;
            tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            teamNameLabel.ForeColor = SystemColors.MenuHighlight;
            teamNameLabel.Location = new Point(125, 110);
            teamNameLabel.Margin = new Padding(5, 0, 5, 0);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(262, 30);
            teamNameLabel.TabIndex = 5;
            teamNameLabel.Text = "Load Existing Tournament";
            // 
            // loadTournamentButton
            // 
            loadTournamentButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadTournamentButton.ForeColor = SystemColors.MenuHighlight;
            loadTournamentButton.Location = new Point(163, 211);
            loadTournamentButton.Margin = new Padding(5, 6, 5, 6);
            loadTournamentButton.Name = "loadTournamentButton";
            loadTournamentButton.Size = new Size(187, 42);
            loadTournamentButton.TabIndex = 7;
            loadTournamentButton.Text = "Load Tournament";
            loadTournamentButton.UseVisualStyleBackColor = true;
            loadTournamentButton.Click += loadTournamentButton_Click;
            // 
            // createTournamentButton
            // 
            createTournamentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTournamentButton.ForeColor = SystemColors.MenuHighlight;
            createTournamentButton.Location = new Point(109, 279);
            createTournamentButton.Margin = new Padding(5, 6, 5, 6);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(295, 105);
            createTournamentButton.TabIndex = 7;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            createTournamentButton.Click += loadTournamentButton_Click;
            // 
            // tournamentDropDown
            // 
            tournamentDropDown.FormattingEnabled = true;
            tournamentDropDown.Location = new Point(60, 154);
            tournamentDropDown.Name = "tournamentDropDown";
            tournamentDropDown.Size = new Size(392, 38);
            tournamentDropDown.TabIndex = 10;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(504, 430);
            Controls.Add(tournamentDropDown);
            Controls.Add(createTournamentButton);
            Controls.Add(loadTournamentButton);
            Controls.Add(teamNameLabel);
            Controls.Add(tournamentDashboardLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            Text = "Tournament Dashboard";
            Load += TournamentDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tournamentDashboardLabel;
        private Label teamNameLabel;
        private Button loadTournamentButton;
        private Button createTournamentButton;
        private ComboBox tournamentDropDown;
    }
}
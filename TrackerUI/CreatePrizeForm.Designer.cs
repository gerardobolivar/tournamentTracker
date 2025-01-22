namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            scoreButton = new Button();
            orLabel = new Label();
            prizeAmount = new TextBox();
            prizePercentageLabel = new Label();
            email = new TextBox();
            prizeAmountLabel = new Label();
            lastName = new TextBox();
            placeNameLabel = new Label();
            firstName = new TextBox();
            placeNumberLabel = new Label();
            createPrizeLabel = new Label();
            SuspendLayout();
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(162, 407);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(161, 45);
            scoreButton.TabIndex = 28;
            scoreButton.Text = "Create Prize";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orLabel.ForeColor = SystemColors.MenuHighlight;
            orLabel.Location = new Point(204, 270);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(75, 37);
            orLabel.TabIndex = 27;
            orLabel.Text = "-OR-";
            // 
            // prizeAmount
            // 
            prizeAmount.Location = new Point(261, 324);
            prizeAmount.Name = "prizeAmount";
            prizeAmount.Size = new Size(223, 35);
            prizeAmount.TabIndex = 23;
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizePercentageLabel.ForeColor = SystemColors.MenuHighlight;
            prizePercentageLabel.Location = new Point(27, 324);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(212, 37);
            prizePercentageLabel.TabIndex = 19;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // email
            // 
            email.Location = new Point(245, 201);
            email.Name = "email";
            email.Size = new Size(223, 35);
            email.TabIndex = 24;
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prizeAmountLabel.ForeColor = SystemColors.MenuHighlight;
            prizeAmountLabel.Location = new Point(27, 201);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(176, 37);
            prizeAmountLabel.TabIndex = 20;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // lastName
            // 
            lastName.Location = new Point(245, 150);
            lastName.Name = "lastName";
            lastName.Size = new Size(223, 35);
            lastName.TabIndex = 25;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNameLabel.ForeColor = SystemColors.MenuHighlight;
            placeNameLabel.Location = new Point(27, 150);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 21;
            placeNameLabel.Text = "Place Name";
            // 
            // firstName
            // 
            firstName.Location = new Point(245, 95);
            firstName.Name = "firstName";
            firstName.Size = new Size(223, 35);
            firstName.TabIndex = 26;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            placeNumberLabel.ForeColor = SystemColors.MenuHighlight;
            placeNumberLabel.Location = new Point(27, 94);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 22;
            placeNumberLabel.Text = "Place Number";
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeLabel.ForeColor = SystemColors.MenuHighlight;
            createPrizeLabel.Location = new Point(27, 35);
            createPrizeLabel.Margin = new Padding(5, 0, 5, 0);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(158, 37);
            createPrizeLabel.TabIndex = 18;
            createPrizeLabel.Text = "Create Prize";
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(528, 478);
            Controls.Add(scoreButton);
            Controls.Add(orLabel);
            Controls.Add(prizeAmount);
            Controls.Add(prizePercentageLabel);
            Controls.Add(email);
            Controls.Add(prizeAmountLabel);
            Controls.Add(lastName);
            Controls.Add(placeNameLabel);
            Controls.Add(firstName);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button scoreButton;
        private Label orLabel;
        private TextBox prizeAmount;
        private Label prizePercentageLabel;
        private TextBox email;
        private Label prizeAmountLabel;
        private TextBox lastName;
        private Label placeNameLabel;
        private TextBox firstName;
        private Label placeNumberLabel;
        private Label createPrizeLabel;
    }
}
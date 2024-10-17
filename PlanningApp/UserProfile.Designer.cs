namespace PlanningApp
{
    partial class UserProfile
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox UserAccountTextBox;
        private System.Windows.Forms.TextBox NicknameTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Label UserAccountLabel;
        private System.Windows.Forms.Label NicknameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Button SaveButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            UserAccountTextBox = new TextBox();
            NicknameTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            EmailTextBox = new TextBox();
            RoleTextBox = new TextBox();
            UserAccountLabel = new Label();
            NicknameLabel = new Label();
            PhoneNumberLabel = new Label();
            EmailLabel = new Label();
            RoleLabel = new Label();
            SaveButton = new Button(); 
            SuspendLayout();

            // UserAccountTextBox
            UserAccountTextBox.Location = new Point(150, 50);
            UserAccountTextBox.Name = "UserAccountTextBox";
            UserAccountTextBox.ReadOnly = true;
            UserAccountTextBox.Size = new Size(200, 27);
            UserAccountTextBox.TabIndex = 1;

            // NicknameTextBox
            NicknameTextBox.Location = new Point(150, 90);
            NicknameTextBox.Name = "NicknameTextBox";
            NicknameTextBox.Size = new Size(200, 27);
            NicknameTextBox.TabIndex = 3;

            // PhoneNumberTextBox
            PhoneNumberTextBox.Location = new Point(150, 130);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(200, 27);
            PhoneNumberTextBox.TabIndex = 5;

            // EmailTextBox
            EmailTextBox.Location = new Point(150, 170);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(200, 27);
            EmailTextBox.TabIndex = 7;

            // RoleTextBox
            RoleTextBox.Location = new Point(150, 210);
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.ReadOnly = true;
            RoleTextBox.Size = new Size(200, 27);
            RoleTextBox.TabIndex = 9;

            // UserAccountLabel
            UserAccountLabel.Location = new Point(50, 50);
            UserAccountLabel.Name = "UserAccountLabel";
            UserAccountLabel.Size = new Size(100, 23);
            UserAccountLabel.TabIndex = 0;
            UserAccountLabel.Text = "User Account:";

            // NicknameLabel
            NicknameLabel.Location = new Point(50, 90);
            NicknameLabel.Name = "NicknameLabel";
            NicknameLabel.Size = new Size(100, 23);
            NicknameLabel.TabIndex = 2;
            NicknameLabel.Text = "Nickname:";

            // PhoneNumberLabel
            PhoneNumberLabel.Location = new Point(50, 130);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(100, 23);
            PhoneNumberLabel.TabIndex = 4;
            PhoneNumberLabel.Text = "Phone Number:";

            // EmailLabel
            EmailLabel.Location = new Point(50, 170);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(100, 23);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email:";

            // RoleLabel
            RoleLabel.Location = new Point(50, 210);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(100, 23);
            RoleLabel.TabIndex = 8;
            RoleLabel.Text = "Role:";

            // SaveButton
            SaveButton.Location = new Point(150, 250);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(100, 30);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += new EventHandler(SaveButton_Click);

            // UserProfile
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 300);
            Controls.Add(UserAccountLabel);
            Controls.Add(UserAccountTextBox);
            Controls.Add(NicknameLabel);
            Controls.Add(NicknameTextBox);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(RoleLabel);
            Controls.Add(RoleTextBox);
            Controls.Add(SaveButton);
            Name = "UserProfile";
            Text = "User Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
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
        private System.Windows.Forms.PictureBox UserProfilePictureBox;  
        private System.Windows.Forms.Label ProfileHeaderLabel;
        private System.Windows.Forms.Label DescriptionLabel;

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
            UserProfilePictureBox = new PictureBox();
            ProfileHeaderLabel = new Label();
            DescriptionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)UserProfilePictureBox).BeginInit();
            SuspendLayout();
            // UserAccountTextBox
            UserAccountTextBox.Font = new Font("Arial", 12F);
            UserAccountTextBox.Location = new Point(626, 193);
            UserAccountTextBox.Name = "UserAccountTextBox";
            UserAccountTextBox.ReadOnly = true;
            UserAccountTextBox.Size = new Size(300, 30);
            UserAccountTextBox.TabIndex = 1;
            // NicknameTextBox
            NicknameTextBox.Font = new Font("Arial", 12F);
            NicknameTextBox.Location = new Point(626, 245);
            NicknameTextBox.Name = "NicknameTextBox";
            NicknameTextBox.Size = new Size(300, 30);
            NicknameTextBox.TabIndex = 3;
            // PhoneNumberTextBox
            PhoneNumberTextBox.Font = new Font("Arial", 12F);
            PhoneNumberTextBox.Location = new Point(626, 296);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(300, 30);
            PhoneNumberTextBox.TabIndex = 5;
            // EmailTextBox
            EmailTextBox.Font = new Font("Arial", 12F);
            EmailTextBox.Location = new Point(626, 349);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(300, 30);
            EmailTextBox.TabIndex = 7;

            // RoleTextBox
            RoleTextBox.Font = new Font("Arial", 12F);
            RoleTextBox.Location = new Point(626, 402);
            RoleTextBox.Name = "RoleTextBox";
            RoleTextBox.ReadOnly = true;
            RoleTextBox.Size = new Size(300, 30);
            RoleTextBox.TabIndex = 9;
            // UserAccountLabel
            UserAccountLabel.Font = new Font("Arial", 12F);
            UserAccountLabel.Location = new Point(476, 196);
            UserAccountLabel.Name = "UserAccountLabel";
            UserAccountLabel.Size = new Size(140, 30);
            UserAccountLabel.TabIndex = 0;
            UserAccountLabel.Text = "User Account:";
            // NicknameLabel
            NicknameLabel.Font = new Font("Arial", 12F);
            NicknameLabel.Location = new Point(476, 248);
            NicknameLabel.Name = "NicknameLabel";
            NicknameLabel.Size = new Size(140, 30);
            NicknameLabel.TabIndex = 2;
            NicknameLabel.Text = "Nickname:";
            // PhoneNumberLabel 
            PhoneNumberLabel.Font = new Font("Arial", 12F);
            PhoneNumberLabel.Location = new Point(476, 299);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(140, 30);
            PhoneNumberLabel.TabIndex = 4;
            PhoneNumberLabel.Text = "Phone Number:";
            // EmailLabel
            EmailLabel.Font = new Font("Arial", 12F);
            EmailLabel.Location = new Point(476, 352);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(140, 30);
            EmailLabel.TabIndex = 6;
            EmailLabel.Text = "Email:";
            // RoleLabel
            RoleLabel.Font = new Font("Arial", 12F);
            RoleLabel.Location = new Point(476, 405);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(140, 30);
            RoleLabel.TabIndex = 8;
            RoleLabel.Text = "Role:";
            // SaveButton
            SaveButton.Font = new Font("Arial", 12F, FontStyle.Bold);
            SaveButton.Location = new Point(626, 492);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(120, 45);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Update";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // UserProfilePictureBox
            UserProfilePictureBox.Location = new Point(246, 95);
            UserProfilePictureBox.Name = "UserProfilePictureBox";
            UserProfilePictureBox.Size = new Size(189, 189);
            UserProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserProfilePictureBox.TabIndex = 13;
            UserProfilePictureBox.TabStop = false;
            // ProfileHeaderLabel
            ProfileHeaderLabel.Font = new Font("Arial", 14F, FontStyle.Bold);
            ProfileHeaderLabel.Location = new Point(471, 95);
            ProfileHeaderLabel.Name = "ProfileHeaderLabel";
            ProfileHeaderLabel.Size = new Size(300, 30);
            ProfileHeaderLabel.TabIndex = 11;
            ProfileHeaderLabel.Text = "My Profile";
            // DescriptionLabel
            DescriptionLabel.Font = new Font("Arial", 10F, FontStyle.Italic);
            DescriptionLabel.Location = new Point(471, 135);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(400, 30);
            DescriptionLabel.TabIndex = 12;
            DescriptionLabel.Text = "Update and review your personal information below.";
            DescriptionLabel.Click += DescriptionLabel_Click;
            // UserProfile
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(ProfileHeaderLabel);
            Controls.Add(DescriptionLabel);
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
            Controls.Add(UserProfilePictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UserProfile";
            Text = "User Profile";
            ((System.ComponentModel.ISupportInitialize)UserProfilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}

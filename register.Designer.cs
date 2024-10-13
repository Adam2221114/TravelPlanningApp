namespace PlanningApp
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            AccountLabel = new Label();
            UserAccountTextBox = new TextBox();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            ConfirmPasswordLabel = new Label();
            ConfirmPasswordTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            EmailLabel = new Label();
            EmailTextBox = new TextBox();
            NicknameLabel = new Label();
            NicknameTextBox = new TextBox();
            RegisterButton = new Button();
            SuspendLayout();
            // AccountLabel
            AccountLabel.AutoSize = true;
            AccountLabel.Location = new Point(20, 28);
            AccountLabel.Name = "AccountLabel";
            AccountLabel.Size = new Size(84, 20);
            AccountLabel.TabIndex = 0;
            AccountLabel.Text = "Account Number：";
            // UserAccountTextBox
            UserAccountTextBox.Location = new Point(170, 21);
            UserAccountTextBox.Name = "UserAccountTextBox";
            UserAccountTextBox.Size = new Size(193, 27);
            UserAccountTextBox.TabIndex = 1;
            // PasswordLabel 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(20, 68);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(54, 20);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password：";
            // PasswordTextBox
            PasswordTextBox.Location = new Point(170, 61);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(193, 27);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // ConfirmPasswordLabel
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(20, 108);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(84, 20);
            ConfirmPasswordLabel.TabIndex = 4;
            ConfirmPasswordLabel.Text = "Confirm Password：";
            // ConfirmPasswordTextBox 
            ConfirmPasswordTextBox.Location = new Point(170, 101);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(193, 27);
            ConfirmPasswordTextBox.TabIndex = 5;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // PhoneNumberLabel
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(20, 148);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(84, 20);
            PhoneNumberLabel.TabIndex = 6;
            PhoneNumberLabel.Text = "Phone Number：";
            // PhoneNumberTextBox
            PhoneNumberTextBox.Location = new Point(170, 141);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(193, 27);
            PhoneNumberTextBox.TabIndex = 7;
            // EmailLabel
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(20, 188);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(84, 20);
            EmailLabel.TabIndex = 8;
            EmailLabel.Text = "Email：";
            // EmailTextBox
            EmailTextBox.Location = new Point(170, 181);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(193, 27);
            EmailTextBox.TabIndex = 9;
            // NicknameLabel
            NicknameLabel.AutoSize = true;
            NicknameLabel.Location = new Point(20, 228);
            NicknameLabel.Name = "NicknameLabel";
            NicknameLabel.Size = new Size(54, 20);
            NicknameLabel.TabIndex = 10;
            NicknameLabel.Text = "Nickname：";
            // NicknameTextBox
            NicknameTextBox.Location = new Point(170, 221);
            NicknameTextBox.Name = "NicknameTextBox";
            NicknameTextBox.Size = new Size(193, 27);
            NicknameTextBox.TabIndex = 11;
            // RegisterButton
            RegisterButton.Location = new Point(202, 261);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(130, 33);
            RegisterButton.TabIndex = 12;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // RegisterForm
            ClientSize = new Size(404, 320);
            Controls.Add(AccountLabel);
            Controls.Add(UserAccountTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(NicknameLabel);
            Controls.Add(NicknameTextBox);
            Controls.Add(RegisterButton);
            Name = "RegisterForm";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label AccountLabel;
        private System.Windows.Forms.TextBox UserAccountTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label NicknameLabel;  
        private System.Windows.Forms.TextBox NicknameTextBox; 
        private System.Windows.Forms.Button RegisterButton;
    }
}


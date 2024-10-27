namespace PlanningApp
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        // UI 控件
        private TextBox UserAccountTextBox;
        private TextBox PasswordTextBox;
        private TextBox ConfirmPasswordTextBox;
        private TextBox PhoneNumberTextBox;
        private TextBox EmailTextBox;
        private TextBox NicknameTextBox;
        private Button RegisterButton;
        private Label AccountLabel;
        private Label PasswordLabel;
        private Label ConfirmPasswordLabel;
        private Label PhoneNumberLabel;
        private Label EmailLabel;
        private Label NicknameLabel;
        private PictureBox registrationPicture; 
        public NavigationBar navigationBar1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
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
            registrationPicture = new PictureBox();
            navigationBar1 = new NavigationBar();
            ((System.ComponentModel.ISupportInitialize)registrationPicture).BeginInit();
            SuspendLayout();
            // AccountLabel
            AccountLabel.AutoSize = true;
            AccountLabel.Location = new Point(60, 134);
            AccountLabel.Name = "AccountLabel";
            AccountLabel.Size = new Size(122, 20);
            AccountLabel.TabIndex = 0;
            AccountLabel.Text = "User Account：";
            // UserAccountTextBox
            UserAccountTextBox.Location = new Point(221, 134);
            UserAccountTextBox.Name = "UserAccountTextBox";
            UserAccountTextBox.Size = new Size(224, 27);
            UserAccountTextBox.TabIndex = 1;
            // PasswordLabel 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(703, 134);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(93, 20);
            PasswordLabel.TabIndex = 2;
            PasswordLabel.Text = "Password：";
            // PasswordTextBox
            PasswordTextBox.Location = new Point(853, 127);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(224, 27);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // ConfirmPasswordLabel
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(692, 199);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(155, 20);
            ConfirmPasswordLabel.TabIndex = 4;
            ConfirmPasswordLabel.Text = "Confirm Password：";
            // ConfirmPasswordTextBox
            ConfirmPasswordTextBox.Location = new Point(853, 192);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(224, 27);
            ConfirmPasswordTextBox.TabIndex = 5;
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
            // PhoneNumberLabel
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(61, 199);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(134, 20);
            PhoneNumberLabel.TabIndex = 6;
            PhoneNumberLabel.Text = "Phone Number：";
            // PhoneNumberTextBox
            PhoneNumberTextBox.Location = new Point(211, 192);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(224, 27);
            PhoneNumberTextBox.TabIndex = 7;
            // EmailLabel
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(60, 257);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(62, 20);
            EmailLabel.TabIndex = 8;
            EmailLabel.Text = "Email：";
            // EmailTextBox
            EmailTextBox.Location = new Point(221, 254);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(224, 27);
            EmailTextBox.TabIndex = 9;
            // NicknameLabel
            NicknameLabel.AutoSize = true;
            NicknameLabel.Location = new Point(703, 264);
            NicknameLabel.Name = "NicknameLabel";
            NicknameLabel.Size = new Size(96, 20);
            NicknameLabel.TabIndex = 10;
            NicknameLabel.Text = "Nickname：";
            // NicknameTextBox
            NicknameTextBox.Location = new Point(853, 257);
            NicknameTextBox.Name = "NicknameTextBox";
            NicknameTextBox.Size = new Size(224, 27);
            NicknameTextBox.TabIndex = 11;
            // RegisterButton
            RegisterButton.Location = new Point(477, 375);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(224, 30);
            RegisterButton.TabIndex = 12;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // registrationPicture
            registrationPicture.Location = new Point(0, 157);
            registrationPicture.Name = "registrationPicture";
            registrationPicture.Size = new Size(1162, 513);
            registrationPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            registrationPicture.TabIndex = 0;
            registrationPicture.TabStop = false;
            // navigationBar1
            navigationBar1.Location = new Point(0, 0);
            navigationBar1.Name = "navigationBar1";
            navigationBar1.Size = new Size(1220, 50);
            navigationBar1.TabIndex = 13;
            // RegisterForm
            BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            ClientSize = new Size(1161, 665);
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
            Controls.Add(navigationBar1);
            Controls.Add(registrationPicture);
            Name = "RegisterForm";
            Text = "Registration Page";
            ((System.ComponentModel.ISupportInitialize)registrationPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        #endregion
        }
    }
}

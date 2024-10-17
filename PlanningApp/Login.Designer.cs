namespace PlanningApp
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox IDTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
        private Button RegisterButton;
        private Label IDLabel;
        private Label PasswordLabel;

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
            IDTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            IDLabel = new Label();
            PasswordLabel = new Label();
            SuspendLayout();
             
            // IDTextBox
            IDTextBox.Location = new Point(166, 30);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(200, 27);
            IDTextBox.TabIndex = 0;
            IDTextBox.TextChanged += IDTextBox_TextChanged;

            // PasswordTextBox
            PasswordTextBox.Location = new Point(166, 70);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(200, 27);
            PasswordTextBox.TabIndex = 1;

            // LoginButton
            LoginButton.Location = new Point(131, 110);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(90, 30);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            
            // RegisterButton
            RegisterButton.Location = new Point(319, 110);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(90, 30);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
           
            // IDLabel
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(70, 33);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(70, 20);
            IDLabel.TabIndex = 4;
            IDLabel.Text = "Account";
            
            // PasswordLabel
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(70, 73);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(78, 20);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            
            // Login
            ClientSize = new Size(440, 170);
            Controls.Add(IDTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
            Controls.Add(IDLabel);
            Controls.Add(PasswordLabel);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}




namespace PlanningApp
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label PasswordLabel;

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
            IDTextBox.Location = new Point(149, 17);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(200, 27);
            IDTextBox.TabIndex = 0;
            IDTextBox.TextChanged += IDTextBox_TextChanged;
            // PasswordTextBox
            PasswordTextBox.Location = new Point(149, 60);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(200, 27);
            PasswordTextBox.TabIndex = 1;
            // LoginButton
            LoginButton.Location = new Point(130, 100);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(87, 30);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // RegisterButton 
            RegisterButton.Location = new Point(298, 100);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(87, 30);
            RegisterButton.TabIndex = 3;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // IDLabel
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(19, 24);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(116, 20);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "UserAccount：";
            IDLabel.Click += IDLabel_Click;
            // PasswordLabel
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(19, 67);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(54, 20);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password：";
            // Login
            ClientSize = new Size(428, 150);
            Controls.Add(IDLabel);
            Controls.Add(IDTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}


using System;
using System.Drawing;
using System.Windows.Forms;

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
        private PictureBox LoginPicture;
        public NavigationBar navigationBar1;

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
        /// Initialize components
        /// </summary>
        private void InitializeComponent()
        {
            IDTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            RegisterButton = new Button();
            IDLabel = new Label();
            PasswordLabel = new Label();
            LoginPicture = new PictureBox();
            navigationBar1 = new NavigationBar();
            ((System.ComponentModel.ISupportInitialize)LoginPicture).BeginInit();
            SuspendLayout();
            // IDTextBox
            IDTextBox.Location = new Point(819, 261);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(224, 27);
            IDTextBox.TabIndex = 1;
            // PasswordTextBox
            PasswordTextBox.Location = new Point(819, 311);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(224, 27);
            PasswordTextBox.TabIndex = 2;
            // LoginButton
            LoginButton.Location = new Point(819, 361);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(90, 30);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Sign In";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // RegisterButton 
            RegisterButton.Location = new Point(919, 361);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(90, 30);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // IDLabel 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(719, 261);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(70, 20);
            IDLabel.TabIndex = 5;
            IDLabel.Text = "Account";
            // PasswordLabel
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(719, 311);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(78, 20);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Password";
            // LoginPicture 
            LoginPicture.Location = new Point(0, 57);
            LoginPicture.Name = "LoginPicture";
            LoginPicture.Size = new Size(662, 611);
            LoginPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            LoginPicture.TabIndex = 0;
            LoginPicture.TabStop = false;
            // navigationBar1
            navigationBar1.Location = new Point(0, 0);
            navigationBar1.Name = "navigationBar1";
            navigationBar1.Size = new Size(1159, 58);
            navigationBar1.TabIndex = 7;
            // Login
            BackColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            ClientSize = new Size(1161, 665);
            Controls.Add(IDTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
            Controls.Add(IDLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginPicture);
            Controls.Add(navigationBar1);
            MaximizeBox = false;
            Name = "Login";
            Text = "Login Page";
            ((System.ComponentModel.ISupportInitialize)LoginPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
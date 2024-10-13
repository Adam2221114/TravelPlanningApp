using System;
using System.Linq;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string userAccount = UserAccountTextBox.Text;
                string password = PasswordTextBox.Text;
                string confirmPassword = ConfirmPasswordTextBox.Text;

                if (password != confirmPassword)
                {
                    MessageBox.Show("The password and confirmation password do not match. Please re-enter.");
                    return;
                }

                // 检查是否已存在相同的UserAccount
                if (context.Users.Any(u => u.UserAccount == userAccount))
                {
                    MessageBox.Show("This user account already exists. Please use another one.");
                    return;
                }

                // 创建新用户
                var user = new User
                {
                    UserAccount = userAccount,
                    Password = password,
                    PhoneNumber = PhoneNumberTextBox.Text,
                    Email = EmailTextBox.Text,
                    Nickname = NicknameTextBox.Text
                };

                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                    MessageBox.Show("Registration successful! Welcome"+ user.Nickname ,"Your user account is:" + user.UserAccount);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving data:" + ex.Message);
                }
            }
        }
    }
}







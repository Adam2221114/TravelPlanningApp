using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlanningApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                string userAccount = IDTextBox.Text;
                string password = PasswordTextBox.Text;

                var user = context.Users.FirstOrDefault(u => u.UserAccount == userAccount && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("登录成功！");
                    // 这里可以跳转到主应用页面
                }
                else
                {
                    MessageBox.Show("用户账户或密码错误，请重试。");
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); // 显示注册窗口
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

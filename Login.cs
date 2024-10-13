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
                    MessageBox.Show("��¼�ɹ���");
                    // ���������ת����Ӧ��ҳ��
                }
                else
                {
                    MessageBox.Show("�û��˻���������������ԡ�");
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog(); // ��ʾע�ᴰ��
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

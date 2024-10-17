using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class Login : Form
    {
        private readonly AppDbContext context;

        public Login(AppDbContext context)
        {
            this.context = context;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userAccount = IDTextBox.Text;
            string password = PasswordTextBox.Text;

            // Find matching users from the database
            var user = context.Users.FirstOrDefault(u => u.UserAccount == userAccount && u.Password == password);

            if (user != null)
            {
                // // Store user information in the global session
                UserSession.Instance.SetCurrentUser(user);
                MessageBox.Show("Login successful!");

                if (this.Owner is HomePage homePage)
                {
                    homePage.LoadUserContent(user); // Load user content to HomePage
                }

                if (user.Role == "staff")
                {
                    // Display the staff page, keep the navigation on HomePage
                    StaffPage staffPage = new StaffPage(context);
                    staffPage.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("The user account or password is incorrect, please try again.");
            }
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(context);
            registerForm.ShowDialog();
        }
        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            // don't need logic for now, you can keep it empty
        }

    }
}

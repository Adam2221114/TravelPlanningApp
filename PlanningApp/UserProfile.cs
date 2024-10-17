using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore; // Using the Entity Framework Core namespace

namespace PlanningApp
{
    public partial class UserProfile : Form
    {
        private readonly AppDbContext context;
        private readonly User currentUser;
        public UserProfile(AppDbContext context) // Constructor with AppDbContext parameter
        {
            InitializeComponent();
            this.context = context;
            currentUser = UserSession.Instance.CurrentUser;

            if (currentUser != null)
            {
                LoadUserData();
            }
            else
            {
                MessageBox.Show("There is currently no logged in user information.");
                this.Close();
            }
        }

        private void LoadUserData()
        {
            UserAccountTextBox.Text = currentUser.UserAccount;
            NicknameTextBox.Text = currentUser.Nickname;
            PhoneNumberTextBox.Text = currentUser.PhoneNumber;
            EmailTextBox.Text = currentUser.Email;
            RoleTextBox.Text = currentUser.Role;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                currentUser.Nickname = NicknameTextBox.Text;
                currentUser.PhoneNumber = PhoneNumberTextBox.Text;
                currentUser.Email = EmailTextBox.Text;

                try // Use Entity Framework Core's update method
                {
                    context.Entry(currentUser).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("The information has been updated successfully, please check for updates after next login!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed:" + ex.Message);
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e) // Release database context resources
        {
            context.Dispose();
            base.OnFormClosed(e);
        }
    }
}

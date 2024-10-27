using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace PlanningApp
{
    // User information form class, used to display and edit the information of the currently logged in user
    public partial class UserProfile : Form
    {
        private readonly AppDbContext context; // Database context, used to operate the database
        private readonly User currentUser; // Current logged in user object

        // Constructor, receiving the database context as a parameter
        public UserProfile(AppDbContext context) 
        {
            InitializeComponent();
            this.context = context;
            currentUser = UserSession.Instance.CurrentUser;
            // If the current user is not null, load the user data and profile picture
            if (currentUser != null)
            {
                LoadUserData();
                LoadRegistrationPageImage();
            }
            else
            {
                MessageBox.Show("There is currently no logged in user information.");
                this.Close();
            }
        }

        private void LoadUserData()
        {
            // Display user information, account, NickName, PhoneNumber, Email
            UserAccountTextBox.Text = currentUser.UserAccount;
            NicknameTextBox.Text = currentUser.Nickname;
            PhoneNumberTextBox.Text = currentUser.PhoneNumber;
            EmailTextBox.Text = currentUser.Email;

            // Determine the user role and display it in the role box
            if (currentUser is Customer)
            {
                RoleTextBox.Text = "Customer";
            }
            else if (currentUser is Staff) // The Staff function does not have this item, but it is retained
            {
                RoleTextBox.Text = "Staff";
            }
            else
            {
                RoleTextBox.Text = "Unknown";
            }
        }
        // SaveButton to update User information
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                currentUser.Nickname = NicknameTextBox.Text;
                currentUser.PhoneNumber = PhoneNumberTextBox.Text;
                currentUser.Email = EmailTextBox.Text;
                //Set the status of the user entity to modified and save the changes to the database
                try
                {
                    context.Entry(currentUser).State = EntityState.Modified;//EntityState.Modified enumeration value, used to tell Entity Framework
                    context.SaveChanges();
                    MessageBox.Show("The information has been updated successfully, please check for updates after next login!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Update failed:" + ex.Message);
                }
            }
        }

        private void LoadRegistrationPageImage()
        {
            try
            {
                var imagePath = context.TouristSpots
                    .Where(t => t.Name == "profile")
                    .Select(t => t.ImagePath)
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(imagePath))
                {
                    string fullImagePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath));

                    if (File.Exists(fullImagePath))
                    {
                        UserProfilePictureBox.Image = Image.FromFile(fullImagePath);
                        UserProfilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show($"Image not found, please confirm the path is correct: {fullImagePath}");
                    }
                }
                else
                {
                    MessageBox.Show("The image path is empty and the image cannot be loaded.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the image: {ex.Message}");
            }
        }
        private void DescriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
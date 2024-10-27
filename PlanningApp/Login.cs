using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class Login : Form
    {
        private readonly AppDbContext context;

        // Constructor injects database context
        public Login(AppDbContext context)
        {
            this.context = context;
            InitializeComponent();
            LoadLoginPageImage();
        }

        // Login button click event processing
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string userAccount = IDTextBox.Text;
            string password = PasswordTextBox.Text;

            // Find matching users from the database
            var user = context.Users.FirstOrDefault(u => u.UserAccount == userAccount && u.Password == password);

            if (user != null)
            {
                // Use the non-null assertion to ensure the compiler knows that user is not null
                UserSession.Instance.SetCurrentUser((PlanningApp.User)user);

                MessageBox.Show("Login successful!");

                if (this.Owner is HomePage homePage)
                {
                    homePage.LoadUserContent(user); // Load user content to HomePage
                }
                this.Close(); 
            }
            else
            {
                MessageBox.Show("The user account or password is incorrect, please try again.");
            }
        }
        // Register button click event processing
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(context);
            registerForm.ShowDialog();
        }
        private void LoadLoginPageImage() // Load the image of the Login page
        {
            try //LINQ query to find the image path named "LoginPicture" from the database
            {
                var imagePath = context.TouristSpots
                    .Where(t => t.Name == "LoginPicture") 
                    .Select(t => t.ImagePath)
                    .FirstOrDefault();

                // Use AppDomain.CurrentDomain.BaseDirectory to concatenate relative paths
                if (!string.IsNullOrEmpty(imagePath))
                {
                    string fullImagePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath));

                    if (File.Exists(fullImagePath))
                    {
                        LoginPicture.Image = Image.FromFile(fullImagePath);
                        LoginPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show($"Image not found, please confirm the path is correct: {fullImagePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the image: {ex.Message}");
            }
        }
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class RegisterForm : Form
    {
        private readonly AppDbContext _context;

        public RegisterForm() : this(CreateDbContext()) { }

        // Method to create database context
        private static AppDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("Data Source=localdatabase.db");
            return new AppDbContext(optionsBuilder.Options);
        }

        // Constructor with context
        public RegisterForm(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
            LoadRegistrationPageImage();
        }

        // Register button click event
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string userAccount = UserAccountTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;
            string nickName = NicknameTextBox.Text;
            string email = EmailTextBox.Text;

            if (string.IsNullOrWhiteSpace(userAccount) || userAccount.Length < 4)
            {
                MessageBox.Show("User account cannot be empty and must be at least 4 characters long.");
                return;
            }

            if (_context.Users.Any(u => u.UserAccount == userAccount))
            {
                MessageBox.Show("This user account already exists. Please use another one.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
            {
                MessageBox.Show("Password cannot be empty and must be at least 6 characters long.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("The password and confirmation password do not match. Please re-enter.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nickName))
            {
                MessageBox.Show("Nickname cannot be empty. Please enter a nickname.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email cannot be empty. Please enter an email address.");
                return;
            }
            else if (!new EmailAddressAttribute().IsValid(email)) // Use EmailAddressAttribute to verify the email format
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            // Create a new user
            var user = new Customer
            {
                UserAccount = userAccount,
                Password = password,
                PhoneNumber = PhoneNumberTextBox.Text,
                Email = email,
                Nickname = nickName
            };

            try
            {
                // Add the new user to the database and save it
                _context.Users.Add(user);
                _context.SaveChanges();
                MessageBox.Show($"Registration successful! Welcome, {user.Nickname}. Your user account is: {user.UserAccount}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving data: " + ex.Message);
            }
        }
        // Load the image of the registration page
        private void LoadRegistrationPageImage()
        {
            try
            {
                var imagePath = _context.TouristSpots
                    .Where(t => t.Name == "RegistrationPicture")
                    .Select(t => t.ImagePath)
                    .FirstOrDefault();

                if (!string.IsNullOrEmpty(imagePath))
                {
                    string fullImagePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, imagePath));

                    if (File.Exists(fullImagePath))
                    {
                        registrationPicture.Image = Image.FromFile(fullImagePath);
                        registrationPicture.SizeMode = PictureBoxSizeMode.StretchImage;
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
    }
}
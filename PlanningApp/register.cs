using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class RegisterForm : Form
    {
        private readonly AppDbContext _context;

        public RegisterForm() : this(CreateDbContext()) { }

        // Create a DbContext in the same way
        private static AppDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("Data Source=localdatabase.db");
            return new AppDbContext(optionsBuilder.Options);
        }

        public RegisterForm(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string userAccount = UserAccountTextBox.Text;
            string password = PasswordTextBox.Text;
            string confirmPassword = ConfirmPasswordTextBox.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("The password and confirmation password do not match. Please re-enter.");
                return;
            }

            if (_context.Users.Any(u => u.UserAccount == userAccount)) // Check if the same UserAccount already exists
            {
                MessageBox.Show("This user account already exists. Please use another one.");
                return;
            }

            var user = new User // Create a new user
            {
                UserAccount = userAccount,
                Password = password,
                PhoneNumber = PhoneNumberTextBox.Text,
                Email = EmailTextBox.Text,
                Nickname = NicknameTextBox.Text,
                Role = "customer"
            };

            try
            {
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
    }
}



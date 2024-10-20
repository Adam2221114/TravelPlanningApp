using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace PlanningApp
{
    public partial class NavigationBar : UserControl
    {
        private  AppDbContext _context;
        public NavigationBar()
        {

            InitializeComponent();
        }
        public NavigationBar(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (!this.DesignMode && _context == null)
            {
                InitializeDbContext();
            }
        }
        private void InitializeDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlite("Data Source=localdatabase.db");
            _context = new AppDbContext(optionsBuilder.Options);
        }

        public void SetUserLoggedIn(string userAccount, string nickname)
        {
            BtnSignIn.Visible = false;
            BtnRegister.Visible = false;
            BtnUserName.Visible = true;
            BtnUserName.Text = nickname;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            var loginForm = new Login(_context) { Owner = this.FindForm() };
            loginForm.ShowDialog();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_context);
            registerForm.ShowDialog();
        }

        private void BtnUserName_Click(object sender, EventArgs e)
        {
            UserMenu.Show(BtnUserName, new System.Drawing.Point(0, BtnUserName.Height));
        }

        private void Profile_Click(object sender, EventArgs e)
        {
            var UserProfile = new UserProfile(_context);
            UserProfile.ShowDialog();
        }

        private void Favorites_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Favorites Page");
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open Settings Page");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            UserSession.Instance.Logout();
            BtnUserName.Visible = false;
            BtnSignIn.Visible = true;
            BtnRegister.Visible = true;
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to Home");
        }

        private void AllTouristSpotsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to All Tourist Spots");
        }

        private void MostPopularButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigate to Most Popular");
        }
    }
}









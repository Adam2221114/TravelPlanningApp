using System;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class HomePage : Form
    {
        private readonly AppDbContext _context;

        public HomePage(AppDbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void LoadUserContent(User user)
        {
            if (user.Role == "customer")
            {
                navigationBar1.SetUserLoggedIn(user.UserAccount, user.Nickname);
            }
            else if (user.Role == "staff")
            {
                StaffPage staffPage = new StaffPage(_context);
                staffPage.ShowDialog();
            }
        }

    }
}



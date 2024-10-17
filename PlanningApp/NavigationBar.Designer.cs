namespace PlanningApp
{
    partial class NavigationBar
    {
        private System.ComponentModel.IContainer components = null;
        public Button BtnSignIn;
        public Button BtnRegister;
        public Button BtnUserName;
        private Button BtnHome;
        private Button BtnAllTouristSpots;
        private Button BtnMostPopular;
        private ContextMenuStrip UserMenu;
        private ToolStripMenuItem UserProfileMenuItem;
        private ToolStripMenuItem FavoritesMenuItem;
        private ToolStripMenuItem SettingsMenuItem;
        private ToolStripMenuItem LogoutMenuItem;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnSignIn = new Button();
            this.BtnRegister = new Button();
            this.BtnUserName = new Button();
            this.BtnHome = new Button();
            this.BtnAllTouristSpots = new Button();
            this.BtnMostPopular = new Button();
            this.UserMenu = new ContextMenuStrip(this.components);
            this.UserProfileMenuItem = new ToolStripMenuItem();
            this.FavoritesMenuItem = new ToolStripMenuItem();
            this.SettingsMenuItem = new ToolStripMenuItem();
            this.LogoutMenuItem = new ToolStripMenuItem();

            // BtnHome
            this.BtnHome.Text = "Home";
            this.BtnHome.Location = new System.Drawing.Point(10, 10);
            this.BtnHome.Size = new System.Drawing.Size(100, 30);
            this.BtnHome.Click += new EventHandler(this.HomeButton_Click);
            this.Controls.Add(this.BtnHome);

            // BtnAllTouristSpots
            this.BtnAllTouristSpots.Text = "All Tourist Spots";
            this.BtnAllTouristSpots.Location = new System.Drawing.Point(120, 10);
            this.BtnAllTouristSpots.Size = new System.Drawing.Size(150, 30);
            this.BtnAllTouristSpots.Click += new EventHandler(this.AllTouristSpotsButton_Click);
            this.Controls.Add(this.BtnAllTouristSpots);

            // BtnMostPopular
            this.BtnMostPopular.Text = "Most Popular";
            this.BtnMostPopular.Location = new System.Drawing.Point(280, 10);
            this.BtnMostPopular.Size = new System.Drawing.Size(130, 30);
            this.BtnMostPopular.Click += new EventHandler(this.MostPopularButton_Click);
            this.Controls.Add(this.BtnMostPopular);

            // BtnSignIn
            this.BtnSignIn.Text = "Sign In";
            this.BtnSignIn.Location = new System.Drawing.Point(600, 10);
            this.BtnSignIn.Size = new System.Drawing.Size(75, 30);
            this.BtnSignIn.Click += new EventHandler(this.BtnSignIn_Click);
            this.Controls.Add(this.BtnSignIn);

            // BtnRegister
            this.BtnRegister.Text = "Register";
            this.BtnRegister.Location = new System.Drawing.Point(680, 10);
            this.BtnRegister.Size = new System.Drawing.Size(75, 30);
            this.BtnRegister.Click += new EventHandler(this.BtnRegister_Click);
            this.Controls.Add(this.BtnRegister);

            // BtnUserName
            this.BtnUserName.Text = "User";
            this.BtnUserName.Location = new System.Drawing.Point(600, 10);
            this.BtnUserName.Size = new System.Drawing.Size(155, 30);
            this.BtnUserName.Visible = false;
            this.BtnUserName.Click += new EventHandler(this.BtnUserName_Click);
            this.Controls.Add(this.BtnUserName);

            // UserMenu
            this.UserMenu.Items.AddRange(new ToolStripItem[] {
                this.UserProfileMenuItem,
                this.FavoritesMenuItem,
                this.SettingsMenuItem,
                this.LogoutMenuItem});
            this.BtnUserName.ContextMenuStrip = this.UserMenu;

            // UserProfileMenuItem
            this.UserProfileMenuItem.Text = "User Profile";
            this.UserProfileMenuItem.Click += new EventHandler(this.Profile_Click);

            // FavoritesMenuItem
            this.FavoritesMenuItem.Text = "Favorites";
            this.FavoritesMenuItem.Click += new EventHandler(this.Favorites_Click);

            // SettingsMenuItem
            this.SettingsMenuItem.Text = "Settings";
            this.SettingsMenuItem.Click += new EventHandler(this.Settings_Click);

            // LogoutMenuItem
            this.LogoutMenuItem.Text = "Logout";
            this.LogoutMenuItem.Click += new EventHandler(this.Logout_Click);

            // NavigationBar
            this.Size = new System.Drawing.Size(800, 50);
        }
    }
}





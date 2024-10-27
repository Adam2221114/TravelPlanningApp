using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlanningApp
{
    partial class NavigationBar
    {
        private System.ComponentModel.IContainer components = null;
        public IconButton BtnSignIn;
        public IconButton BtnRegister;
        public IconButton BtnUserName;
        private ContextMenuStrip UserMenu;
        private IconMenuItem UserProfileMenuItem;  
        private IconMenuItem FavoritesMenuItem;    
        private IconMenuItem SettingsMenuItem;    
        private IconMenuItem LogoutMenuItem;       
        private IconButton iconBtnHome;  
        private IconButton iconBtnAllTouristSpots;  
        private IconButton iconBtnMostPopular;

        /// <summary>
        /// Clean up any resources in use.
        /// </summary>
        /// <param name="disposing">true if managed resources should be released; false otherwise. </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Method required for designer support - do not modify the contents of this method using the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BtnSignIn = new IconButton();
            BtnRegister = new IconButton();
            BtnUserName = new IconButton();
            UserMenu = new ContextMenuStrip(components);
            UserProfileMenuItem = new IconMenuItem();
            FavoritesMenuItem = new IconMenuItem();
            SettingsMenuItem = new IconMenuItem();
            LogoutMenuItem = new IconMenuItem();
            iconBtnHome = new IconButton();
            iconBtnAllTouristSpots = new IconButton();
            iconBtnMostPopular = new IconButton();
            UserMenu.SuspendLayout();
            SuspendLayout();
            // 
            // BtnSignIn
            // 
            BtnSignIn.IconChar = IconChar.UserCheck;
            BtnSignIn.IconColor = Color.Black;
            BtnSignIn.IconFont = IconFont.Auto;
            BtnSignIn.IconSize = 32;
            BtnSignIn.Location = new Point(837, 1);
            BtnSignIn.Name = "BtnSignIn";
            BtnSignIn.Size = new Size(140, 50);
            BtnSignIn.TabIndex = 4;
            BtnSignIn.Text = "Sign In";
            BtnSignIn.TextAlign = ContentAlignment.MiddleRight;
            BtnSignIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSignIn.Click += BtnSignIn_Click;
            // 
            // BtnRegister
            // 
            BtnRegister.IconChar = IconChar.UserPlus;
            BtnRegister.IconColor = Color.Black;
            BtnRegister.IconFont = IconFont.Auto;
            BtnRegister.IconSize = 32;
            BtnRegister.Location = new Point(1000, 1);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(140, 50);
            BtnRegister.TabIndex = 5;
            BtnRegister.Text = "Register";
            BtnRegister.TextAlign = ContentAlignment.MiddleRight;
            BtnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRegister.Click += BtnRegister_Click;
            // 
            // BtnUserName
            // 
            BtnUserName.IconChar = IconChar.User;
            BtnUserName.IconColor = Color.Black;
            BtnUserName.IconFont = IconFont.Auto;
            BtnUserName.IconSize = 32;
            BtnUserName.Location = new Point(919, 3);
            BtnUserName.Name = "BtnUserName";
            BtnUserName.Size = new Size(180, 50);
            BtnUserName.TabIndex = 6;
            BtnUserName.Text = "User";
            BtnUserName.TextAlign = ContentAlignment.MiddleRight;
            BtnUserName.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUserName.Visible = false;
            BtnUserName.Click += BtnUserName_Click;
            // 
            // UserMenu
            // 
            UserMenu.ImageScalingSize = new Size(40, 40);
            UserMenu.Items.AddRange(new ToolStripItem[] { UserProfileMenuItem, FavoritesMenuItem, SettingsMenuItem, LogoutMenuItem });
            UserMenu.Name = "UserMenu";
            UserMenu.Size = new Size(187, 188);
            // 
            // UserProfileMenuItem
            // 
            UserProfileMenuItem.IconChar = IconChar.DriversLicense;
            UserProfileMenuItem.IconColor = Color.Black;
            UserProfileMenuItem.IconFont = IconFont.Auto;
            UserProfileMenuItem.Name = "UserProfileMenuItem";
            UserProfileMenuItem.Size = new Size(186, 46);
            UserProfileMenuItem.Text = "User Profile";
            UserProfileMenuItem.Click += Profile_Click;
            // 
            // FavoritesMenuItem
            // 
            FavoritesMenuItem.IconChar = IconChar.Heart;
            FavoritesMenuItem.IconColor = Color.Black;
            FavoritesMenuItem.IconFont = IconFont.Auto;
            FavoritesMenuItem.Name = "FavoritesMenuItem";
            FavoritesMenuItem.Size = new Size(186, 46);
            FavoritesMenuItem.Text = "Favorites";
            FavoritesMenuItem.Click += Favorites_Click;
            // 
            // SettingsMenuItem
            // 
            SettingsMenuItem.IconChar = IconChar.Cog;
            SettingsMenuItem.IconColor = Color.Black;
            SettingsMenuItem.IconFont = IconFont.Auto;
            SettingsMenuItem.Name = "SettingsMenuItem";
            SettingsMenuItem.Size = new Size(186, 46);
            SettingsMenuItem.Text = "Settings";
            SettingsMenuItem.Click += Settings_Click;
            // 
            // LogoutMenuItem
            // 
            LogoutMenuItem.IconChar = IconChar.Reply;
            LogoutMenuItem.IconColor = Color.Black;
            LogoutMenuItem.IconFont = IconFont.Auto;
            LogoutMenuItem.Name = "LogoutMenuItem";
            LogoutMenuItem.Size = new Size(186, 46);
            LogoutMenuItem.Text = "Logout";
            LogoutMenuItem.Click += Logout_Click;
            // 
            // iconBtnHome
            // 
            iconBtnHome.IconChar = IconChar.House;
            iconBtnHome.IconColor = Color.Black;
            iconBtnHome.IconFont = IconFont.Auto;
            iconBtnHome.IconSize = 32;
            iconBtnHome.Location = new Point(16, 1);
            iconBtnHome.Name = "iconBtnHome";
            iconBtnHome.Size = new Size(160, 50);
            iconBtnHome.TabIndex = 1;
            iconBtnHome.Text = "Home";
            iconBtnHome.TextAlign = ContentAlignment.MiddleRight;
            iconBtnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnHome.Click += HomeButton_Click;
            // 
            // iconBtnAllTouristSpots
            // 
            iconBtnAllTouristSpots.IconChar = IconChar.MapMarkerAlt;
            iconBtnAllTouristSpots.IconColor = Color.Black;
            iconBtnAllTouristSpots.IconFont = IconFont.Auto;
            iconBtnAllTouristSpots.IconSize = 32;
            iconBtnAllTouristSpots.Location = new Point(192, 1);
            iconBtnAllTouristSpots.Name = "iconBtnAllTouristSpots";
            iconBtnAllTouristSpots.Size = new Size(200, 50);
            iconBtnAllTouristSpots.TabIndex = 2;
            iconBtnAllTouristSpots.Text = "All Tourist Spots";
            iconBtnAllTouristSpots.TextAlign = ContentAlignment.MiddleRight;
            iconBtnAllTouristSpots.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnAllTouristSpots.Click += AllTouristSpotsButton_Click;
            // 
            // iconBtnMostPopular
            // 
            iconBtnMostPopular.IconChar = IconChar.ThumbsUp;
            iconBtnMostPopular.IconColor = Color.Black;
            iconBtnMostPopular.IconFont = IconFont.Auto;
            iconBtnMostPopular.IconSize = 32;
            iconBtnMostPopular.Location = new Point(410, 3);
            iconBtnMostPopular.Name = "iconBtnMostPopular";
            iconBtnMostPopular.Size = new Size(180, 50);
            iconBtnMostPopular.TabIndex = 3;
            iconBtnMostPopular.Text = "Most Popular";
            iconBtnMostPopular.TextAlign = ContentAlignment.MiddleRight;
            iconBtnMostPopular.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconBtnMostPopular.Click += MostPopularButton_Click;
            // 
            // NavigationBar
            // 
            Controls.Add(iconBtnHome);
            Controls.Add(iconBtnAllTouristSpots);
            Controls.Add(iconBtnMostPopular);
            Controls.Add(BtnSignIn);
            Controls.Add(BtnRegister);
            Controls.Add(BtnUserName);
            Name = "NavigationBar";
            Size = new Size(1220, 54);
            UserMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}
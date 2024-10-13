using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PlanningApp
{
    partial class Logo
    {
        private System.ComponentModel.IContainer components = null;

        private Button LogoButton;

        private Button LoginButton;
        private Button RegisterButton;
        private Button MyItinerarylinkButton;


        private Button HomeButton;
        private Button DestinationButton;
        private Button ActivitiesButton;
        private Button ScheduleButton;
        private Button FavoritesButton;
        private TextBox SearchTextBox;
        private Button SearchButton;

        private Label PopularDestinationsPanel;
        private Button PopularDestinationsPanel0;
        private Button PopularDestinationsPanel1;
        private Button PopularDestinationsPanel2;
        private Button PopularDestinationsPanel3;


        private Label WeatherLabel;
        private Label WeatherLabelCity1;
        private Label WeatherLabelCity2;

        private Label FooterLabel;

        private Panel HorizontalLinePanel0;
        private Panel HorizontalLinePanel1;
        private Panel HorizontalLinePanel2;
        private Panel HorizontalLinePanel3;
        private Panel HorizontalLinePanel4;
        private Panel HorizontalLinePanel5;

        private Panel VerticalLinePanel0;
        private Panel VerticalLinePanel1;

        private void Button_Click_login(object sender, EventArgs e)
        {
            // 创建目标表单的实例
            Login destinationForm = new Login();

            // 显示新的表单
            destinationForm.Show();

            // 隐藏当前的主表单（可选）
            //this.Hide();
        }

        private void Button_Click_register(object sender, EventArgs e)
        {
            // 创建目标表单的实例
            RegisterForm destinationForm = new RegisterForm();

            // 显示新的表单
            destinationForm.Show();

            // 隐藏当前的主表单（可选）
            //this.Hide();
        }


        private void HomeButton_MouseClick(object sender, EventArgs e)
        {
            // 判断 e 是否是 MouseEventArgs 类型
            if (e is MouseEventArgs mouseArgs)
            {
                string message = $"Mouse button: {mouseArgs.Button}\n" +
                                 $"Click count: {mouseArgs.Clicks}\n" +
                                 $"Mouse position: {mouseArgs.Location}";

                // 弹窗显示信息
                MessageBox.Show(message, "Mouse Click Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("EventArgs is not a MouseEventArgs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            LogoButton = new Button();

            LoginButton = new Button();
            RegisterButton = new Button();
            MyItinerarylinkButton = new Button();

            HomeButton = new Button();
            DestinationButton = new Button();
            ActivitiesButton = new Button();
            ScheduleButton = new Button();
            FavoritesButton = new Button();

            SearchTextBox = new TextBox();
            SearchButton = new Button();

            PopularDestinationsPanel = new Label();

            PopularDestinationsPanel0 = new Button();
            PopularDestinationsPanel1 = new Button();
            PopularDestinationsPanel2 = new Button();
            PopularDestinationsPanel3 = new Button();

            WeatherLabel = new Label();
            WeatherLabelCity1 = new Label();
            WeatherLabelCity2 = new Label();

            FooterLabel = new Label();

            HorizontalLinePanel0 = new Panel();
            HorizontalLinePanel1 = new Panel();
            HorizontalLinePanel2 = new Panel();
            HorizontalLinePanel3 = new Panel();
            HorizontalLinePanel4 = new Panel();
            HorizontalLinePanel5 = new Panel();

            VerticalLinePanel0 = new Panel();
            VerticalLinePanel1 = new Panel();

            //SuspendLayout();

            // 横线设置
            HorizontalLinePanel0.Location = new System.Drawing.Point(0, 0);
            HorizontalLinePanel0.Size = new System.Drawing.Size(1300, 3);  // 宽度560像素，高度1像素
            HorizontalLinePanel0.BackColor = System.Drawing.Color.Black;  // 设置颜色为黑色



            // LogoButton
            LogoButton.Location = new System.Drawing.Point(550, 10);
            LogoButton.Name = "LogoButton";
            LogoButton.Size = new System.Drawing.Size(200, 50);
            LogoButton.Text = "Logo";
            LogoButton.UseVisualStyleBackColor = true;

            LoginButton.Location = new System.Drawing.Point(200, 70);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(200, 50);
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;

            RegisterButton.Location = new System.Drawing.Point(550, 70);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new System.Drawing.Size(200, 50);
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;

            MyItinerarylinkButton.Location = new System.Drawing.Point(900, 70);
            MyItinerarylinkButton.Name = "MyItinerarylinkButton";
            MyItinerarylinkButton.Size = new System.Drawing.Size(200, 50);
            MyItinerarylinkButton.Text = "MyItinerarylink";
            MyItinerarylinkButton.UseVisualStyleBackColor = true;


            // HomeButton
            HomeButton.Location = new System.Drawing.Point(10, 130);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new System.Drawing.Size(200, 50);
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;

            // DestinationButton
            DestinationButton.Location = new System.Drawing.Point(260, 130);
            DestinationButton.Name = "DestinationButton";
            DestinationButton.Size = new System.Drawing.Size(200, 50);
            DestinationButton.Text = "Destinations";
            DestinationButton.UseVisualStyleBackColor = true;

            // Activities
            ActivitiesButton.Location = new System.Drawing.Point(510, 130);
            ActivitiesButton.Name = "ActivitiesButton";
            ActivitiesButton.Size = new System.Drawing.Size(200, 50);
            ActivitiesButton.Text = "Activities";
            ActivitiesButton.UseVisualStyleBackColor = true;

            // Schedule
            ScheduleButton.Location = new System.Drawing.Point(760, 130);
            ScheduleButton.Name = "ScheduleButton";
            ScheduleButton.Size = new System.Drawing.Size(200, 50);
            ScheduleButton.Text = "Schedule";
            ScheduleButton.UseVisualStyleBackColor = true;


            // Favorites
            FavoritesButton.Location = new System.Drawing.Point(1010, 130);
            FavoritesButton.Name = "FavoritesButton";
            FavoritesButton.Size = new System.Drawing.Size(200, 50);
            FavoritesButton.Text = "Favorites";
            FavoritesButton.UseVisualStyleBackColor = true;

            // 横线设置
            HorizontalLinePanel1.Location = new System.Drawing.Point(0, 190);
            HorizontalLinePanel1.Size = new System.Drawing.Size(1300, 3);  // 宽度560像素，高度1像素
            HorizontalLinePanel1.BackColor = System.Drawing.Color.Black;  // 设置颜色为黑色



            //// SearchTextBox
            SearchTextBox.Location = new System.Drawing.Point(10, 215);
            SearchTextBox.Size = new System.Drawing.Size(880, 50);

            //// SearchButton
            SearchButton.Location = new System.Drawing.Point(900, 210);
            SearchButton.Size = new System.Drawing.Size(200, 50);
            SearchButton.Text = "Search";


            // 横线设置
            HorizontalLinePanel2.Location = new System.Drawing.Point(0, 270);
            HorizontalLinePanel2.Size = new System.Drawing.Size(1300, 3);  // 宽度560像素，高度1像素
            HorizontalLinePanel2.BackColor = System.Drawing.Color.Black;  // 设置颜色为黑色


            //// PopularDestinationsPanel
            PopularDestinationsPanel.Location = new System.Drawing.Point(500, 290);
            PopularDestinationsPanel.Size = new System.Drawing.Size(600, 50);
            PopularDestinationsPanel.Text = "Popular destinations (card display)";

            PopularDestinationsPanel0.Location = new System.Drawing.Point(150, 350);
            PopularDestinationsPanel0.Name = "PopularDestinationsPanel0";
            PopularDestinationsPanel0.Size = new System.Drawing.Size(500, 100);
            PopularDestinationsPanel0.Text = "PopularDestinations1";
            PopularDestinationsPanel0.UseVisualStyleBackColor = true;

            PopularDestinationsPanel1.Location = new System.Drawing.Point(700, 350);
            PopularDestinationsPanel1.Name = "PopularDestinationsPanel1";
            PopularDestinationsPanel1.Size = new System.Drawing.Size(500, 100);
            PopularDestinationsPanel1.Text = "PopularDestinations2";
            PopularDestinationsPanel1.UseVisualStyleBackColor = true;

            PopularDestinationsPanel2.Location = new System.Drawing.Point(150, 460);
            PopularDestinationsPanel2.Name = "PopularDestinationsPanel2";
            PopularDestinationsPanel2.Size = new System.Drawing.Size(500, 100);
            PopularDestinationsPanel2.Text = "PopularDestinations3";
            PopularDestinationsPanel2.UseVisualStyleBackColor = true;

            PopularDestinationsPanel3.Location = new System.Drawing.Point(700, 460);
            PopularDestinationsPanel3.Name = "PopularDestinationsPanel3";
            PopularDestinationsPanel3.Size = new System.Drawing.Size(500, 100);
            PopularDestinationsPanel3.Text = "PopularDestinations4";
            PopularDestinationsPanel3.UseVisualStyleBackColor = true;

            // 横线设置
            HorizontalLinePanel3.Location = new System.Drawing.Point(0, 570);
            HorizontalLinePanel3.Size = new System.Drawing.Size(1300, 3);  // 宽度560像素，高度1像素
            HorizontalLinePanel3.BackColor = System.Drawing.Color.Black;  // 设置颜色为黑色

            //// Weather Information
            WeatherLabel.Location = new System.Drawing.Point(550, 580);
            WeatherLabel.Size = new System.Drawing.Size(600, 50);
            WeatherLabel.Text = "Weather Information";

            WeatherLabelCity1.Location = new System.Drawing.Point(550, 640);
            WeatherLabelCity1.Size = new System.Drawing.Size(600, 50);
            WeatherLabelCity1.Text = "[City1:]";

            WeatherLabelCity2.Location = new System.Drawing.Point(550, 700);
            WeatherLabelCity2.Size = new System.Drawing.Size(600, 50);
            WeatherLabelCity2.Text = "[City2:]";

            // 横线设置
            HorizontalLinePanel4.Location = new System.Drawing.Point(0, 760);
            HorizontalLinePanel4.Size = new System.Drawing.Size(1300, 3);  // 宽度560像素，高度1像素
            HorizontalLinePanel4.BackColor = System.Drawing.Color.Black;  // 设置颜色为黑色

            // FooterLabel
            FooterLabel.Location = new System.Drawing.Point(500, 770);
            FooterLabel.Size = new System.Drawing.Size(800, 50);
            FooterLabel.Text = "Contact Us     |     Privacy Policy    |     Terms of Use";

            // 横线设置
            HorizontalLinePanel5.Location = new System.Drawing.Point(0, 850);
            HorizontalLinePanel5.Size = new System.Drawing.Size(1300, 3);  // 宽度560像素，高度1像素
            HorizontalLinePanel5.BackColor = System.Drawing.Color.Black;  // 设置颜色为黑色



            VerticalLinePanel0.Location = new System.Drawing.Point(5, 0);  // X 位置为100，Y 位置为10
            VerticalLinePanel0.Size = new System.Drawing.Size(3, 850);  // 宽度为3像素，高度为400像素
            VerticalLinePanel0.BackColor = System.Drawing.Color.Black;  // 设置颜色为黑色

            VerticalLinePanel1.Location = new System.Drawing.Point(1294, 0);  // X 位置为100，Y 位置为10
            VerticalLinePanel1.Size = new System.Drawing.Size(3, 850);  // 宽度为3像素，高度为400像素
            VerticalLinePanel1.BackColor = System.Drawing.Color.Black;  // 设置颜色为黑色



            this.LoginButton.Click += new System.EventHandler(this.Button_Click_login);
            this.RegisterButton.Click += new System.EventHandler(this.Button_Click_register);

            // Logo Button Click event
            this.LogoButton.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // My Itinerary Link Button Click event
            this.MyItinerarylinkButton.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Home Button Click event
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Destination Button Click event
            this.DestinationButton.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Activities Button Click event
            this.ActivitiesButton.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Schedule Button Click event
            this.ScheduleButton.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Favorites Button Click event
            this.FavoritesButton.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Search Button Click event
            this.SearchButton.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Popular Destinations Panel0 Click event
            this.PopularDestinationsPanel0.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Popular Destinations Panel1 Click event
            this.PopularDestinationsPanel1.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Popular Destinations Panel2 Click event
            this.PopularDestinationsPanel2.Click += new System.EventHandler(this.HomeButton_MouseClick);

            // Popular Destinations Panel3 Click event
            this.PopularDestinationsPanel3.Click += new System.EventHandler(this.HomeButton_MouseClick);



            // MainForm settings
            ClientSize = new System.Drawing.Size(1300, 860);
            
            Controls.Add(LogoButton);

            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
            Controls.Add(MyItinerarylinkButton);

            Controls.Add(HomeButton);
            Controls.Add(DestinationButton);
            Controls.Add(ActivitiesButton);
            Controls.Add(ScheduleButton);
            Controls.Add(FavoritesButton);

            Controls.Add(SearchTextBox);
            Controls.Add(SearchButton);

            Controls.Add(PopularDestinationsPanel);
            Controls.Add(PopularDestinationsPanel0);
            Controls.Add(PopularDestinationsPanel1);
            Controls.Add(PopularDestinationsPanel2);
            Controls.Add(PopularDestinationsPanel3);

            Controls.Add(WeatherLabel);
            Controls.Add(WeatherLabelCity1);
            Controls.Add(WeatherLabelCity2);

            Controls.Add(FooterLabel);

            Controls.Add(HorizontalLinePanel0);
            Controls.Add(HorizontalLinePanel1);
            Controls.Add(HorizontalLinePanel2);
            Controls.Add(HorizontalLinePanel3);
            Controls.Add(HorizontalLinePanel4);
            Controls.Add(HorizontalLinePanel5);

            Controls.Add(VerticalLinePanel0);
            Controls.Add(VerticalLinePanel1);

            Name = "MainForm";
            Text = "Travel Planner";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

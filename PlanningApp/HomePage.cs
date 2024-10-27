using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace PlanningApp
{
    public partial class HomePage : Form
    {
        private readonly AppDbContext _context;
        private TouristSpot[] _touristSpots;

        public HomePage(AppDbContext context)
        {
            _context = context;  // 将数据库上下文传递到本类中
            InitializeComponent();
            LoadImagesFromDatabase();  // 加载图片的方法
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void LoadImagesFromDatabase()
        {
            try
            {
                _touristSpots = _context.TouristSpots
                    .Where(t => t.Id >= 1 && t.Id <= 4)
                    .OrderBy(t => t.Id)
                    .ToArray();

                if (_touristSpots.Length >= 1)
                    SetPictureBoxImage(pictureBox1, _touristSpots[0].ImagePath);

                if (_touristSpots.Length >= 2)
                    SetPictureBoxImage(pictureBox2, _touristSpots[1].ImagePath);

                if (_touristSpots.Length >= 3)
                    SetPictureBoxImage(pictureBox3, _touristSpots[2].ImagePath);

                if (_touristSpots.Length >= 4)
                    SetPictureBoxImage(pictureBox4, _touristSpots[3].ImagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}");
            }
        }

        private void SetPictureBoxImage(PictureBox pictureBox, string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void LoadUserContent(User user)
        {
            if (user is Customer)
            {
                navigationBar1.SetUserLoggedIn(user.UserAccount, user.Nickname);  // 显示用户的昵称
            }
            else if (user is Staff)
            {
                StaffPage staffPage = new StaffPage(_context);
                staffPage.ShowDialog();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowTouristSpotDetails(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowTouristSpotDetails(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowTouristSpotDetails(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowTouristSpotDetails(3);
        }

        private void ShowTouristSpotDetails(int index)
        {
            if (index >= 0 && index < _touristSpots.Length)
            {
                var touristSpot = _touristSpots[index];
                // 传递 _context 和 touristSpot 给 TouristSpotDetailsForm
                var detailsForm = new TouristSpotDetailsForm(_context, touristSpot);
                detailsForm.ShowDialog();  // 弹出详情窗口
            }
        }

        private void navigationBar1_Load(object sender, EventArgs e)
        {

        }
    }
}
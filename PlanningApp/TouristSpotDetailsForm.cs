using System;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class TouristSpotDetailsForm : Form
    {
        private TouristSpot _touristSpot;
        private bool isLiked = false;  // 用于跟踪是否已点赞

        public TouristSpotDetailsForm(TouristSpot touristSpot)
        {
            _touristSpot = touristSpot;
            InitializeComponent();
            LoadTouristSpotDetails();
        }

        private void LoadTouristSpotDetails()
        {
            lblName.Text = _touristSpot.Name;
            lblLocation.Text = $"Location: {_touristSpot.Location}";
            lblRating.Text = $"Rating: {_touristSpot.Rating}/5";
            lblDescription.Text = _touristSpot.Description;

            // 加载图片
            if (!string.IsNullOrEmpty(_touristSpot.ImagePath) && System.IO.File.Exists(_touristSpot.ImagePath))
            {
                pictureBox.Image = Image.FromFile(_touristSpot.ImagePath);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;  // 设置为Zoom，确保图片不变形
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isLiked)
            {
                button1.Text = "Like";
            }
            else
            {
                button1.Text = "Unlike";
            }
            isLiked = !isLiked; 
        }
    }
}

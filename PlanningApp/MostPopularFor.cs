using System;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class MostPopularForm : Form
    {
        private readonly AppDbContext _context;

        public MostPopularForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;

            LoadMostPopularTouristSpot();
        }

        private void LoadMostPopularTouristSpot()
        {
            var mostPopularSpot = _context.TouristSpots
                .OrderByDescending(t => t.PopularityCount)
                .FirstOrDefault();

            if (mostPopularSpot != null)
            {
                lblName.Text = mostPopularSpot.Name;
                lblDescription.Text = mostPopularSpot.Description;
                lblLocation.Text = mostPopularSpot.Location;
                lblRating.Text = $"Rating: {mostPopularSpot.Rating}/5";

                if (!string.IsNullOrEmpty(mostPopularSpot.ImagePath) && System.IO.File.Exists(mostPopularSpot.ImagePath))
                {
                    pictureBox.Image = Image.FromFile(mostPopularSpot.ImagePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("Image not found.");
                }
            }
            else
            {
                MessageBox.Show("No popular tourist spot found.");
            }
        }
    }
}

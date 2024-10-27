using System;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class MostPopularForm : Form
    {
        private readonly AppDbContext _context;  // Database context for interacting with the database

        // Constructor that accepts a database context and initializes the form
        public MostPopularForm(AppDbContext context)
        {
            InitializeComponent();  // Initialize the form components
            _context = context;  // Store the database context in a private field

            LoadMostPopularTouristSpot();  
        }

        // Method to load the most popular tourist spot from the database
        private void LoadMostPopularTouristSpot()
        {
            // Retrieve the most popular tourist spot based on the popularity count
            var mostPopularSpot = _context.TouristSpots
                .OrderByDescending(t => t.PopularityCount)  // Order by popularity in descending order
                .FirstOrDefault();  // Get the first (most popular) tourist spot

            // Check if a popular spot was found
            if (mostPopularSpot != null)
            {
                // Set the labels to display the tourist spot's information
                lblName.Text = mostPopularSpot.Name; 
                lblDescription.Text = mostPopularSpot.Description;  
                lblLocation.Text = mostPopularSpot.Location;  
                lblRating.Text = $"Rating: {mostPopularSpot.Rating}/5";  

                // Check if the image path is valid and the file exists
                if (!string.IsNullOrEmpty(mostPopularSpot.ImagePath) && System.IO.File.Exists(mostPopularSpot.ImagePath))
                {
                    pictureBox.Image = Image.FromFile(mostPopularSpot.ImagePath);  // Load the image from file
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;  // Set the size mode to zoom
                }
                else
                {
                    // Show an error message if the image file is not found
                    MessageBox.Show("Image not found.");
                }
            }
            else
            {
                // Show an error message if no popular tourist spot was found
                MessageBox.Show("No popular tourist spot found.");
            }
        }
    }
}


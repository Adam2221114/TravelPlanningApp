using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace PlanningApp
{
    public partial class HomePage : Form
    {
        private readonly AppDbContext _context;  // Database context for interacting with the database
        private TouristSpot[] _touristSpots;      // Array to hold tourist spots

        // Constructor that accepts a database context and initializes components
        public HomePage(AppDbContext context)
        {
            _context = context;  // Store the database context in a private field
            InitializeComponent();  // Initialize the form components
            LoadImagesFromDatabase();  // Load images from the database on form load
        }

        // Event handler for when the form loads
        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        // Method to load images from the database
        private void LoadImagesFromDatabase()
        {
            try
            {
                // Retrieve tourist spots from the database where Id is between 1 and 4, ordered by Id
                _touristSpots = _context.TouristSpots
                    .Where(t => t.Id >= 1 && t.Id <= 4)
                    .OrderBy(t => t.Id)
                    .ToArray();

                // Set images in picture boxes based on the number of tourist spots retrieved
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
                // Display an error message if there is an exception
                MessageBox.Show($"Error loading images: {ex.Message}");
            }
        }

        // Method to set the image of a picture box from a file path
        private void SetPictureBoxImage(PictureBox pictureBox, string imagePath)
        {
            // Check if the image path is not null or empty and the file exists
            if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);  // Load the image from file
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;  // Set the size mode to stretch
            }
        }

        // Method to load user-specific content
        public void LoadUserContent(User user)
        {
            // Check if the user is a Customer
            if (user is Customer)
            {
                navigationBar1.SetUserLoggedIn(user.UserAccount, user.Nickname);  // Display the user's nickname
            }
            // Check if the user is Staff
            else if (user is Staff)
            {
                StaffPage staffPage = new StaffPage(_context);  // Create a new staff page
                staffPage.ShowDialog();  // Show the staff page as a dialog
            }
        }

        // Event handler for clicking on pictureBox1
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowTouristSpotDetails(0);  // Show details for the first tourist spot
        }

        // Event handler for clicking on pictureBox2
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowTouristSpotDetails(1);  // Show details for the second tourist spot
        }

        // Event handler for clicking on pictureBox3
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowTouristSpotDetails(2);  // Show details for the third tourist spot
        }

        // Event handler for clicking on pictureBox4
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowTouristSpotDetails(3);  // Show details for the fourth tourist spot
        }

        // Method to show details of a selected tourist spot
        private void ShowTouristSpotDetails(int index)
        {
            // Check if the index is within the bounds of the tourist spots array
            if (index >= 0 && index < _touristSpots.Length)
            {
                var touristSpot = _touristSpots[index];  // Get the selected tourist spot
                // Pass the context and touristSpot to the details form
                var detailsForm = new TouristSpotDetailsForm(_context, touristSpot);
                detailsForm.ShowDialog();  // Show the details form as a dialog
            }
        }

        // Event handler for when the navigation bar loads
        private void navigationBar1_Load(object sender, EventArgs e)
        {
        }
    }
}

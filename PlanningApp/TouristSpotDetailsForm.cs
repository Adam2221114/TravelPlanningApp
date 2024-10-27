using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class TouristSpotDetailsForm : Form
    {
        private readonly AppDbContext _context;  // Database context for interacting with the database
        private readonly TouristSpot _touristSpot; // Tourist spot information
        private bool isLiked = false;  // Flag to track if the tourist spot is liked
        private string apiUrl = "https://api.weatherbit.io/v2.0/current?key=86fb8e3c32814f16bc290d3f2b653191";
        // Weather API URL

        // Constructor that accepts database context and tourist spot information
        public TouristSpotDetailsForm(AppDbContext context, TouristSpot touristSpot)
        {
            FetchWeatherDataAsync(); // Fetch weather data asynchronously
            _context = context; // Initialize the database context
            _touristSpot = touristSpot;  // Initialize the tourist spot
            InitializeComponent(); // Initialize form components
            LoadTouristSpotDetails(); // Load the details of the tourist spot
        }
       // Asynchronous method to fetch weather data from the API
       private async Task FetchWeatherDataAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // Make the API request and get the response
                    HttpResponseMessage response = await client.GetAsync(apiUrl + "&country=AU&city=Sydney");

                    // Ensure the request was successful
                    response.EnsureSuccessStatusCode();

                    // Read the response content as a string
                    string responseBody = await response.Content.ReadAsStringAsync();

                    // Parse JSON manually using JsonDocument
                    using (JsonDocument jsonDoc = JsonDocument.Parse(responseBody))
                    {
                        JsonElement root = jsonDoc.RootElement;

                        // Access the first object in the "data" array
                        JsonElement data = root.GetProperty("data")[0];

                        // Extract app_temp and weather.description
                        double appTemp = data.GetProperty("app_temp").GetDouble();
                        string weatherDescription = data.GetProperty("weather").GetProperty("description").GetString();

                        // Update the weather label with temperature and description
                        weatherLabel.Text = appTemp + "C " + weatherDescription;
                    }
                }
                catch (HttpRequestException e)
                { 
                    // Log any request errors to the console
                    Console.WriteLine("Request error: " + e.Message);
                }
            }
        }

        // Method to load details of the tourist spot
        private void LoadTouristSpotDetails()
        {

            // Set labels to display the tourist spot's information
            lblName.Text = _touristSpot.Name;
            lblLocation.Text = $"Location: {_touristSpot.Location}";
            lblRating.Text = $"Rating: {_touristSpot.Rating}/5";
            lblDescription.Text = _touristSpot.Description;

            // Load the image from the specified path
            if (!string.IsNullOrEmpty(_touristSpot.ImagePath) && System.IO.File.Exists(_touristSpot.ImagePath))
            {
                pictureBox.Image = Image.FromFile(_touristSpot.ImagePath);// Load the image from file
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom; // Set size mode to Zoom to avoid distortion
            }

            // Check if the user has favorited this tourist spot
            if (UserSession.Instance.CurrentUser is Customer customer)
            {
                var favoriteList = customer.Favorites?.Split(',').ToList() ?? new List<string>(); // Get the user's favorites
                isLiked = favoriteList.Contains(_touristSpot.Id.ToString()); // Check if the current tourist spot is liked
                button1.Text = isLiked ? "❤️ Unlike" : "❤️ Like";// Update button text based on like status
            }
        }

        // Event handler for the Like/Unlike button click
        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the user is logged in
            if (UserSession.Instance.CurrentUser is Customer customer)
            {
                // Get the user's list of favorite tourist spot IDs
                var favoriteList = customer.Favorites?.Split(',').ToList() ?? new List<string>();

                if (!isLiked)
                {
                    // If not liked, add the tourist spot ID to favorites
                    if (!favoriteList.Contains(_touristSpot.Id.ToString()))
                    {
                        favoriteList.Add(_touristSpot.Id.ToString()); // Add to favorites
                        customer.Favorites = string.Join(",", favoriteList);// Update favorites string


                        // Update the tourist spot's popularity count
                        var touristSpot = _context.TouristSpots.Find(_touristSpot.Id);
                        if (touristSpot != null)
                        {
                            touristSpot.PopularityCount += 1;  // Increase popularity
                        }

                        // Save changes to the database
                        _context.Entry(customer).State = EntityState.Modified;
                        _context.SaveChanges();

                        button1.Text = "❤️ Unlike";// Update button text
                        isLiked = true;// Update like status
                    }
                }
                else
                {
                    // If already liked, remove from favorites
                    if (favoriteList.Contains(_touristSpot.Id.ToString()))
                    {
                        favoriteList.Remove(_touristSpot.Id.ToString()); // Remove from favorites
                        customer.Favorites = string.Join(",", favoriteList);// Update favorites string

                        // Update the tourist spot's popularity count
                        var touristSpot = _context.TouristSpots.Find(_touristSpot.Id);
                        if (touristSpot != null)
                        {
                            touristSpot.PopularityCount -= 1; // Decrease popularity
                        }

                        // Save changes to the database
                        _context.Entry(customer).State = EntityState.Modified;
                        _context.SaveChanges();

                        button1.Text = "❤️ Like";// Update button text
                        isLiked = false;// Update like status
                    }
                }
            }
            else
            {
                // User is not logged in, prompt them to log in
                MessageBox.Show("Please log in to save this attraction！");
            }
        }

    }
}

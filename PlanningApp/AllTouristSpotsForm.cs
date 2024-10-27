using PlanningApp.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class AllTouristSpotsForm : Form, IAllTouristSpotsForm
    {
        private readonly AppDbContext _context; // Database context for accessing tourist spot data
       
        private List<TouristSpot> _touristSpots;// List to hold tourist spot data

        // Constructor that initializes the form and sets up the database context
        public AllTouristSpotsForm(AppDbContext context)
        {
            _context = context;
            _touristSpots = new List<TouristSpot>();// Initialize the list of tourist spots
            InitializeComponent(); // Initialize the form components
            listView1.ItemActivate += ListView1_ItemActivate;// Subscribe to the item activation event
        }

       // Method called when the form loads
       protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);// Call the base class method
            LoadTouristSpots();// Load tourist spots from the database
        }

       // Method to load tourist spots from the database and display them in the ListView
       public void LoadTouristSpots()
        {
            _touristSpots = _context.TouristSpots.ToList();// Fetch all tourist spots from the database

            // Get all but the last three tourist spots to show in the ListView
            var touristSpotsToShow = _touristSpots.Take(_touristSpots.Count - 3).ToList();

            // Loop through the tourist spots to display them in the ListView
            foreach (var spot in touristSpotsToShow)
            {
                var item = new ListViewItem(spot.Name);// Create a new ListViewItem with the spot's name
                item.SubItems.Add(spot.Description);// Add the spot's description
                item.SubItems.Add(spot.Location);
                item.SubItems.Add(spot.Rating.ToString());

                item.Tag = spot;// Store the tourist spot in the item's Tag for later retrieval

                var imagePath = spot.ImagePath;// Get the image path for the tourist spot
                if (System.IO.File.Exists(imagePath))// Check if the image file exists
                {
                    var image = System.Drawing.Image.FromFile(imagePath);// Load the image from the file
                    imageList.Images.Add(image);
                    item.ImageIndex = imageList.Images.Count - 1;
                }

                listView1.Items.Add(item); // Add the item to the ListView
            }
        }

        // Event handler for when an item in the ListView is activated (double-clicked)
        public void ListView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)// Check if any item is selected
            {
                var selectedItem = listView1.SelectedItems[0];// Get the selected item

                var touristSpot = (TouristSpot)selectedItem.Tag;// Retrieve the tourist spot from the item's Tag

                var detailsForm = new TouristSpotDetailsForm(_context, touristSpot);// Create a details form for the selected spot
                detailsForm.ShowDialog();// Show the details form as a dialog
            }
        }
    }
}

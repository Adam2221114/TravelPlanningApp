using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace PlanningApp
{
    public partial class FavoritesForm : Form
    {
        private readonly AppDbContext _context;

        public FavoritesForm(AppDbContext context)//constructor
        {
            _context = context;
            InitializeComponent();
            LoadFavorites();// Method calls
        }

        private void LoadFavorites()
        {
            if (UserSession.Instance.CurrentUser is Customer customer)
            {
                var favoriteIds = customer.Favorites?.Split(',').ToList();//generalized type

                if (favoriteIds != null && favoriteIds.Any())
                {
                    var favoriteSpots = _context.TouristSpots
                        .Where(t => favoriteIds.Contains(t.Id.ToString()))
                        .ToList();
                    //LINQ 

                    listBoxFavorites.DataSource = favoriteSpots;
                    listBoxFavorites.DisplayMember = "Name";
                    listBoxFavorites.ValueMember = "Id";
                }
            }
            else
            {
                MessageBox.Show("Please log in first!");
                var loginForm = new Login(_context) { Owner = this.FindForm() };
                loginForm.ShowDialog();

            }
        }

        private void RemoveFavoriteButton_Click(object sender, EventArgs e)
        {
            if (listBoxFavorites.SelectedItem != null)
            {
                int touristSpotId = (int)listBoxFavorites.SelectedValue;
                RemoveFromFavorites(touristSpotId);
            }
            else
            {
                MessageBox.Show("Please select an attraction first!");
            }
        }

        private void RemoveFromFavorites(int touristSpotId)
        {
            if (UserSession.Instance.CurrentUser is Customer customer)
            {
                var favoriteList = customer.Favorites?.Split(',').ToList();//generalized type

                if (favoriteList != null && favoriteList.Contains(touristSpotId.ToString()))
                {
                    favoriteList.Remove(touristSpotId.ToString());
                    customer.Favorites = string.Join(",", favoriteList);
                    _context.Entry(customer).State = EntityState.Modified;
                    _context.SaveChanges();

                    MessageBox.Show("The attraction has been removed from your favorites!");
                    LoadFavorites();
                }
                else
                {
                    MessageBox.Show("This attraction is not in your favorites!");
                }
            }
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            if (listBoxFavorites.SelectedItem != null)
            {
                var selectedSpot = listBoxFavorites.SelectedItem as TouristSpot;
                if (selectedSpot != null)
                {
                    var detailsForm = new TouristSpotDetailsForm(_context, selectedSpot);
                    detailsForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Please select an attraction first!");
            }
        }

        private void FavoritesForm_Load(object sender, EventArgs e)
        {

        }
    }
}

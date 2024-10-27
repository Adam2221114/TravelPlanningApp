using PlanningApp.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class AllTouristSpotsForm : Form, IAllTouristSpotsForm
    {
        private readonly AppDbContext _context;
        // 泛型
        private List<TouristSpot> _touristSpots;

        public AllTouristSpotsForm(AppDbContext context)
        {
            _context = context;
            _touristSpots = new List<TouristSpot>();
            InitializeComponent();
            listView1.ItemActivate += ListView1_ItemActivate;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadTouristSpots();
        }

        public void LoadTouristSpots()
        {
            _touristSpots = _context.TouristSpots.ToList();

            var touristSpotsToShow = _touristSpots.Take(_touristSpots.Count - 3).ToList();

            foreach (var spot in touristSpotsToShow)
            {
                var item = new ListViewItem(spot.Name);
                item.SubItems.Add(spot.Description);
                item.SubItems.Add(spot.Location);
                item.SubItems.Add(spot.Rating.ToString());

                item.Tag = spot;

                var imagePath = spot.ImagePath;
                if (System.IO.File.Exists(imagePath))
                {
                    var image = System.Drawing.Image.FromFile(imagePath);
                    imageList.Images.Add(image);
                    item.ImageIndex = imageList.Images.Count - 1;
                }

                listView1.Items.Add(item);
            }
        }

        public void ListView1_ItemActivate(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedItem = listView1.SelectedItems[0];

                var touristSpot = (TouristSpot)selectedItem.Tag;

                var detailsForm = new TouristSpotDetailsForm(_context, touristSpot);
                detailsForm.ShowDialog();
            }
        }
    }
}

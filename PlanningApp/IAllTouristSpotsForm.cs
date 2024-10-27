using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Interface definition for managing tourist spots
namespace PlanningApp.Interfaces
{
    public interface IAllTouristSpotsForm
    {
        // Method to load tourist spots
        void LoadTouristSpots();

        // Event handler for when an item in the list view is activated (clicked or selected)
        void ListView1_ItemActivate(object sender, EventArgs e);
    }
}


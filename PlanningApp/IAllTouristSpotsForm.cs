using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 接口
namespace PlanningApp.Interfaces
{
    public interface IAllTouristSpotsForm
    {
        void LoadTouristSpots();
        void ListView1_ItemActivate(object sender, EventArgs e);
    }
}

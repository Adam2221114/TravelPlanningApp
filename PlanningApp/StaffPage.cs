using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanningApp
{
    public partial class StaffPage : Form
    {
        private AppDbContext context;

        public StaffPage(AppDbContext context)
        {
            this.context = context;
            InitializeComponent();
        }
    }
}

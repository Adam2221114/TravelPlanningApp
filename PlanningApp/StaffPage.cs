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
        Dictionary<string, object> dicDgvType = new Dictionary<string, object>();
        private AppDbContext context;

        public StaffPage(AppDbContext context)//constructor
        {
            this.context = context;
            InitializeComponent();
            DgvData.AutoGenerateColumns = false;
            DgvData1.AutoGenerateColumns = false;
        }

        public void PageQuery()
        {

            if (DgvData.DataSource != null)
            {
                this.BindingContext[DgvData.DataSource].SuspendBinding();
            }
            DgvData.DataSource = new List<object>();//generalized type
            DgvData.DataSource = context.Users.ToList();// LINQ
            this.BindingContext[DgvData.DataSource].ResumeBinding();
        }
        public void PageQuery1()
        {

            if (DgvData1.DataSource != null)
            {
                this.BindingContext[DgvData.DataSource].SuspendBinding();
            }
            DgvData1.DataSource = new List<object>();//generalized type
            DgvData1.DataSource = context.TouristSpots.ToList();// LINQ 
            this.BindingContext[DgvData1.DataSource].ResumeBinding();
        }

        private void StaffPage_Load(object sender, EventArgs e)
        {
            PageQuery();
            PageQuery1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DgvData1.Visible = false;
            DgvData.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DgvData1.Visible = true;
            DgvData.Visible = false;
        }

        //private void DgvData1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    if (e.ColumnIndex == 6) // Assuming IsPopular is in the 6th column
        //    {
        //        if (e.Value != null)// First check if e.Value is empty
        //        {
        //            //Checks if e.Value is a boolean
        //            bool boolValue;
        //            if (bool.TryParse(e.Value.ToString(), out boolValue))
        //            {
        //                e.Value = boolValue;
        //            }
        //            else //If not a boolean, check if it is a number
        //            {
        //                int parsedValue;
        //                if (int.TryParse(e.Value.ToString(), out parsedValue))
        //                {
        //                    e.Value = (parsedValue == 1); // 1 means true, others mean false
        //                }
        //                else
        //                { // If it is neither a boolean nor a number, set it to the default value false
        //                    e.Value = false;
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
namespace PlanningApp
{
    partial class HomePage
    {
        private System.ComponentModel.IContainer components = null;
        public NavigationBar navigationBar1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.navigationBar1 = new PlanningApp.NavigationBar(_context);
            this.SuspendLayout();

            // navigationBar1
            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(800, 50);
            this.navigationBar1.TabIndex = 0;

            // HomePage
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.navigationBar1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
        }

        #endregion
    }
}




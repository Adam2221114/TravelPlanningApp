namespace PlanningApp
{
    partial class AllTouristSpotsForm
    {
        private System.ComponentModel.IContainer components = null;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            // ListView
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.TileSize = new System.Drawing.Size(350, 120);
            this.listView1.FullRowSelect = true;
            this.listView1.LargeImageList = this.imageList;
            this.listView1.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.listView1.BorderStyle = BorderStyle.None;
            this.listView1.Dock = DockStyle.Fill;  
            this.listView1.Scrollable = true;      
            this.listView1.MultiSelect = false;   

            // ImageList
            this.imageList.ImageSize = new System.Drawing.Size(100, 100);

            // Header Panel
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 60;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnClose);

            // Title Label
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Text = "Tourist Spots";

            // Close Button
            this.btnClose.Text = "X";
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.Cursor = Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(940, 15);
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Form Layout
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panelHeader);
            this.Text = "All Tourist Spots";
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.AllTouristSpotsForm_Resize);
        }

        // Dynamically resize ListView when window is resized
        private void AllTouristSpotsForm_Resize(object sender, System.EventArgs e)
        {
            listView1.Width = this.ClientSize.Width;
            listView1.Height = this.ClientSize.Height - panelHeader.Height;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}

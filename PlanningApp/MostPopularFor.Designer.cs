namespace PlanningApp
{
    partial class MostPopularForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private Label lblLocation;
        private Label lblRating;
        private Label lblDescription;
        private PictureBox pictureBox;
        private Panel panelHeader;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblName = new Label();
            lblLocation = new Label();
            lblRating = new Label();
            lblDescription = new Label();
            pictureBox = new PictureBox();
            panelHeader = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(15, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(0, 39);
            lblName.TabIndex = 0;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Microsoft Sans Serif", 12F);
            lblLocation.ForeColor = Color.FromArgb(60, 60, 60);
            lblLocation.Location = new Point(12, 80);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(0, 25);
            lblLocation.TabIndex = 1;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Microsoft Sans Serif", 12F);
            lblRating.ForeColor = Color.FromArgb(60, 60, 60);
            lblRating.Location = new Point(12, 115);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(0, 25);
            lblRating.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft Sans Serif", 10F);
            lblDescription.ForeColor = Color.FromArgb(80, 80, 80);
            lblDescription.Location = new Point(12, 420);
            lblDescription.MaximumSize = new Size(350, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(0, 20);
            lblDescription.TabIndex = 4;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(30, 139);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(350, 250);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(70, 130, 180);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Controls.Add(lblName);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(426, 60);
            panelHeader.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(350, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // MostPopularForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(426, 600);
            Controls.Add(lblDescription);
            Controls.Add(pictureBox);
            Controls.Add(lblRating);
            Controls.Add(lblLocation);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MostPopularForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Most Popular Tourist Spot";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

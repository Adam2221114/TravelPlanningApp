namespace PlanningApp
{
    partial class TouristSpotDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblName;
        private Label lblLocation;
        private Label lblRating;
        private PictureBox pictureBox;
        private Panel panelDescription;
        private Label lblDescription;
        private Button button1;
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
            pictureBox = new PictureBox();
            panelDescription = new Panel();
            lblDescription = new Label();
            button1 = new Button();
            panelHeader = new Panel();
            weatherLabel = new Label();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelDescription.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(10, 10);
            lblName.MaximumSize = new Size(300, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 17);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Microsoft Sans Serif", 14F);
            lblLocation.ForeColor = Color.Gray;
            lblLocation.Location = new Point(12, 100);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(81, 24);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Microsoft Sans Serif", 14F);
            lblRating.ForeColor = Color.Gray;
            lblRating.Location = new Point(12, 125);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(63, 24);
            lblRating.TabIndex = 2;
            lblRating.Text = "Rating";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(12, 160);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(360, 260);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 6;
            pictureBox.TabStop = false;
            // 
            // panelDescription
            // 
            panelDescription.AutoScroll = true;
            panelDescription.BackColor = Color.FromArgb(245, 245, 245);
            panelDescription.BorderStyle = BorderStyle.FixedSingle;
            panelDescription.Controls.Add(lblDescription);
            panelDescription.Location = new Point(12, 430);
            panelDescription.Name = "panelDescription";
            panelDescription.Size = new Size(360, 150);
            panelDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Microsoft Sans Serif", 12F);
            lblDescription.ForeColor = Color.Gray;
            lblDescription.Location = new Point(5, 5);
            lblDescription.MaximumSize = new Size(330, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 20);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 69, 58);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(150, 590);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 5;
            button1.Text = "❤️ Like";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(70, 130, 180);
            panelHeader.Controls.Add(weatherLabel);
            panelHeader.Controls.Add(lblName);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.ForeColor = Color.White;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(10);
            panelHeader.Size = new Size(400, 100);
            panelHeader.TabIndex = 7;
            // 
            // weatherLabel
            // 
            weatherLabel.AutoSize = true;
            weatherLabel.ForeColor = Color.AliceBlue;
            weatherLabel.Location = new Point(290, 10);
            weatherLabel.Name = "weatherLabel";
            weatherLabel.Size = new Size(0, 17);
            weatherLabel.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.Transparent;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(540, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // TouristSpotDetailsForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(400, 650);
            Controls.Add(button1);
            Controls.Add(panelDescription);
            Controls.Add(pictureBox);
            Controls.Add(lblRating);
            Controls.Add(lblLocation);
            Controls.Add(panelHeader);
            Name = "TouristSpotDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tourist Spot Details";
            Load += TouristSpotDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelDescription.ResumeLayout(false);
            panelDescription.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TouristSpotDetailsForm_Load(object sender, EventArgs e)
        {
            int desiredHeight = lblName.PreferredHeight + 20; 
            panelHeader.Height = desiredHeight > 60 ? desiredHeight : 60; 
        }

        private void TouristSpotDetailsForm_Resize(object sender, EventArgs e)
        {
            panelDescription.Width = this.ClientSize.Width - 40;
            pictureBox.Width = this.ClientSize.Width - 40;
        }

        private Label weatherLabel;
    }
}

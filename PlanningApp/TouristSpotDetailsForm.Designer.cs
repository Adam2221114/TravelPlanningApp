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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panelDescription.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(75, 26);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Microsoft Sans Serif", 12F);
            lblLocation.Location = new Point(12, 50);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(70, 20);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Microsoft Sans Serif", 12F);
            lblRating.Location = new Point(12, 85);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(56, 20);
            lblRating.TabIndex = 2;
            lblRating.Text = "Rating";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(12, 120);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(350, 250);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            // 
            // panelDescription
            // 
            panelDescription.AutoScroll = true;
            panelDescription.BorderStyle = BorderStyle.FixedSingle;
            panelDescription.Controls.Add(lblDescription);
            panelDescription.Location = new Point(12, 380);
            panelDescription.Name = "panelDescription";
            panelDescription.Size = new Size(350, 150);
            panelDescription.TabIndex = 4;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(3, 0);
            lblDescription.MaximumSize = new Size(330, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(74, 17);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            // 
            // button1
            // 
            button1.Location = new Point(139, 536);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "like";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TouristSpotDetailsForm
            // 
            ClientSize = new Size(384, 561);
            Controls.Add(button1);
            Controls.Add(panelDescription);
            Controls.Add(pictureBox);
            Controls.Add(lblRating);
            Controls.Add(lblLocation);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TouristSpotDetailsForm";
            Text = "Tourist Spot Details";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panelDescription.ResumeLayout(false);
            panelDescription.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button button1;
    }
}

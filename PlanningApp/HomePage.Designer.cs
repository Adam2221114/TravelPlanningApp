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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();

            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(79, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 148);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Location = new Point(416, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(257, 148);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaption;
            pictureBox3.Location = new Point(79, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(257, 148);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox4.Location = new Point(416, 266);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(257, 148);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(navigationBar2);
            Name = "HomePage";
            Text = "HomePage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            this.navigationBar1 = new PlanningApp.NavigationBar();
            this.SuspendLayout();

            this.navigationBar1.Location = new System.Drawing.Point(0, 0);
            this.navigationBar1.Name = "navigationBar1";
            this.navigationBar1.Size = new System.Drawing.Size(800, 50);
            this.navigationBar1.TabIndex = 0;

            this.Controls.Add(this.navigationBar1);

            this.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NavigationBar navigationBar2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}




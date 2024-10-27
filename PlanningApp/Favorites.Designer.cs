using FontAwesome.Sharp;

namespace PlanningApp
{
    partial class FavoritesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxFavorites;
        private FontAwesome.Sharp.IconButton buttonViewDetails; // 使用 IconButton 替代普通按钮
        private FontAwesome.Sharp.IconButton buttonRemoveFavorite; // 使用 IconButton 替代普通按钮
        private System.Windows.Forms.Label labelFavorites;

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
            listBoxFavorites = new ListBox();
            buttonViewDetails = new IconButton();
            buttonRemoveFavorite = new IconButton();
            labelFavorites = new Label();
            SuspendLayout();

            // 
            // listBoxFavorites
            // 
            listBoxFavorites.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxFavorites.FormattingEnabled = true;
            listBoxFavorites.ItemHeight = 24;
            listBoxFavorites.Location = new Point(100, 90);
            listBoxFavorites.Name = "listBoxFavorites";
            listBoxFavorites.Size = new Size(700, 460);  // 调整列表框大小
            listBoxFavorites.TabIndex = 1;

            // 
            // buttonViewDetails
            // 
            buttonViewDetails.IconChar = IconChar.CircleInfo;  // 设置 FontAwesome 的图标
            buttonViewDetails.IconColor = Color.Black;
            buttonViewDetails.IconFont = IconFont.Auto;
            buttonViewDetails.Font = new Font("Arial", 14F);  // 设置按钮的字体
            buttonViewDetails.Text = " View Details";
            buttonViewDetails.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonViewDetails.Location = new Point(850, 120);  // 调整按钮位置
            buttonViewDetails.Name = "buttonViewDetails";
            buttonViewDetails.Size = new Size(200, 70);  // 增大按钮尺寸
            buttonViewDetails.TabIndex = 2;
            buttonViewDetails.UseVisualStyleBackColor = true;
            buttonViewDetails.Click += ViewDetailsButton_Click;

            // 
            // buttonRemoveFavorite
            // 
            buttonRemoveFavorite.IconChar = IconChar.TrashAlt;  // 设置 FontAwesome 的图标
            buttonRemoveFavorite.IconColor = Color.Black;
            buttonRemoveFavorite.IconFont = IconFont.Auto;
            buttonRemoveFavorite.Font = new Font("Arial", 14F);  // 设置按钮的字体
            buttonRemoveFavorite.Text = " Remove";
            buttonRemoveFavorite.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonRemoveFavorite.Location = new Point(850, 320);  // 调整按钮位置
            buttonRemoveFavorite.Name = "buttonRemoveFavorite";
            buttonRemoveFavorite.Size = new Size(200, 70);  // 增大按钮尺寸
            buttonRemoveFavorite.TabIndex = 3;
            buttonRemoveFavorite.UseVisualStyleBackColor = true;
            buttonRemoveFavorite.Click += RemoveFavoriteButton_Click;

            // 
            // labelFavorites
            // 
            labelFavorites.AutoSize = true;
            labelFavorites.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelFavorites.Location = new Point(100, 20);
            labelFavorites.Name = "labelFavorites";
            labelFavorites.Size = new Size(132, 29);  // 调整字体大小
            labelFavorites.TabIndex = 0;
            labelFavorites.Text = "My Favorites";

            // 
            // FavoritesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1306, 665);
            Controls.Add(buttonRemoveFavorite);
            Controls.Add(buttonViewDetails);
            Controls.Add(listBoxFavorites);
            Controls.Add(labelFavorites);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FavoritesForm";
            Text = "My Favorites";
            Load += FavoritesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}


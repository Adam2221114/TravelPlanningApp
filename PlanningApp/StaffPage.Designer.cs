namespace PlanningApp
{
    partial class StaffPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            DgvData = new DataGridView();
            button2 = new Button();
            DgvData1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ColIsPopular = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgvData1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(188, 35);
            button1.Name = "button1";
            button1.Size = new Size(194, 78);
            button1.TabIndex = 0;
            button1.Text = "ShowUserInformation";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DgvData
            // 
            DgvData.BackgroundColor = SystemColors.ButtonHighlight;
            DgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvData.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            DgvData.Dock = DockStyle.Bottom;
            DgvData.GridColor = SystemColors.InactiveBorder;
            DgvData.Location = new Point(0, 119);
            DgvData.Name = "DgvData";
            DgvData.Size = new Size(800, 331);
            DgvData.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(422, 35);
            button2.Name = "button2";
            button2.Size = new Size(175, 78);
            button2.TabIndex = 2;
            button2.Text = "ShowAttractionInformation";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DgvData1
            // 
            DgvData1.BackgroundColor = SystemColors.ButtonHighlight;
            DgvData1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvData1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, ColIsPopular });
            DgvData1.GridColor = SystemColors.InactiveBorder;
            DgvData1.Location = new Point(0, 119);
            DgvData1.Name = "DgvData1";
            DgvData1.Size = new Size(800, 331);
            DgvData1.TabIndex = 3;
            DgvData1.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "ImagePath";
            dataGridViewTextBoxColumn3.HeaderText = "ImagePath";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            dataGridViewTextBoxColumn4.HeaderText = "Description";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Location";
            dataGridViewTextBoxColumn5.HeaderText = "Location";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Rating";
            dataGridViewTextBoxColumn6.HeaderText = "Rating";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // ColIsPopular
            // 
            ColIsPopular.DataPropertyName = "PopularityCount";
            ColIsPopular.HeaderText = "PopularityCount";
            ColIsPopular.Name = "ColIsPopular";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "UserId";
            Column1.HeaderText = "UserId";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "UserAccount";
            Column2.HeaderText = "UserAccount";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Password";
            Column3.HeaderText = "Password";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "PhoneNumber";
            Column4.HeaderText = "PhoneNumber";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Email";
            Column5.HeaderText = "Email";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Nickname";
            Column6.HeaderText = "Nickname";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.DataPropertyName = "UserType";
            Column7.HeaderText = "UserType";
            Column7.Name = "Column7";
            Column7.Visible = false;
            // 
            // StaffPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DgvData1);
            Controls.Add(button2);
            Controls.Add(DgvData);
            Controls.Add(button1);
            Name = "StaffPage";
            Text = "Staff Home";
            Load += StaffPage_Load;
            ((System.ComponentModel.ISupportInitialize)DgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgvData1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView DgvData;
        private Button button2;
        private DataGridView DgvData1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn ColIsPopular;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
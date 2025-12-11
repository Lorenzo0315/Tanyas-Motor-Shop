namespace Tanyas_Motor_Shop.Usercontrols
{
    partial class SalesManagementUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Location = new Point(237, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 125);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(460, 123);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 125);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(722, 123);
            panel4.Name = "panel4";
            panel4.Size = new Size(216, 125);
            panel4.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Location = new Point(10, 263);
            panel7.Name = "panel7";
            panel7.Size = new Size(216, 438);
            panel7.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.Controls.Add(dataGridView1);
            panel8.Location = new Point(237, 263);
            panel8.Name = "panel8";
            panel8.Size = new Size(846, 438);
            panel8.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 125);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(223, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // SalesManagementUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = Properties.Resources._11_;
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Name = "SalesManagementUC";
            Size = new Size(1114, 726);
            Load += this.SalesManagement_Load;
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel7;
        private Panel panel8;
        private Panel panel1;
        private DataGridView dataGridView1;
    }
}

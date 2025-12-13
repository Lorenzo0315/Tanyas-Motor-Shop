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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManagementUC));
            panel7 = new Panel();
            panel8 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.Location = new Point(29, 490);
            panel7.Name = "panel7";
            panel7.Size = new Size(371, 438);
            panel7.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.Location = new Point(427, 490);
            panel8.Name = "panel8";
            panel8.Size = new Size(1107, 438);
            panel8.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Location = new Point(29, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 232);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(425, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 232);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(811, 224);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 232);
            panel3.TabIndex = 4;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.Location = new Point(1217, 224);
            panel4.Name = "panel4";
            panel4.Size = new Size(339, 232);
            panel4.TabIndex = 5;
            // 
            // SalesManagementUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Name = "SalesManagementUC";
            Size = new Size(1493, 832);
            Load += SalesManagement_Load;
            ResumeLayout(false);
        }

        #endregion
        private Panel panel7;
        private Panel panel8;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}

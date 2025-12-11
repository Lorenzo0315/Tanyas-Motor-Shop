namespace Tanyas_Motor_Shop.Usercontrols
{
    partial class HomeUC
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
            components = new System.ComponentModel.Container();
            Shopnowbtn = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // Shopnowbtn
            // 
            Shopnowbtn.BackColor = Color.Gray;
            Shopnowbtn.ForeColor = SystemColors.ButtonHighlight;
            Shopnowbtn.Location = new Point(448, 611);
            Shopnowbtn.Name = "Shopnowbtn";
            Shopnowbtn.Size = new Size(203, 53);
            Shopnowbtn.TabIndex = 0;
            Shopnowbtn.Text = "Shop Now!";
            Shopnowbtn.UseVisualStyleBackColor = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // HomeUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = Properties.Resources._1;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Shopnowbtn);
            Name = "HomeUC";
            Size = new Size(1111, 720);
            Load += HomeUC_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Shopnowbtn;
        private ImageList imageList1;
    }
}

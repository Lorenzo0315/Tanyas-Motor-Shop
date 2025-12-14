namespace Tanyas_Motor_Shop.Usercontrols
{
    partial class HomeUC2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeUC2));
            Addstockbtn = new Button();
            SuspendLayout();
            // 
            // Addstockbtn
            // 
            Addstockbtn.AccessibleName = "";
            Addstockbtn.BackgroundImage = (Image)resources.GetObject("Addstockbtn.BackgroundImage");
            Addstockbtn.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Addstockbtn.ForeColor = SystemColors.ButtonFace;
            Addstockbtn.Location = new Point(384, 634);
            Addstockbtn.Margin = new Padding(5);
            Addstockbtn.Name = "Addstockbtn";
            Addstockbtn.Padding = new Padding(1);
            Addstockbtn.Size = new Size(270, 75);
            Addstockbtn.TabIndex = 0;
            Addstockbtn.Text = "ADD STOCK?";
            Addstockbtn.UseVisualStyleBackColor = true;
            // 
            // HomeUC2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.UI_FINAL;
            Controls.Add(Addstockbtn);
            Name = "HomeUC2";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
        }

        #endregion

        private Button Addstockbtn;
    }
}

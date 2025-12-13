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
            button1 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040106;
            button1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(384, 634);
            button1.Name = "button1";
            button1.Size = new Size(270, 75);
            button1.TabIndex = 0;
            button1.Text = "SHOP NOW!";
            button1.UseVisualStyleBackColor = true;
            // 
            // HomeUC2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.UI_FINAL;
            Controls.Add(button1);
            Name = "HomeUC2";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}

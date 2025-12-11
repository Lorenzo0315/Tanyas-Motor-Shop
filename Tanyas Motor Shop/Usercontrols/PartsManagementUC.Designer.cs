namespace Tanyas_Motor_Shop.Usercontrols
{
    partial class PartsManagementUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsManagementUC));
            Searchbtn = new Button();
            Modelcb = new ComboBox();
            Brandcb = new ComboBox();
            SuspendLayout();
            // 
            // Searchbtn
            // 
            Searchbtn.BackColor = SystemColors.ButtonFace;
            Searchbtn.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Searchbtn.Location = new Point(420, 119);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(94, 29);
            Searchbtn.TabIndex = 1;
            Searchbtn.Text = "Search";
            Searchbtn.UseVisualStyleBackColor = false;
            // 
            // Modelcb
            // 
            Modelcb.BackColor = SystemColors.WindowFrame;
            Modelcb.DropDownHeight = 110;
            Modelcb.FormattingEnabled = true;
            Modelcb.IntegralHeight = false;
            Modelcb.Items.AddRange(new object[] { "Yamaha", "Honda\t", "Kawasaki", "Suzuki" });
            Modelcb.Location = new Point(77, 120);
            Modelcb.Name = "Modelcb";
            Modelcb.Size = new Size(159, 28);
            Modelcb.TabIndex = 2;
            // 
            // Brandcb
            // 
            Brandcb.BackColor = Color.DimGray;
            Brandcb.DropDownHeight = 110;
            Brandcb.FormattingEnabled = true;
            Brandcb.IntegralHeight = false;
            Brandcb.Items.AddRange(new object[] { "Yamaha", "Honda\t", "Kawasaki", "Suzuki" });
            Brandcb.Location = new Point(252, 120);
            Brandcb.Name = "Brandcb";
            Brandcb.Size = new Size(151, 28);
            Brandcb.TabIndex = 3;
            // 
            // PartsManagementUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(Brandcb);
            Controls.Add(Modelcb);
            Controls.Add(Searchbtn);
            Name = "PartsManagementUC";
            Size = new Size(1109, 722);
            ResumeLayout(false);
        }

        #endregion
        private Button Searchbtn;
        private ComboBox Modelcb;
        private ComboBox Brandcb;
    }
}

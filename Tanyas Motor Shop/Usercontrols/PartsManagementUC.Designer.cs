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
            Partsdgv = new DataGridView();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Partsdgv).BeginInit();
            SuspendLayout();
            // 
            // Searchbtn
            // 
            Searchbtn.BackColor = SystemColors.ButtonFace;
            Searchbtn.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040107;
            Searchbtn.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Searchbtn.ForeColor = SystemColors.ButtonFace;
            Searchbtn.Location = new Point(1319, 196);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(94, 36);
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
            Modelcb.Location = new Point(919, 199);
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
            Brandcb.Location = new Point(1155, 201);
            Brandcb.Name = "Brandcb";
            Brandcb.Size = new Size(151, 28);
            Brandcb.TabIndex = 3;
            // 
            // Partsdgv
            // 
            Partsdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Partsdgv.GridColor = SystemColors.AppWorkspace;
            Partsdgv.Location = new Point(37, 258);
            Partsdgv.Name = "Partsdgv";
            Partsdgv.RowHeadersWidth = 51;
            Partsdgv.Size = new Size(1456, 743);
            Partsdgv.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(855, 200);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 5;
            label1.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Montserrat SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(1093, 201);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 7;
            label3.Text = "Brand";
            // 
            // PartsManagementUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(Partsdgv);
            Controls.Add(Brandcb);
            Controls.Add(Modelcb);
            Controls.Add(Searchbtn);
            Name = "PartsManagementUC";
            Size = new Size(1493, 832);
            ((System.ComponentModel.ISupportInitialize)Partsdgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Searchbtn;
        private ComboBox Modelcb;
        private ComboBox Brandcb;
        private DataGridView Partsdgv;
        private Label label1;
        private Label label3;
    }
}

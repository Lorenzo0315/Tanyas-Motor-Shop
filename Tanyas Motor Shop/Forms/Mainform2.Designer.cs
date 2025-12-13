namespace Tanyas_Motor_Shop.Forms
{
    partial class Mainform2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform2));
            sidepnl = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button5 = new Button();
            Settingsbtn = new Button();
            Salesbtn = new Button();
            Partsbtn = new Button();
            Homebtn = new Button();
            mainpnl = new Panel();
            Viewbtn = new Button();
            sidepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainpnl.SuspendLayout();
            SuspendLayout();
            // 
            // sidepnl
            // 
            sidepnl.BackColor = SystemColors.InactiveCaptionText;
            sidepnl.Controls.Add(pictureBox1);
            sidepnl.Controls.Add(label1);
            sidepnl.Controls.Add(button5);
            sidepnl.Controls.Add(Settingsbtn);
            sidepnl.Controls.Add(Salesbtn);
            sidepnl.Controls.Add(Partsbtn);
            sidepnl.Controls.Add(Homebtn);
            sidepnl.Dock = DockStyle.Left;
            sidepnl.Location = new Point(0, 0);
            sidepnl.Name = "sidepnl";
            sidepnl.Size = new Size(337, 985);
            sidepnl.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.loho1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 239);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 105);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 5;
            label1.Text = "LOGO";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.AppWorkspace;
            button5.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040105;
            button5.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ButtonFace;
            button5.Location = new Point(1, 896);
            button5.Name = "button5";
            button5.Size = new Size(331, 89);
            button5.TabIndex = 4;
            button5.Text = "Log Out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Settingsbtn
            // 
            Settingsbtn.BackColor = SystemColors.AppWorkspace;
            Settingsbtn.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040104;
            Settingsbtn.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Settingsbtn.ForeColor = SystemColors.ButtonFace;
            Settingsbtn.Location = new Point(2, 521);
            Settingsbtn.Name = "Settingsbtn";
            Settingsbtn.Size = new Size(328, 89);
            Settingsbtn.TabIndex = 3;
            Settingsbtn.Text = "Settings";
            Settingsbtn.UseVisualStyleBackColor = false;
            Settingsbtn.Click += Settingsbtn_Click;
            // 
            // Salesbtn
            // 
            Salesbtn.BackColor = SystemColors.ButtonShadow;
            Salesbtn.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040103;
            Salesbtn.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salesbtn.ForeColor = SystemColors.ButtonFace;
            Salesbtn.Location = new Point(3, 425);
            Salesbtn.Name = "Salesbtn";
            Salesbtn.Size = new Size(326, 89);
            Salesbtn.TabIndex = 2;
            Salesbtn.Text = "Sales Management";
            Salesbtn.UseVisualStyleBackColor = false;
            Salesbtn.Click += Salesbtn_Click;
            // 
            // Partsbtn
            // 
            Partsbtn.BackColor = SystemColors.ButtonShadow;
            Partsbtn.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040102;
            Partsbtn.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Partsbtn.ForeColor = SystemColors.ButtonFace;
            Partsbtn.Location = new Point(3, 331);
            Partsbtn.Name = "Partsbtn";
            Partsbtn.Size = new Size(326, 89);
            Partsbtn.TabIndex = 1;
            Partsbtn.Text = "Parts Management";
            Partsbtn.UseVisualStyleBackColor = false;
            Partsbtn.Click += Partsbtn_Click;
            // 
            // Homebtn
            // 
            Homebtn.BackColor = SystemColors.ButtonShadow;
            Homebtn.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040101;
            Homebtn.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Homebtn.ForeColor = SystemColors.ButtonFace;
            Homebtn.ImageKey = "(none)";
            Homebtn.Location = new Point(5, 237);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(326, 89);
            Homebtn.TabIndex = 1;
            Homebtn.Text = "Home";
            Homebtn.UseVisualStyleBackColor = false;
            Homebtn.Click += Homebtn_Click;
            // 
            // mainpnl
            // 
            mainpnl.BackgroundImage = (Image)resources.GetObject("mainpnl.BackgroundImage");
            mainpnl.BackgroundImageLayout = ImageLayout.Center;
            mainpnl.Controls.Add(Viewbtn);
            mainpnl.Dock = DockStyle.Fill;
            mainpnl.Location = new Point(337, 0);
            mainpnl.Name = "mainpnl";
            mainpnl.Size = new Size(1565, 985);
            mainpnl.TabIndex = 1;
            // 
            // Viewbtn
            // 
            Viewbtn.BackColor = SystemColors.ButtonShadow;
            Viewbtn.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_004010;
            Viewbtn.Font = new Font("Montserrat SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Viewbtn.ForeColor = SystemColors.ButtonFace;
            Viewbtn.Location = new Point(347, 632);
            Viewbtn.Name = "Viewbtn";
            Viewbtn.Padding = new Padding(1);
            Viewbtn.Size = new Size(349, 84);
            Viewbtn.TabIndex = 5;
            Viewbtn.Text = "SHOP NOW!";
            Viewbtn.UseVisualStyleBackColor = false;
            // 
            // Mainform2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1902, 985);
            Controls.Add(mainpnl);
            Controls.Add(sidepnl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mainform2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tanya's Motor Shop";
            WindowState = FormWindowState.Maximized;
            Load += Mainform2_Load;
            sidepnl.ResumeLayout(false);
            sidepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainpnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidepnl;
        private Button Salesbtn;
        private Button Partsbtn;
        private Button Homebtn;
        private Button Settingsbtn;
        private Button button5;
        private Panel mainpnl;
        private Button Viewbtn;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
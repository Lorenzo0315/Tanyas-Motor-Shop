namespace Tanyas_Motor_Shop.Forms
{
    partial class Mainform
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
            Dashboardpnl = new Panel();
            sidebarlogo = new PictureBox();
            Dashboardlbl = new Label();
            Sidebarpnl = new Panel();
            Logoutbtn = new Button();
            spacepnl = new Panel();
            Settingsbtn = new Button();
            Salesbtn = new Button();
            Supplierbtn = new Button();
            Partsbtn = new Button();
            Homebtn = new Button();
            Logopnl = new Panel();
            label1 = new Label();
            mainpnl = new Panel();
            Dashboardpnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sidebarlogo).BeginInit();
            Sidebarpnl.SuspendLayout();
            Logopnl.SuspendLayout();
            SuspendLayout();
            // 
            // Dashboardpnl
            // 
            Dashboardpnl.BackColor = SystemColors.ControlDarkDark;
            Dashboardpnl.Controls.Add(sidebarlogo);
            Dashboardpnl.Controls.Add(Dashboardlbl);
            Dashboardpnl.Dock = DockStyle.Top;
            Dashboardpnl.Location = new Point(0, 0);
            Dashboardpnl.Name = "Dashboardpnl";
            Dashboardpnl.Size = new Size(1329, 99);
            Dashboardpnl.TabIndex = 0;
            // 
            // sidebarlogo
            // 
            sidebarlogo.Location = new Point(19, 34);
            sidebarlogo.Name = "sidebarlogo";
            sidebarlogo.Size = new Size(54, 35);
            sidebarlogo.TabIndex = 1;
            sidebarlogo.TabStop = false;
            // 
            // Dashboardlbl
            // 
            Dashboardlbl.AutoSize = true;
            Dashboardlbl.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashboardlbl.ForeColor = SystemColors.ButtonFace;
            Dashboardlbl.Location = new Point(80, 37);
            Dashboardlbl.Name = "Dashboardlbl";
            Dashboardlbl.Size = new Size(146, 32);
            Dashboardlbl.TabIndex = 0;
            Dashboardlbl.Text = "Dashboard";
            // 
            // Sidebarpnl
            // 
            Sidebarpnl.BackColor = SystemColors.ControlDark;
            Sidebarpnl.Controls.Add(Logoutbtn);
            Sidebarpnl.Controls.Add(spacepnl);
            Sidebarpnl.Controls.Add(Settingsbtn);
            Sidebarpnl.Controls.Add(Salesbtn);
            Sidebarpnl.Controls.Add(Supplierbtn);
            Sidebarpnl.Controls.Add(Partsbtn);
            Sidebarpnl.Controls.Add(Homebtn);
            Sidebarpnl.Controls.Add(Logopnl);
            Sidebarpnl.Dock = DockStyle.Left;
            Sidebarpnl.Location = new Point(0, 99);
            Sidebarpnl.Name = "Sidebarpnl";
            Sidebarpnl.Size = new Size(258, 655);
            Sidebarpnl.TabIndex = 1;
            // 
            // Logoutbtn
            // 
            Logoutbtn.BackColor = SystemColors.ControlDarkDark;
            Logoutbtn.Dock = DockStyle.Top;
            Logoutbtn.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logoutbtn.ForeColor = SystemColors.ButtonFace;
            Logoutbtn.Location = new Point(0, 625);
            Logoutbtn.Name = "Logoutbtn";
            Logoutbtn.Size = new Size(258, 68);
            Logoutbtn.TabIndex = 7;
            Logoutbtn.Text = "Settings";
            Logoutbtn.UseVisualStyleBackColor = false;
            // 
            // spacepnl
            // 
            spacepnl.Dock = DockStyle.Top;
            spacepnl.Location = new Point(0, 441);
            spacepnl.Name = "spacepnl";
            spacepnl.Size = new Size(258, 184);
            spacepnl.TabIndex = 6;
            // 
            // Settingsbtn
            // 
            Settingsbtn.BackColor = SystemColors.ControlDarkDark;
            Settingsbtn.Dock = DockStyle.Top;
            Settingsbtn.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Settingsbtn.ForeColor = SystemColors.ButtonFace;
            Settingsbtn.Location = new Point(0, 373);
            Settingsbtn.Name = "Settingsbtn";
            Settingsbtn.Size = new Size(258, 68);
            Settingsbtn.TabIndex = 5;
            Settingsbtn.Text = "Settings";
            Settingsbtn.UseVisualStyleBackColor = false;
            // 
            // Salesbtn
            // 
            Salesbtn.BackColor = SystemColors.ControlDarkDark;
            Salesbtn.Dock = DockStyle.Top;
            Salesbtn.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Salesbtn.ForeColor = SystemColors.ButtonFace;
            Salesbtn.Location = new Point(0, 305);
            Salesbtn.Name = "Salesbtn";
            Salesbtn.Size = new Size(258, 68);
            Salesbtn.TabIndex = 4;
            Salesbtn.Text = "Sales Management";
            Salesbtn.UseVisualStyleBackColor = false;
            Salesbtn.Click += Salesbtn_Click;
            // 
            // Supplierbtn
            // 
            Supplierbtn.BackColor = SystemColors.ControlDarkDark;
            Supplierbtn.Dock = DockStyle.Top;
            Supplierbtn.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Supplierbtn.ForeColor = SystemColors.ButtonFace;
            Supplierbtn.Location = new Point(0, 237);
            Supplierbtn.Name = "Supplierbtn";
            Supplierbtn.Size = new Size(258, 68);
            Supplierbtn.TabIndex = 3;
            Supplierbtn.Text = "Supplier Management";
            Supplierbtn.UseVisualStyleBackColor = false;
            // 
            // Partsbtn
            // 
            Partsbtn.BackColor = SystemColors.ControlDarkDark;
            Partsbtn.Dock = DockStyle.Top;
            Partsbtn.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Partsbtn.ForeColor = SystemColors.ButtonFace;
            Partsbtn.Location = new Point(0, 169);
            Partsbtn.Name = "Partsbtn";
            Partsbtn.Size = new Size(258, 68);
            Partsbtn.TabIndex = 2;
            Partsbtn.Text = "Parts Management";
            Partsbtn.UseVisualStyleBackColor = false;
            Partsbtn.Click += Partsbtn_Click;
            // 
            // Homebtn
            // 
            Homebtn.BackColor = SystemColors.ControlDarkDark;
            Homebtn.Dock = DockStyle.Top;
            Homebtn.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Homebtn.ForeColor = SystemColors.ButtonFace;
            Homebtn.Location = new Point(0, 101);
            Homebtn.Name = "Homebtn";
            Homebtn.Size = new Size(258, 68);
            Homebtn.TabIndex = 1;
            Homebtn.Text = "Home";
            Homebtn.UseVisualStyleBackColor = false;
            Homebtn.Click += Homebtn_Click;
            // 
            // Logopnl
            // 
            Logopnl.Controls.Add(label1);
            Logopnl.Dock = DockStyle.Top;
            Logopnl.Location = new Point(0, 0);
            Logopnl.Name = "Logopnl";
            Logopnl.Size = new Size(258, 101);
            Logopnl.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 43);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 0;
            label1.Text = "LOGO";
            // 
            // mainpnl
            // 
            mainpnl.Dock = DockStyle.Fill;
            mainpnl.Location = new Point(258, 99);
            mainpnl.Name = "mainpnl";
            mainpnl.Size = new Size(1071, 655);
            mainpnl.TabIndex = 2;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 754);
            Controls.Add(mainpnl);
            Controls.Add(Sidebarpnl);
            Controls.Add(Dashboardpnl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mainform";
            Text = "Tanya's Motor Shop";
            Dashboardpnl.ResumeLayout(false);
            Dashboardpnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sidebarlogo).EndInit();
            Sidebarpnl.ResumeLayout(false);
            Logopnl.ResumeLayout(false);
            Logopnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Dashboardpnl;
        private PictureBox sidebarlogo;
        private Label Dashboardlbl;
        private Panel Sidebarpnl;
        private Panel spacepnl;
        private Button Settingsbtn;
        private Button Salesbtn;
        private Button Supplierbtn;
        private Button Partsbtn;
        private Button Homebtn;
        private Panel Logopnl;
        private Button Logoutbtn;
        private Label label1;
        private Panel mainpnl;
    }
}
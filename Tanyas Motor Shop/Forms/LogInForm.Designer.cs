namespace Tanyas_Motor_Shop.Forms
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            Loginbtn = new Button();
            Usernametb = new TextBox();
            Passwordtb = new TextBox();
            loginlbl = new Label();
            Passwordte = new Label();
            label4 = new Label();
            Showpasscb = new CheckBox();
            SuspendLayout();
            // 
            // Loginbtn
            // 
            Loginbtn.BackColor = SystemColors.ControlDarkDark;
            Loginbtn.Font = new Font("Montserrat Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbtn.Location = new Point(129, 426);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(129, 41);
            Loginbtn.TabIndex = 0;
            Loginbtn.Text = "Login Now";
            Loginbtn.UseVisualStyleBackColor = false;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // Usernametb
            // 
            Usernametb.BackColor = Color.DarkGray;
            Usernametb.BorderStyle = BorderStyle.FixedSingle;
            Usernametb.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Usernametb.Location = new Point(109, 274);
            Usernametb.Multiline = true;
            Usernametb.Name = "Usernametb";
            Usernametb.Size = new Size(172, 34);
            Usernametb.TabIndex = 1;
            Usernametb.TextChanged += Usernametb_TextChanged;
            // 
            // Passwordtb
            // 
            Passwordtb.BackColor = Color.DarkGray;
            Passwordtb.BorderStyle = BorderStyle.FixedSingle;
            Passwordtb.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passwordtb.Location = new Point(108, 342);
            Passwordtb.Multiline = true;
            Passwordtb.Name = "Passwordtb";
            Passwordtb.PasswordChar = '*';
            Passwordtb.Size = new Size(172, 34);
            Passwordtb.TabIndex = 2;
            // 
            // loginlbl
            // 
            loginlbl.AutoSize = true;
            loginlbl.BackColor = Color.Transparent;
            loginlbl.Font = new Font("Montserrat SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginlbl.Location = new Point(150, 202);
            loginlbl.Name = "loginlbl";
            loginlbl.Size = new Size(91, 32);
            loginlbl.TabIndex = 3;
            loginlbl.Text = "LOGIN";
            // 
            // Passwordte
            // 
            Passwordte.AutoSize = true;
            Passwordte.BackColor = Color.Transparent;
            Passwordte.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Passwordte.Location = new Point(150, 315);
            Passwordte.Name = "Passwordte";
            Passwordte.Size = new Size(93, 24);
            Passwordte.TabIndex = 4;
            Passwordte.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(148, 243);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 6;
            label4.Text = "Username";
            // 
            // Showpasscb
            // 
            Showpasscb.AutoSize = true;
            Showpasscb.BackColor = Color.Transparent;
            Showpasscb.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Showpasscb.ForeColor = SystemColors.ButtonFace;
            Showpasscb.Location = new Point(141, 382);
            Showpasscb.Name = "Showpasscb";
            Showpasscb.Size = new Size(148, 25);
            Showpasscb.TabIndex = 8;
            Showpasscb.Text = "Show password";
            Showpasscb.UseVisualStyleBackColor = false;
            Showpasscb.CheckedChanged += Showpasscb_CheckedChanged;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(859, 602);
            Controls.Add(Showpasscb);
            Controls.Add(label4);
            Controls.Add(Passwordte);
            Controls.Add(loginlbl);
            Controls.Add(Passwordtb);
            Controls.Add(Usernametb);
            Controls.Add(Loginbtn);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LogInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Tanya's Motor Shop";
            Load += LogInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Loginbtn;
        private TextBox Usernametb;
        private TextBox Passwordtb;
        private Label loginlbl;
        private Label Passwordte;
        private Label label4;
        private CheckBox Showpasscb;
    }
}
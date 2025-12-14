namespace Tanyas_Motor_Shop.Forms
{
    partial class AddItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            backButton = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 2;
            label1.Text = "Model Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 222);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 21);
            label2.TabIndex = 3;
            label2.Text = "Brand Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 259);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 4;
            label3.Text = "Version";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 304);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 5;
            label4.Text = "Parts ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 350);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 6;
            label5.Text = "Color";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Montserrat", 9F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "CLICK", "AEROX", "RAIDER", "TMX" });
            comboBox2.Location = new Point(222, 216);
            comboBox2.Margin = new Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(185, 29);
            comboBox2.TabIndex = 8;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Montserrat", 9F);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "YAMAHA ", "HONDA", "SUZUKI", "KAWASAKI" });
            comboBox3.Location = new Point(222, 174);
            comboBox3.Margin = new Padding(4, 3, 4, 3);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(188, 29);
            comboBox3.TabIndex = 9;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Montserrat", 9F);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "V1 \t", "V2", "V3" });
            comboBox4.Location = new Point(221, 256);
            comboBox4.Margin = new Padding(4, 3, 4, 3);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(188, 29);
            comboBox4.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 346);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 26);
            textBox1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040108;
            button1.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(354, 442);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(164, 51);
            button1.TabIndex = 12;
            button1.Text = "Add item";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040109;
            button2.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(114, 443);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(205, 50);
            button2.TabIndex = 13;
            button2.Text = "Cancel Item";
            button2.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            backButton.BackgroundImage = Properties.Resources.Screenshot_2025_12_14_0040108;
            backButton.Font = new Font("Montserrat Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backButton.ForeColor = SystemColors.ButtonFace;
            backButton.Location = new Point(15, 13);
            backButton.Margin = new Padding(4, 3, 4, 3);
            backButton.Name = "backButton";
            backButton.Size = new Size(115, 47);
            backButton.TabIndex = 14;
            backButton.Text = "Back ";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(221, 304);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 26);
            textBox2.TabIndex = 15;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(885, 579);
            Controls.Add(textBox2);
            Controls.Add(backButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Montserrat", 9F);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button backButton;
        private TextBox textBox2;
    }
}
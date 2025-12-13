using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanyas_Motor_Shop.Forms
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Usernametb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Showpasscb_CheckedChanged(object sender, EventArgs e)
        {
            if (Showpasscb.Checked)
            {
                Passwordtb.UseSystemPasswordChar = true; // Show password
            }
            else
            {
                Passwordtb.UseSystemPasswordChar = false; // Hide password
            }

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            // Sample username and password (YOU CAN CHANGE THIS)
            string username = Usernametb.Text;
            string password = Passwordtb.Text;

            // Very simple example login (replace with DB login later)
            if (username == "admin" && password == "admin123")
            {
                // Open MainForm
                Mainform2 main = new Mainform2();
                main.Show();

                // Hide current LoginForm
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}



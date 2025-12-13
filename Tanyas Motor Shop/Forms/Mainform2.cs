using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tanyas_Motor_Shop.Usercontrols;

namespace Tanyas_Motor_Shop.Forms
{
    public partial class Mainform2 : Form
    {
        public Mainform2()
        {
            InitializeComponent();

        }

        private void Mainform2_Load(object sender, EventArgs e)
        {

        }

        public void HomeUC2(UserControl uc)
        {
            mainpnl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainpnl.Controls.Add(uc);
            uc.BringToFront();
        }
        private void Homebtn_Click(object sender, EventArgs e)
        {
            HomeUC2 home = new HomeUC2(); // create instance of your Home UserControl
            HomeUC2(home);
        }

        private void Partsbtn_Click(object sender, EventArgs e)
        {
            PartsManagementUC partsUC = new PartsManagementUC(); // create instance of your PartsManagement UserControl
            PartsManagementUC(partsUC);
        }

        public void PartsManagementUC(UserControl uc)
        {
            mainpnl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainpnl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void Salesbtn_Click(object sender, EventArgs e)
        {
            SalesManagementUC salesUC = new SalesManagementUC(); // create instance of your SalesManagement UserControl
            LoadUserControl(salesUC);
        }



        public void LoadUserControl(UserControl uc)
        {
            mainpnl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainpnl.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Are you sure you want to logout?",
               "Confirm Logout",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
   );

            // Conditional check
            if (result == DialogResult.Yes)
            {
                // Hide current Mainform
                this.Hide();

                // Show LoginForm
                LogInForm login = new LogInForm();
                login.Show();

                // Close Mainform when LoginForm is closed
                login.FormClosed += (s, args) => this.Close();
            }
            else
            {
                // Do nothing if user clicks No
            }
        }

        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            SettingsUC salesUC = new SettingsUC(); // create instance of your SalesManagement UserControl
            LoadUserControl(salesUC);
        }

        public void SettingsUC(UserControl uc)
        {
            mainpnl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainpnl.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}

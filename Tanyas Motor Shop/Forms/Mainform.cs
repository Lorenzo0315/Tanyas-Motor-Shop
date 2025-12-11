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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void Homebtn_Click(object sender, EventArgs e, object mainpnl)
        {

        }

        public void HomeUC(UserControl uc)
        {
            mainpnl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainpnl.Controls.Add(uc);
            uc.BringToFront();
        }


        private void Homebtn_Click(object sender, EventArgs e)
        {
            HomeUC home = new HomeUC(); // create instance of your Home UserControl
            HomeUC(home);      // load inside MainForm panel
        }

        public void PartsManagementUC(UserControl uc)
        {
            mainpnl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainpnl.Controls.Add(uc);
            uc.BringToFront();
        }
        private void Partsbtn_Click(object sender, EventArgs e)
        {
            PartsManagementUC partsUC = new PartsManagementUC(); // create instance of your PartsManagement UserControl
            PartsManagementUC(partsUC);                        // load it into the panel
        }

        public void LoadUserControl(UserControl uc)
        {
            mainpnl.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainpnl.Controls.Add(uc);
            uc.BringToFront();
        }
        private void Salesbtn_Click(object sender, EventArgs e)
        {
            SalesManagementUC salesUC = new SalesManagementUC(); // create instance of your SalesManagement UserControl
            LoadUserControl(salesUC);                        // load it into the panel
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanyas_Motor_Shop.Usercontrols
{
    public partial class SalesManagementUC : UserControl
    {
        public SalesManagementUC()
        {
            InitializeComponent();

            this.Load += SalesManagement_Load;
        }

        private void SalesManagement_Load(object sender, EventArgs e)
        {
            // Initialization logic (e.g., populate grids, load data, set defaults)
            // Example:
            // LoadSalesData();
            // salesGrid.DataSource = salesBindingSource;
        }

        // Optional: if you prefer OnLoad, keep it — but you still need the handler
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Additional setup logic if needed
        }


    }
}

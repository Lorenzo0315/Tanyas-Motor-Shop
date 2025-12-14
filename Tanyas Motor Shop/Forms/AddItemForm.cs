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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e) // Kining 'backButton_Click' kinahanglan imong actual method name
        {
            Mainform2 mainForm = new Mainform2();

            // Show the MainForm
            mainForm.Show();

            // Close the current AddItemForm
            this.Close();
        }
    }
}

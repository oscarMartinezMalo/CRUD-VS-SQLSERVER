using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wareHouseReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warehouse newWarehouse = new Warehouse();
            newWarehouse.Show();
        }

        private void wPDTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WPDT wpdtinstance = new WPDT();
            wpdtinstance.Show();
        }


        private void aRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertCustomerRecord name = new InsertCustomerRecord();
            name.Show();
        }
  
    }
}

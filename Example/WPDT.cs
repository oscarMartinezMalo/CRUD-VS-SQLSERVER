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
    public partial class WPDT : Form
    {
        public WPDT()
        {
            InitializeComponent();
        }

        private void wPDTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.wPDTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mastrapaDataSet);

        }

        private void WPDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastrapaDataSet.WPDT' table. You can move, or remove it, as needed.
            this.wPDTTableAdapter.Fill(this.mastrapaDataSet.WPDT);

        }
    }
}

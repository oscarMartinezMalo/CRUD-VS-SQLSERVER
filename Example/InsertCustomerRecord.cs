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
    public partial class InsertCustomerRecord : Form
    {
        public InsertCustomerRecord()
        {
            InitializeComponent();
        }

        private void customerRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerRecordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mastrapaDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastrapaDataSet.CustomerRecord' table. You can move, or remove it, as needed.
            this.customerRecordTableAdapter.Fill(this.mastrapaDataSet.CustomerRecord);

        }
    }
}

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
    public partial class CustomerRecord : Form
    {
        
        string value = "";

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public CustomerRecord()
        {
            InitializeComponent();
        }

        private void customerRecordBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerRecordBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mastrapaDataSet);

        }

        private void CustomerRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastrapaDataSet.CustomerRecord' table. You can move, or remove it, as needed.
            this.customerRecordTableAdapter.Fill(this.mastrapaDataSet.CustomerRecord);

        }

        private void customerRecordDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Value = customerRecordDataGridView.Rows[customerRecordDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            Close();
        }
    }
}

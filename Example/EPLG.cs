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
    public partial class EPLG : Form
    {
        string value="";

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

        public EPLG()
        {
            InitializeComponent();
        }

        private void ePLGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ePLGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mastrapaDataSet);

        }

        private void EPLG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastrapaDataSet.EPLG' table. You can move, or remove it, as needed.
            this.ePLGTableAdapter.Fill(this.mastrapaDataSet.EPLG);

        }

        private void ePLGDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Value = ePLGDataGridView.Rows[ePLGDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            Close();
        }
    }
}

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
    public partial class searchWarehouse : Form
    {
        bool checkboxValue;
        public searchWarehouse(bool checkboxValue)
        {
            this.checkboxValue = checkboxValue;
            InitializeComponent();
        }

        private void warehouseReceiptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.warehouseReceiptBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mastrapaDataSet);

        }

        private void searchWarehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastrapaDataSet.WarehouseReceipt' table. You can move, or remove it, as needed.
            this.warehouseReceiptTableAdapter.Fill(this.mastrapaDataSet.WarehouseReceipt);
            checkBox1.Checked = checkboxValue;
            DataView dv = this.mastrapaDataSet.WarehouseReceipt.DefaultView;
            dv.RowFilter = string.Format("Convert(bonded, 'System.String') = {0}", checkBox1.Checked);
            warehouseReceiptDataGridView.DataSource = dv.ToTable();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text=="")
            //{
            //    DataView dp = this.mastrapaDataSet.WarehouseReceipt.DefaultView;
            //    dp.RowFilter = string.Format("Convert(bonded, 'System.String') = {0}", checkBox1.Checked);
            //    warehouseReceiptDataGridView.DataSource = dp.ToTable();
            //}
            DataView dv = this.mastrapaDataSet.WarehouseReceipt.DefaultView;
            //dv.RowFilter = string.Format("Convert(receiptnumber, 'System.String') LIKE '%{0}%'", textBox1.Text);
            dv.RowFilter = string.Format("Convert(receiptnumber, 'System.String') LIKE '%{0}%' and Convert(bonded, 'System.String') = {1}", textBox1.Text, checkBox1.Checked);
            warehouseReceiptDataGridView.DataSource = dv.ToTable();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DataView dv = this.mastrapaDataSet.WarehouseReceipt.DefaultView;
            dv.RowFilter = string.Format("Convert(bonded, 'System.String') = {0}", checkBox1.Checked);
            warehouseReceiptDataGridView.DataSource = dv.ToTable();
        }
        string value;

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

        public bool CheckboxValueReturn
        {
            get
            {
                return CheckboxValueReturn1;
            }

            set
            {
                CheckboxValueReturn1 = value;
            }
        }

        public bool CheckboxValueReturn1
        {
            get
            {
                return checkboxValueReturn;
            }

            set
            {
                checkboxValueReturn = value;
            }
        }

        public int CurrentSearchRow
        {
            get
            {
                return currentSearchRow;
            }

            set
            {
                currentSearchRow = value;
            }
        }

        bool checkboxValueReturn;
        int currentSearchRow;
        private void warehouseReceiptDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentSearchRow = warehouseReceiptDataGridView.CurrentRow.Index;
            Value = warehouseReceiptDataGridView.Rows[warehouseReceiptDataGridView.CurrentRow.Index].Cells[1].Value.ToString();
            CheckboxValueReturn =(bool) warehouseReceiptDataGridView.Rows[warehouseReceiptDataGridView.CurrentRow.Index].Cells[0].Value;
            Close();
        }
    }
}

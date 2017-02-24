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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void warehouseReceiptBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            if (receiptNumberTextBox.Text == "" || customerCodeTextBox.Text == "" || referenceNumberTextBox.Text == "")
            {
                if (receiptNumberTextBox.Text == "")
                    errorProvider1.SetError(receiptNumberTextBox, "Column 'ReceiptNumber' does not allow nulls.");
                else
                    errorProvider1.SetError(receiptNumberTextBox, null);

                if (customerCodeTextBox.Text == "")
                    errorProvider1.SetError(customerCodeTextBox, "Column 'CustomerCode' does not allow nulls.");
                else
                    errorProvider1.SetError(customerCodeTextBox, null);

                if (referenceNumberTextBox.Text == "")
                    errorProvider1.SetError(referenceNumberTextBox, "Column 'referenceNumber' does not allow nulls.");
                else
                    errorProvider1.SetError(referenceNumberTextBox, null);
            }
            else
            {
                errorProvider1.SetError(referenceNumberTextBox, null);
                errorProvider1.SetError(customerCodeTextBox, null);
                errorProvider1.SetError(receiptNumberTextBox, null);
                this.Validate();
                this.wPDTBindingSource1.EndEdit();
                try
                {
                    this.warehouseReceiptBindingSource.EndEdit();

                    mastrapaDataSet.WPDTDataTable deleted = (mastrapaDataSet.WPDTDataTable)
                        mastrapaDataSet.WPDT.GetChanges(DataRowState.Deleted);

                    mastrapaDataSet.WPDTDataTable newItem = (mastrapaDataSet.WPDTDataTable)
                        mastrapaDataSet.WPDT.GetChanges(DataRowState.Added);

                    mastrapaDataSet.WPDTDataTable modified = (mastrapaDataSet.WPDTDataTable)
                       mastrapaDataSet.WPDT.GetChanges(DataRowState.Modified);
                    try
                    {
                        // Remove all  wpdt from the wpdt table.
                        if (deleted != null)
                        {
                            wPDTTableAdapter.Update(deleted);
                        }

                        // Update the WarehouseReceipt table.
                        warehouseReceiptTableAdapter.Update(mastrapaDataSet.WarehouseReceipt);

                        // Add new wpdt to the wpdt table.
                        if (newItem != null)
                        {
                            wPDTTableAdapter.Update(newItem);
                        }

                        // Update all modified wpdt.
                        if (modified != null)
                        {
                            wPDTTableAdapter.Update(modified);
                        }

                        mastrapaDataSet.AcceptChanges();
                        bondedCheckBox.Enabled = false;
                        receiptNumberTextBox.Enabled = false;
                        bindingNavigatorAddNewItem.Enabled = true;
                    }

                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        if (deleted != null)
                            deleted.Dispose();

                        if (newItem != null)
                            newItem.Dispose();

                        if (modified != null)
                            modified.Dispose();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    string p = exc.Message;
                    // throw;       
                }

            }
        }
        private void Warehouse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mastrapaDataSet.WPDT' table. You can move, or remove it, as needed.
            this.wPDTTableAdapter.Fill(this.mastrapaDataSet.WPDT);
            // TODO: This line of code loads data into the 'mastrapaDataSet.WarehouseReceipt' table. You can move, or remove it, as needed.
            this.warehouseReceiptTableAdapter.Fill(this.mastrapaDataSet.WarehouseReceipt);
            // Filter WPDT
            wPDTBindingSource1.Filter = string.Format("Convert(bonded, 'System.String') = {0} and Convert(receiptnumber, 'System.String') = {1}", bondedCheckBox.Checked, receiptNumberTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerRecord searchCustomerCode = new CustomerRecord();
            searchCustomerCode.ShowDialog();
            customerCodeTextBox.Text = searchCustomerCode.Value;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EPLG searchRefenceNumber = new EPLG();
            searchRefenceNumber.ShowDialog();
            referenceNumberTextBox.Text = searchRefenceNumber.Value;
        }

        private int FindTwoColumns( bool KeyOne, string KeyTwo)
        {
            for (int i = 0; i < warehouseReceiptBindingSource1.Count; i++)
            {
                if ((Convert.ToBoolean(((DataRowView)warehouseReceiptBindingSource1[i]).Row[0])== KeyOne) && (((DataRowView)warehouseReceiptBindingSource1[i]).Row[1].ToString() == KeyTwo))
                {
                    return i;
                }
                
            }
            return -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            searchWarehouse searchware = new searchWarehouse(bondedCheckBox.Checked);
            searchware.ShowDialog();
            if (searchware.Value != null)
                if (searchware.Value != "")
                {
                    // Find the record and goes to that record
                    if (receiptNumberTextBox.Enabled)
                    {

                        int itemFound = FindTwoColumns(searchware.CheckboxValueReturn1, searchware.Value);
                        bondedCheckBox.Checked=Convert.ToBoolean(((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[0]);
                       // receiptNumberTextBox.Text = ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[1].ToString();
                        ddateInDateTimePicker.Text= ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[2].ToString();
                        locationTextBox.Text = ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[3].ToString();
                        purchargeOrderTextBox.Text= ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[4].ToString();
                        destinationTextBox.Text=((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[5].ToString();
                        customerCodeTextBox.Text= ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[6].ToString();
                        referenceNumberTextBox.Text= ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[7].ToString();
                        printedCheckBox.Checked = Convert.ToBoolean(((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[8]);
                        invoiceCheckBox.Checked = Convert.ToBoolean(((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[7]);
                        packingListCheckBox.Checked = Convert.ToBoolean(((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[10]);
                        carrierTextBox.Text = ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[11].ToString();
                        profitNumberTextBox.Text = ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[12].ToString();
                        prepaidCollectTextBox.Text = ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[13].ToString();
                        inlandFreightTextBox.Text = ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[14].ToString();
                        lastBillDateDateTimePicker.Text= ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[15].ToString();
                        billedToDateTextBox.Text = ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[16].ToString();
                        remarkTextBox.Text = ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[17].ToString();
                        marksTextBox.Text = ((DataRowView)warehouseReceiptBindingSource1[itemFound]).Row[18].ToString();                       

                    }
                    else {                        
                        int itemFound = warehouseReceiptBindingSource.Find("receiptnumber", searchware.Value);
                        warehouseReceiptBindingNavigator.BindingSource.Position = FindTwoColumns(searchware.CheckboxValueReturn1, searchware.Value);
                    }
                }
        }


        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            if (receiptNumberTextBox.Text != "")
                wPDTBindingSource1.Filter = string.Format("Convert(bonded, 'System.String') = {0} and Convert(receiptnumber, 'System.String') = {1}", bondedCheckBox.Checked, receiptNumberTextBox.Text);
        }


        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            wPDTBindingSource1.Filter =" bonded= 'False'"+ "and receiptnumber = null";
            bindingNavigatorMovePreviousItem.Enabled = false;
            bindingNavigatorMoveFirstItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
            bondedCheckBox.CheckState=CheckState.Unchecked;
            invoiceCheckBox.CheckState = CheckState.Unchecked;
            packingListCheckBox.CheckState = CheckState.Unchecked;
            bondedCheckBox.Enabled = true;
            receiptNumberTextBox.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            bondedCheckBox.Enabled = false;
            receiptNumberTextBox.Enabled = false;

        }


        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (!bondedCheckBox.Checked)
            {
                dataGridView1.CurrentRow.Cells[0].Value = false;
            }
            else
            dataGridView1.CurrentRow.Cells[0].Value = bondedCheckBox.Checked;
            dataGridView1.CurrentRow.Cells[1].Value = receiptNumberTextBox.Text;
        }

    }
}

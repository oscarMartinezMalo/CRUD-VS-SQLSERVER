namespace Example
{
    partial class WPDT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WPDT));
            System.Windows.Forms.Label bondedLabel;
            System.Windows.Forms.Label receiptNumberLabel;
            System.Windows.Forms.Label lnumberLabel;
            System.Windows.Forms.Label piecesLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label vendorLabel;
            System.Windows.Forms.Label itemCodeLabel;
            this.mastrapaDataSet = new Example.mastrapaDataSet();
            this.wPDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wPDTTableAdapter = new Example.mastrapaDataSetTableAdapters.WPDTTableAdapter();
            this.tableAdapterManager = new Example.mastrapaDataSetTableAdapters.TableAdapterManager();
            this.wPDTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.wPDTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bondedCheckBox = new System.Windows.Forms.CheckBox();
            this.receiptNumberTextBox = new System.Windows.Forms.TextBox();
            this.lnumberTextBox = new System.Windows.Forms.TextBox();
            this.piecesTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.vendorTextBox = new System.Windows.Forms.TextBox();
            this.itemCodeTextBox = new System.Windows.Forms.TextBox();
            bondedLabel = new System.Windows.Forms.Label();
            receiptNumberLabel = new System.Windows.Forms.Label();
            lnumberLabel = new System.Windows.Forms.Label();
            piecesLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            vendorLabel = new System.Windows.Forms.Label();
            itemCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mastrapaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPDTBindingNavigator)).BeginInit();
            this.wPDTBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // mastrapaDataSet
            // 
            this.mastrapaDataSet.DataSetName = "mastrapaDataSet";
            this.mastrapaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wPDTBindingSource
            // 
            this.wPDTBindingSource.DataMember = "WPDT";
            this.wPDTBindingSource.DataSource = this.mastrapaDataSet;
            // 
            // wPDTTableAdapter
            // 
            this.wPDTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerRecordTableAdapter = null;
            this.tableAdapterManager.EPLGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Example.mastrapaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehouseReceiptTableAdapter = null;
            this.tableAdapterManager.WPDTTableAdapter = this.wPDTTableAdapter;
            // 
            // wPDTBindingNavigator
            // 
            this.wPDTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.wPDTBindingNavigator.BindingSource = this.wPDTBindingSource;
            this.wPDTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.wPDTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.wPDTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.wPDTBindingNavigatorSaveItem});
            this.wPDTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.wPDTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.wPDTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.wPDTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.wPDTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.wPDTBindingNavigator.Name = "wPDTBindingNavigator";
            this.wPDTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.wPDTBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.wPDTBindingNavigator.TabIndex = 0;
            this.wPDTBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // wPDTBindingNavigatorSaveItem
            // 
            this.wPDTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wPDTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("wPDTBindingNavigatorSaveItem.Image")));
            this.wPDTBindingNavigatorSaveItem.Name = "wPDTBindingNavigatorSaveItem";
            this.wPDTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.wPDTBindingNavigatorSaveItem.Text = "Save Data";
            this.wPDTBindingNavigatorSaveItem.Click += new System.EventHandler(this.wPDTBindingNavigatorSaveItem_Click);
            // 
            // bondedLabel
            // 
            bondedLabel.AutoSize = true;
            bondedLabel.Location = new System.Drawing.Point(53, 58);
            bondedLabel.Name = "bondedLabel";
            bondedLabel.Size = new System.Drawing.Size(47, 13);
            bondedLabel.TabIndex = 1;
            bondedLabel.Text = "Bonded:";
            // 
            // bondedCheckBox
            // 
            this.bondedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.wPDTBindingSource, "Bonded", true));
            this.bondedCheckBox.Location = new System.Drawing.Point(146, 53);
            this.bondedCheckBox.Name = "bondedCheckBox";
            this.bondedCheckBox.Size = new System.Drawing.Size(104, 24);
            this.bondedCheckBox.TabIndex = 2;
            this.bondedCheckBox.Text = "checkBox1";
            this.bondedCheckBox.UseVisualStyleBackColor = true;
            // 
            // receiptNumberLabel
            // 
            receiptNumberLabel.AutoSize = true;
            receiptNumberLabel.Location = new System.Drawing.Point(53, 86);
            receiptNumberLabel.Name = "receiptNumberLabel";
            receiptNumberLabel.Size = new System.Drawing.Size(87, 13);
            receiptNumberLabel.TabIndex = 3;
            receiptNumberLabel.Text = "Receipt Number:";
            // 
            // receiptNumberTextBox
            // 
            this.receiptNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wPDTBindingSource, "ReceiptNumber", true));
            this.receiptNumberTextBox.Location = new System.Drawing.Point(146, 83);
            this.receiptNumberTextBox.Name = "receiptNumberTextBox";
            this.receiptNumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.receiptNumberTextBox.TabIndex = 4;
            // 
            // lnumberLabel
            // 
            lnumberLabel.AutoSize = true;
            lnumberLabel.Location = new System.Drawing.Point(53, 112);
            lnumberLabel.Name = "lnumberLabel";
            lnumberLabel.Size = new System.Drawing.Size(51, 13);
            lnumberLabel.TabIndex = 5;
            lnumberLabel.Text = "Lnumber:";
            // 
            // lnumberTextBox
            // 
            this.lnumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wPDTBindingSource, "Lnumber", true));
            this.lnumberTextBox.Location = new System.Drawing.Point(146, 109);
            this.lnumberTextBox.Name = "lnumberTextBox";
            this.lnumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.lnumberTextBox.TabIndex = 6;
            // 
            // piecesLabel
            // 
            piecesLabel.AutoSize = true;
            piecesLabel.Location = new System.Drawing.Point(53, 138);
            piecesLabel.Name = "piecesLabel";
            piecesLabel.Size = new System.Drawing.Size(42, 13);
            piecesLabel.TabIndex = 7;
            piecesLabel.Text = "Pieces:";
            // 
            // piecesTextBox
            // 
            this.piecesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wPDTBindingSource, "Pieces", true));
            this.piecesTextBox.Location = new System.Drawing.Point(146, 135);
            this.piecesTextBox.Name = "piecesTextBox";
            this.piecesTextBox.Size = new System.Drawing.Size(104, 20);
            this.piecesTextBox.TabIndex = 8;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(53, 164);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 9;
            weightLabel.Text = "Weight:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wPDTBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(146, 161);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(104, 20);
            this.weightTextBox.TabIndex = 10;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(53, 190);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wPDTBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(146, 187);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(104, 20);
            this.descriptionTextBox.TabIndex = 12;
            // 
            // vendorLabel
            // 
            vendorLabel.AutoSize = true;
            vendorLabel.Location = new System.Drawing.Point(53, 216);
            vendorLabel.Name = "vendorLabel";
            vendorLabel.Size = new System.Drawing.Size(44, 13);
            vendorLabel.TabIndex = 13;
            vendorLabel.Text = "Vendor:";
            // 
            // vendorTextBox
            // 
            this.vendorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wPDTBindingSource, "Vendor", true));
            this.vendorTextBox.Location = new System.Drawing.Point(146, 213);
            this.vendorTextBox.Name = "vendorTextBox";
            this.vendorTextBox.Size = new System.Drawing.Size(104, 20);
            this.vendorTextBox.TabIndex = 14;
            // 
            // itemCodeLabel
            // 
            itemCodeLabel.AutoSize = true;
            itemCodeLabel.Location = new System.Drawing.Point(53, 242);
            itemCodeLabel.Name = "itemCodeLabel";
            itemCodeLabel.Size = new System.Drawing.Size(58, 13);
            itemCodeLabel.TabIndex = 15;
            itemCodeLabel.Text = "Item Code:";
            // 
            // itemCodeTextBox
            // 
            this.itemCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wPDTBindingSource, "ItemCode", true));
            this.itemCodeTextBox.Location = new System.Drawing.Point(146, 239);
            this.itemCodeTextBox.Name = "itemCodeTextBox";
            this.itemCodeTextBox.Size = new System.Drawing.Size(104, 20);
            this.itemCodeTextBox.TabIndex = 16;
            // 
            // WPDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 295);
            this.Controls.Add(bondedLabel);
            this.Controls.Add(this.bondedCheckBox);
            this.Controls.Add(receiptNumberLabel);
            this.Controls.Add(this.receiptNumberTextBox);
            this.Controls.Add(lnumberLabel);
            this.Controls.Add(this.lnumberTextBox);
            this.Controls.Add(piecesLabel);
            this.Controls.Add(this.piecesTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(vendorLabel);
            this.Controls.Add(this.vendorTextBox);
            this.Controls.Add(itemCodeLabel);
            this.Controls.Add(this.itemCodeTextBox);
            this.Controls.Add(this.wPDTBindingNavigator);
            this.Name = "WPDT";
            this.Text = "WPDT";
            this.Load += new System.EventHandler(this.WPDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mastrapaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wPDTBindingNavigator)).EndInit();
            this.wPDTBindingNavigator.ResumeLayout(false);
            this.wPDTBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mastrapaDataSet mastrapaDataSet;
        private System.Windows.Forms.BindingSource wPDTBindingSource;
        private mastrapaDataSetTableAdapters.WPDTTableAdapter wPDTTableAdapter;
        private mastrapaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator wPDTBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton wPDTBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox bondedCheckBox;
        private System.Windows.Forms.TextBox receiptNumberTextBox;
        private System.Windows.Forms.TextBox lnumberTextBox;
        private System.Windows.Forms.TextBox piecesTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox vendorTextBox;
        private System.Windows.Forms.TextBox itemCodeTextBox;
    }
}
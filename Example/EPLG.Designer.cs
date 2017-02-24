namespace Example
{
    partial class EPLG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPLG));
            this.mastrapaDataSet = new Example.mastrapaDataSet();
            this.ePLGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ePLGTableAdapter = new Example.mastrapaDataSetTableAdapters.EPLGTableAdapter();
            this.tableAdapterManager = new Example.mastrapaDataSetTableAdapters.TableAdapterManager();
            this.ePLGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ePLGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ePLGDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mastrapaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLGBindingNavigator)).BeginInit();
            this.ePLGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePLGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mastrapaDataSet
            // 
            this.mastrapaDataSet.DataSetName = "mastrapaDataSet";
            this.mastrapaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ePLGBindingSource
            // 
            this.ePLGBindingSource.DataMember = "EPLG";
            this.ePLGBindingSource.DataSource = this.mastrapaDataSet;
            // 
            // ePLGTableAdapter
            // 
            this.ePLGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerRecordTableAdapter = null;
            this.tableAdapterManager.EPLGTableAdapter = this.ePLGTableAdapter;
            this.tableAdapterManager.UpdateOrder = Example.mastrapaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WarehouseReceiptTableAdapter = null;
            this.tableAdapterManager.WPDTTableAdapter = null;
            // 
            // ePLGBindingNavigator
            // 
            this.ePLGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ePLGBindingNavigator.BindingSource = this.ePLGBindingSource;
            this.ePLGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ePLGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ePLGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ePLGBindingNavigatorSaveItem});
            this.ePLGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ePLGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ePLGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ePLGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ePLGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ePLGBindingNavigator.Name = "ePLGBindingNavigator";
            this.ePLGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ePLGBindingNavigator.Size = new System.Drawing.Size(347, 25);
            this.ePLGBindingNavigator.TabIndex = 0;
            this.ePLGBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ePLGBindingNavigatorSaveItem
            // 
            this.ePLGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ePLGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ePLGBindingNavigatorSaveItem.Image")));
            this.ePLGBindingNavigatorSaveItem.Name = "ePLGBindingNavigatorSaveItem";
            this.ePLGBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ePLGBindingNavigatorSaveItem.Text = "Save Data";
            this.ePLGBindingNavigatorSaveItem.Click += new System.EventHandler(this.ePLGBindingNavigatorSaveItem_Click);
            // 
            // ePLGDataGridView
            // 
            this.ePLGDataGridView.AutoGenerateColumns = false;
            this.ePLGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ePLGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ePLGDataGridView.DataSource = this.ePLGBindingSource;
            this.ePLGDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ePLGDataGridView.Location = new System.Drawing.Point(0, 25);
            this.ePLGDataGridView.Name = "ePLGDataGridView";
            this.ePLGDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ePLGDataGridView.Size = new System.Drawing.Size(347, 365);
            this.ePLGDataGridView.TabIndex = 1;
            this.ePLGDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ePLGDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "referenceNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "referenceNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "masterReference";
            this.dataGridViewTextBoxColumn2.HeaderText = "masterReference";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "masterHouseInd";
            this.dataGridViewTextBoxColumn3.HeaderText = "masterHouseInd";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // EPLG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 390);
            this.Controls.Add(this.ePLGDataGridView);
            this.Controls.Add(this.ePLGBindingNavigator);
            this.Name = "EPLG";
            this.Text = "EPLG";
            this.Load += new System.EventHandler(this.EPLG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mastrapaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePLGBindingNavigator)).EndInit();
            this.ePLGBindingNavigator.ResumeLayout(false);
            this.ePLGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePLGDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mastrapaDataSet mastrapaDataSet;
        private System.Windows.Forms.BindingSource ePLGBindingSource;
        private mastrapaDataSetTableAdapters.EPLGTableAdapter ePLGTableAdapter;
        private mastrapaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ePLGBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ePLGBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView ePLGDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
namespace Example
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wareHouseReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wPDTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wPToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(43, 195);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wPToolStripMenuItem
            // 
            this.wPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wareHouseReceiptToolStripMenuItem,
            this.wPDTToolStripMenuItem});
            this.wPToolStripMenuItem.Name = "wPToolStripMenuItem";
            this.wPToolStripMenuItem.Size = new System.Drawing.Size(91, 19);
            this.wPToolStripMenuItem.Text = "WP";
            // 
            // wareHouseReceiptToolStripMenuItem
            // 
            this.wareHouseReceiptToolStripMenuItem.Name = "wareHouseReceiptToolStripMenuItem";
            this.wareHouseReceiptToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.wareHouseReceiptToolStripMenuItem.Text = "WareHouse Receipt";
            this.wareHouseReceiptToolStripMenuItem.Click += new System.EventHandler(this.wareHouseReceiptToolStripMenuItem_Click);
            // 
            // wPDTToolStripMenuItem
            // 
            this.wPDTToolStripMenuItem.Name = "wPDTToolStripMenuItem";
            this.wPDTToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.wPDTToolStripMenuItem.Text = "WPDT";
            this.wPDTToolStripMenuItem.Click += new System.EventHandler(this.wPDTToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(107, 195);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 195);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 195);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wareHouseReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wPDTToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
    }
}


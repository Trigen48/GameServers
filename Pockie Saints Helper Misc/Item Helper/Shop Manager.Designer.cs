namespace Item_Helper
{
    partial class Shop_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop_Manager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shopsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDailyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shops = new System.Windows.Forms.TabControl();
            this.buildXMLsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shopsToolStripMenuItem,
            this.compileToolStripMenuItem,
            this.buildXMLsToolStripMenuItem,
            this.dumpToolStripMenuItem,
            this.saveAllToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(914, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // shopsToolStripMenuItem
            // 
            this.shopsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.shopsToolStripMenuItem.Name = "shopsToolStripMenuItem";
            this.shopsToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.shopsToolStripMenuItem.Text = "Shops";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addNewToolStripMenuItem.Text = "Add New";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.compileToolStripMenuItem.Text = "Build Shop";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // dumpToolStripMenuItem
            // 
            this.dumpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toItemToolStripMenuItem,
            this.toDailyToolStripMenuItem});
            this.dumpToolStripMenuItem.Name = "dumpToolStripMenuItem";
            this.dumpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dumpToolStripMenuItem.Text = "Dump";
            // 
            // toItemToolStripMenuItem
            // 
            this.toItemToolStripMenuItem.Name = "toItemToolStripMenuItem";
            this.toItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toItemToolStripMenuItem.Text = "To Item";
            this.toItemToolStripMenuItem.Click += new System.EventHandler(this.toItemToolStripMenuItem_Click);
            // 
            // toDailyToolStripMenuItem
            // 
            this.toDailyToolStripMenuItem.Name = "toDailyToolStripMenuItem";
            this.toDailyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toDailyToolStripMenuItem.Text = "To Daily";
            this.toDailyToolStripMenuItem.Click += new System.EventHandler(this.toDailyToolStripMenuItem_Click);
            // 
            // shops
            // 
            this.shops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shops.Location = new System.Drawing.Point(0, 24);
            this.shops.Name = "shops";
            this.shops.SelectedIndex = 0;
            this.shops.Size = new System.Drawing.Size(914, 481);
            this.shops.TabIndex = 1;
            // 
            // buildXMLsToolStripMenuItem
            // 
            this.buildXMLsToolStripMenuItem.Name = "buildXMLsToolStripMenuItem";
            this.buildXMLsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.buildXMLsToolStripMenuItem.Text = "Build XMLs";
            this.buildXMLsToolStripMenuItem.Click += new System.EventHandler(this.buildXMLsToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.saveAllToolStripMenuItem.Text = "Save All";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // Shop_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 505);
            this.Controls.Add(this.shops);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Shop_Manager";
            this.Text = "Shop Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shop_Manager_FormClosing);
            this.Load += new System.EventHandler(this.Shop_Manager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shopsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.TabControl shops;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDailyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buildXMLsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
    }
}
namespace Item_Helper
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toCostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toWeaponStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemtree = new System.Windows.Forms.TreeView();
            this.Info = new System.Windows.Forms.RichTextBox();
            this.toItemListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.findToolStripMenuItem,
            this.toScriptToolStripMenuItem,
            this.toCostToolStripMenuItem,
            this.toWeaponStatsToolStripMenuItem,
            this.toItemListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importXMLToolStripMenuItem,
            this.exportXMLToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importXMLToolStripMenuItem
            // 
            this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
            this.importXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.importXMLToolStripMenuItem.Text = "Import XML";
            this.importXMLToolStripMenuItem.Click += new System.EventHandler(this.importXMLToolStripMenuItem_Click);
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byIDToolStripMenuItem,
            this.byNameToolStripMenuItem});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // byIDToolStripMenuItem
            // 
            this.byIDToolStripMenuItem.Name = "byIDToolStripMenuItem";
            this.byIDToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.byIDToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.byIDToolStripMenuItem.Text = "By ID";
            this.byIDToolStripMenuItem.Click += new System.EventHandler(this.byIDToolStripMenuItem_Click);
            // 
            // byNameToolStripMenuItem
            // 
            this.byNameToolStripMenuItem.Name = "byNameToolStripMenuItem";
            this.byNameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.byNameToolStripMenuItem.Size = new System.Drawing.Size(200, 24);
            this.byNameToolStripMenuItem.Text = "By Name";
            this.byNameToolStripMenuItem.Click += new System.EventHandler(this.byNameToolStripMenuItem_Click);
            // 
            // toScriptToolStripMenuItem
            // 
            this.toScriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedToolStripMenuItem,
            this.allRangeToolStripMenuItem});
            this.toScriptToolStripMenuItem.Name = "toScriptToolStripMenuItem";
            this.toScriptToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.toScriptToolStripMenuItem.Text = "To Script";
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.selectedToolStripMenuItem.Text = "Selected";
            this.selectedToolStripMenuItem.Click += new System.EventHandler(this.selectedToolStripMenuItem_Click);
            // 
            // allRangeToolStripMenuItem
            // 
            this.allRangeToolStripMenuItem.Name = "allRangeToolStripMenuItem";
            this.allRangeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.allRangeToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.allRangeToolStripMenuItem.Text = "All Range";
            this.allRangeToolStripMenuItem.Click += new System.EventHandler(this.allRangeToolStripMenuItem_Click);
            // 
            // toCostToolStripMenuItem
            // 
            this.toCostToolStripMenuItem.Name = "toCostToolStripMenuItem";
            this.toCostToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.toCostToolStripMenuItem.Text = "To Cost";
            this.toCostToolStripMenuItem.Click += new System.EventHandler(this.toCostToolStripMenuItem_Click);
            // 
            // toWeaponStatsToolStripMenuItem
            // 
            this.toWeaponStatsToolStripMenuItem.Name = "toWeaponStatsToolStripMenuItem";
            this.toWeaponStatsToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.toWeaponStatsToolStripMenuItem.Text = "To Weapon Stats";
            this.toWeaponStatsToolStripMenuItem.Click += new System.EventHandler(this.toWeaponStatsToolStripMenuItem_Click);
            // 
            // itemtree
            // 
            this.itemtree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.itemtree.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemtree.FullRowSelect = true;
            this.itemtree.Indent = 22;
            this.itemtree.ItemHeight = 22;
            this.itemtree.Location = new System.Drawing.Point(0, 27);
            this.itemtree.Name = "itemtree";
            this.itemtree.ShowLines = false;
            this.itemtree.ShowPlusMinus = false;
            this.itemtree.ShowRootLines = false;
            this.itemtree.Size = new System.Drawing.Size(349, 490);
            this.itemtree.TabIndex = 1;
            this.itemtree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Info
            // 
            this.Info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Info.BackColor = System.Drawing.Color.White;
            this.Info.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.Location = new System.Drawing.Point(355, 27);
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            this.Info.Size = new System.Drawing.Size(566, 490);
            this.Info.TabIndex = 2;
            this.Info.Text = "";
            // 
            // toItemListToolStripMenuItem
            // 
            this.toItemListToolStripMenuItem.Name = "toItemListToolStripMenuItem";
            this.toItemListToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.toItemListToolStripMenuItem.Text = "To ItemList";
            this.toItemListToolStripMenuItem.Click += new System.EventHandler(this.toItemListToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 520);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.itemtree);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Item Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TreeView itemtree;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem byNameToolStripMenuItem;
        private System.Windows.Forms.RichTextBox Info;
        private System.Windows.Forms.ToolStripMenuItem toScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toCostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toWeaponStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toItemListToolStripMenuItem;
    }
}


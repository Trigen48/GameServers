namespace Item_Helper
{
    partial class ItemsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemsView));
            this.items = new System.Windows.Forms.TreeView();
            this.btnFindId = new System.Windows.Forms.Button();
            this.btnFindName = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // items
            // 
            this.items.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.items.Location = new System.Drawing.Point(2, 31);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(316, 484);
            this.items.TabIndex = 0;
            this.items.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.items.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.items_NodeMouseDoubleClick);
            // 
            // btnFindId
            // 
            this.btnFindId.Location = new System.Drawing.Point(12, 3);
            this.btnFindId.Name = "btnFindId";
            this.btnFindId.Size = new System.Drawing.Size(104, 23);
            this.btnFindId.TabIndex = 1;
            this.btnFindId.Text = "Find by ID";
            this.btnFindId.UseVisualStyleBackColor = true;
            this.btnFindId.Click += new System.EventHandler(this.btnFindId_Click);
            // 
            // btnFindName
            // 
            this.btnFindName.Location = new System.Drawing.Point(122, 3);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Size = new System.Drawing.Size(104, 23);
            this.btnFindName.TabIndex = 2;
            this.btnFindName.Text = "Find By Name";
            this.btnFindName.UseVisualStyleBackColor = true;
            this.btnFindName.Click += new System.EventHandler(this.btnFindName_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(232, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ItemsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 517);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFindName);
            this.Controls.Add(this.btnFindId);
            this.Controls.Add(this.items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemsView";
            this.Text = "Items View";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemsView_FormClosing);
            this.Load += new System.EventHandler(this.ItemsView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFindId;
        private System.Windows.Forms.Button btnFindName;
        private System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.TreeView items;
    }
}
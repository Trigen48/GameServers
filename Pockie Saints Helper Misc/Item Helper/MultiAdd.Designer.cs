namespace Item_Helper
{
    partial class MultiAdd
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.chkMax = new System.Windows.Forms.CheckBox();
            this.chkAutoPrice = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(274, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(193, 492);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.treeView1.Location = new System.Drawing.Point(3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(345, 484);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // chkMax
            // 
            this.chkMax.AutoSize = true;
            this.chkMax.Location = new System.Drawing.Point(5, 516);
            this.chkMax.Name = "chkMax";
            this.chkMax.Size = new System.Drawing.Size(71, 17);
            this.chkMax.TabIndex = 3;
            this.chkMax.Text = "Auto Max";
            this.chkMax.UseVisualStyleBackColor = true;
            // 
            // chkAutoPrice
            // 
            this.chkAutoPrice.AutoSize = true;
            this.chkAutoPrice.Location = new System.Drawing.Point(82, 516);
            this.chkAutoPrice.Name = "chkAutoPrice";
            this.chkAutoPrice.Size = new System.Drawing.Size(72, 17);
            this.chkAutoPrice.TabIndex = 4;
            this.chkAutoPrice.Text = "Auto Cost";
            this.chkAutoPrice.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "U_Gold",
            "B_Crystal",
            "U_Crystal",
            "B_Gold"});
            this.comboBox1.Location = new System.Drawing.Point(3, 492);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // MultiAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 539);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.chkAutoPrice);
            this.Controls.Add(this.chkMax);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MultiAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Multiple Items";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MultiAdd_FormClosing);
            this.Load += new System.EventHandler(this.MultiAdd_Load);
            this.VisibleChanged += new System.EventHandler(this.MultiAdd_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.CheckBox chkMax;
        private System.Windows.Forms.CheckBox chkAutoPrice;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
namespace Item_Helper
{
    partial class ShopControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShopItems = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnAutoPrice = new System.Windows.Forms.Button();
            this.lblDec = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkExpire = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.intMax = new System.Windows.Forms.NumericUpDown();
            this.intCost = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dtExpire = new System.Windows.Forms.DateTimePicker();
            this.cmbCostType = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intCost)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShopItems
            // 
            this.ShopItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ShopItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShopItems.Location = new System.Drawing.Point(0, 3);
            this.ShopItems.Name = "ShopItems";
            this.ShopItems.Size = new System.Drawing.Size(376, 491);
            this.ShopItems.TabIndex = 0;
            this.ShopItems.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ShopItems_AfterSelect);
            this.ShopItems.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ShopItems_NodeMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.btnMax);
            this.groupBox1.Controls.Add(this.btnMin);
            this.groupBox1.Controls.Add(this.btnAutoPrice);
            this.groupBox1.Controls.Add(this.lblDec);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.chkExpire);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.intMax);
            this.groupBox1.Controls.Add(this.intCost);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.dtExpire);
            this.groupBox1.Controls.Add(this.cmbCostType);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(382, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 209);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(177, 101);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(38, 23);
            this.btnMax.TabIndex = 17;
            this.btnMax.Text = "max";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(133, 101);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(38, 23);
            this.btnMin.TabIndex = 16;
            this.btnMin.Text = "min";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnAutoPrice
            // 
            this.btnAutoPrice.Location = new System.Drawing.Point(179, 75);
            this.btnAutoPrice.Name = "btnAutoPrice";
            this.btnAutoPrice.Size = new System.Drawing.Size(72, 23);
            this.btnAutoPrice.TabIndex = 15;
            this.btnAutoPrice.Text = "Auto Price";
            this.btnAutoPrice.UseVisualStyleBackColor = true;
            this.btnAutoPrice.Click += new System.EventHandler(this.btnAutoPrice_Click);
            // 
            // lblDec
            // 
            this.lblDec.AutoSize = true;
            this.lblDec.Location = new System.Drawing.Point(67, 21);
            this.lblDec.Name = "lblDec";
            this.lblDec.Size = new System.Drawing.Size(0, 13);
            this.lblDec.TabIndex = 14;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(9, 176);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(67, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Get Item";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Visible = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkExpire
            // 
            this.chkExpire.AutoSize = true;
            this.chkExpire.Location = new System.Drawing.Point(70, 153);
            this.chkExpire.Name = "chkExpire";
            this.chkExpire.Size = new System.Drawing.Size(91, 17);
            this.chkExpire.TabIndex = 11;
            this.chkExpire.Text = "Enable Expire";
            this.chkExpire.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(201, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(48, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expires:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cost:";
            // 
            // intMax
            // 
            this.intMax.Location = new System.Drawing.Point(70, 101);
            this.intMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.intMax.Name = "intMax";
            this.intMax.Size = new System.Drawing.Size(57, 20);
            this.intMax.TabIndex = 5;
            this.intMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // intCost
            // 
            this.intCost.Location = new System.Drawing.Point(70, 75);
            this.intCost.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.intCost.Name = "intCost";
            this.intCost.Size = new System.Drawing.Size(103, 20);
            this.intCost.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name: ";
            // 
            // dtExpire
            // 
            this.dtExpire.Location = new System.Drawing.Point(70, 127);
            this.dtExpire.Name = "dtExpire";
            this.dtExpire.Size = new System.Drawing.Size(181, 20);
            this.dtExpire.TabIndex = 1;
            // 
            // cmbCostType
            // 
            this.cmbCostType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCostType.FormattingEnabled = true;
            this.cmbCostType.Items.AddRange(new object[] {
            "U_Gold",
            "B_Crystal",
            "U_Crystal",
            "B_Gold",
            "A_Gold"});
            this.cmbCostType.Location = new System.Drawing.Point(70, 45);
            this.cmbCostType.Name = "cmbCostType";
            this.cmbCostType.Size = new System.Drawing.Size(180, 21);
            this.cmbCostType.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(17, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(17, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(98, 43);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Location = new System.Drawing.Point(382, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 100);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Multiple Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ShopItems);
            this.Name = "ShopControl";
            this.Size = new System.Drawing.Size(769, 497);
            this.Load += new System.EventHandler(this.ShopControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intCost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView ShopItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown intCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtExpire;
        private System.Windows.Forms.ComboBox cmbCostType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown intMax;
        private System.Windows.Forms.CheckBox chkExpire;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblDec;
        private System.Windows.Forms.Button btnAutoPrice;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button button1;
    }
}

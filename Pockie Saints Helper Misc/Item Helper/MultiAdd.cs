using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Item_Helper
{
    public partial class MultiAdd : Form
    {

        bool vic;
        Point p;
       // Shop_Manager shp;
        Control c;
        public MultiAdd()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            if (c.GetType() != typeof(ExplorerControl))
                Shop_Manager.v.locks = false;
            else
                Explorer.v.locks = false;
            //Shop_Manager.v.Close();
            vic = true;
            this.Visible = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (c.GetType() != typeof(ExplorerControl))
                Shop_Manager.v.locks = false;
            else
                Explorer.v.locks = false;
            //Shop_Manager.v.Close();
            treeView1.Nodes.Clear();


            this.Visible = false;
        }

        public bool ShowDialog(Control control)
        {
            c = control;
            if (control.GetType() != typeof(ExplorerControl))
            {
                Shop_Manager.v.TopLevel = false;

                Shop_Manager.v.Parent = this;
                Shop_Manager.v.locks = true;

                Shop_Manager.v.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p = Shop_Manager.v.Location;
                Shop_Manager.v.Location = new Point(345 + 10, 0);
                Shop_Manager.v.Show(treeView1);
                Shop_Manager.v.Enabled = true;
                Shop_Manager.v.TopMost = true;

            }
            else
            {
                Explorer.v.TopLevel = false;

                Explorer.v.Parent = this;
                Explorer.v.locks = true;

                Explorer.v.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p = Explorer.v.Location;
                Explorer.v.Location = new Point(345 + 10, 0);
                Explorer.v.Show(treeView1);
                Explorer.v.Enabled = true;
                Explorer.v.TopMost = true;
            }
            base.ShowDialog(control);
            return vic;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node != null)
            {
                treeView1.Nodes.Remove(e.Node);
            }
        }

        public item[] GetItems()
        {

            item[] b=null;


            if (treeView1.Nodes.Count != 0)
            {
                b = new item[treeView1.Nodes.Count];

                for (int x = 0; x < treeView1.Nodes.Count; x++)
                {
                    item m = new item();

                    m.cost = 1;
                    if (chkAutoPrice.Checked)
                    {
                        m.cost=GetAutoCost(treeView1.Nodes[x].Name);
                    }

                    if (chkMax.Checked)
                    {
                        m.limit = 99;
                    }
                    else m.limit = 1;

                    m.itemid = int.Parse(treeView1.Nodes[x].Name);
                    m.costtype = (byte)(comboBox1.SelectedIndex+1);

                    b[x] = m;
                }
            }

            return b;
        }

        public int GetAutoCost(string id)
        {
            try
            {
                string[] b = System.IO.File.ReadAllLines("goods\\" + id);

                int num = int.Parse(b[12]);

               // intCost.Value = num;
                b = null;
                return num;
            }
            catch
            {
            }
            return 0;
        }

        private void MultiAdd_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void MultiAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Controls.Remove(Shop_Manager.v);
           // Shop_Manager.v.Parent = null;



            if (this.c.GetType() != typeof(ExplorerControl))
            {  
                Shop_Manager.v.Visible = false;
            Shop_Manager.v.Parent = null;
            Shop_Manager.v.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Shop_Manager.v.TopLevel = true;
            Shop_Manager.v.Location = p;

            Shop_Manager.v.locks = false;
            Shop_Manager.v.TopMost = false;
                
                /*Shop_Manager.v.TopLevel = false;

                Shop_Manager.v.Parent = this;
                Shop_Manager.v.locks = true;

                Shop_Manager.v.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                p = Shop_Manager.v.Location;
                Shop_Manager.v.Location = new Point(345 + 10, 0);
                Shop_Manager.v.Show(treeView1);
                Shop_Manager.v.Enabled = true;
                Shop_Manager.v.TopMost = true;*/

            }
            else
            {
                Explorer.v.Visible = false;
                Explorer.v.Parent = null;
                Explorer.v.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                Explorer.v.TopLevel = true;
                Explorer.v.Location = p;

                Explorer.v.locks = false;
                Explorer.v.TopMost = false;
            }
           // Shop_Manager.v.Close();
           // p = null;
        }

        private void MultiAdd_VisibleChanged(object sender, EventArgs e)
        {
            /*
            if (Visible == false)
            {
                //Shop_Manager.v.Visible = false;
                Shop_Manager.v.Parent = null;
                Shop_Manager.v.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                Shop_Manager.v.TopLevel = true;
                Shop_Manager.v.Location = p;

                Shop_Manager.v.locks = false;
                Shop_Manager.v.TopMost = false;
            }*/
        }
    }
}

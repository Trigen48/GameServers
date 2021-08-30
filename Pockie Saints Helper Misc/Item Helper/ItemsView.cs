using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Item_Helper
{
    public partial class ItemsView : Form
    {
        public bool locks;

        TreeView vb = null;

        public ItemsView()
        {
            InitializeComponent();

            try
            {
                if (System.IO.File.Exists(Main.MainFile))
                {
                    string[] d = System.IO.File.ReadAllLines(Main.MainFile);
                    for (int x = 0; x < d.Length; x++)
                    {

                        string[] it = d[x].Split(new char[] { '|' });


                        items.Nodes.Add(it[0], it[1]);
                        //   items.Add(it[0], it[1]);
                    }
                    items.Nodes.Add("ends", "____");
                }
            }
            catch
            {

            }
        }

        private void btnFindId_Click(object sender, EventArgs e)
        {
            Find_Form f = new Find_Form();


            if (f.ShowDialog(this) == true)
            {
                TreeNode[] fc = items.Nodes.Find(f.SearchTerm(), true);

                if (fc != null && fc.Length == 1)
                {
                    items.SelectedNode = fc[0];
                }
                items.Focus();
                fc = null;
            }


            f = null;
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
            Results r = new Results(items);

            if (r.ShowDialog(this) == true)
            {
                string n = r.GetItem();
                if (n != null) items.SelectedNode = items.Nodes[n];
                items.Focus();
            }

            r = null;
        }

        public void Show(TreeView v)
        {
            vb = v;
            //this.Parent = m;
            base.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public TreeNode ShowDialog(Control control)
        {

            base.ShowDialog(control);
            return items.SelectedNode;
        }

        private void ItemsView_Load(object sender, EventArgs e)
        {
            if (items.Nodes.Count != 0)
            {
                items.SelectedNode = items.Nodes[0];
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           if(!locks) this.Visible = false;
        }

        private void items_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (vb == null)
            {
                this.Visible = false;
            }
            else
            {
                if (!vb.Nodes.ContainsKey(e.Node.Name))
                {
                    vb.Nodes.Add(e.Node.Name,e.Node.Text);
                }
                else
                {
                    MessageBox.Show("Item already exists");
                }
            }
        }

        private void ItemsView_FormClosing(object sender, FormClosingEventArgs e)
        {

                e.Cancel = locks;
            
        }
    }
}

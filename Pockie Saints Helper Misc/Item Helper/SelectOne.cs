using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Item_Helper
{
    public partial class SelectOne : Form
    {
        string id = "";
        public SelectOne(List<string> items)
        {
            InitializeComponent();

            for(int x=0;x<items.Count;x++)
            {
                string[] sp= items[x].Split("|".ToCharArray());
                SelectTree.Nodes.Add(sp[0], sp[1]);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (SelectTree.SelectedNode != null)
            {
                id = SelectTree.SelectedNode.Name;
                this.Close();
            }
            else
            {
                MessageBox.Show("no Item Selected!");
            }
        }

        public String ShowDialog(Control c)
        {
            base.ShowDialog(c);

            return id;
        }

        private void SelectTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null)
            {
                id = e.Node.Name;
                this.Close();
            }
            else
            {
                MessageBox.Show("no Item Selected!");
            }
        }
    }
}

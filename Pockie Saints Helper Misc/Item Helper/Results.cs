using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Item_Helper
{
    public partial class Results : Form
    {
        bool val;


        TreeView s;

        public Results(TreeView t)
        {
            InitializeComponent();
            s = t;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ShowDialog(Control c)
        {

            base.ShowDialog(c);

            return val;
        }

        private void find()
        {
            //val = true;
            //this.Close();

            string fr = textBox1.Text.Trim().ToLower(); ;

            treeView1.Nodes.Clear();


            if (fr == "")
            {
            }
            else
            {
                for (int x = 0; x < s.Nodes.Count; x++)
                {
                    TreeNode n = s.Nodes[x];
                    string[] spl = n.Text.Split(new char[] { '-' });

                    string nn = spl[0].Trim().ToLower();
                    if (nn.Contains(fr)) treeView1.Nodes.Add(n.Name, n.Text);

                    n = null;
                    spl = null;
                    nn = null;

                }
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            find();

        }
        string nt = null;
        public string GetItem()
        {
            return nt;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node != null)
            {
                nt = e.Node.Name;
                val = true;
                this.Close();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                find();
            }
        }

        private void Results_Load(object sender, EventArgs e)
        {

        }
    }
}

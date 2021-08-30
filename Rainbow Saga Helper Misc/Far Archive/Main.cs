using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Far_Archive
{
    public partial class Main : Form
    {
        string fileDoe = "";
        public FarLib.Far far;
        string lastdir = "";
        public Main()
        {
            InitializeComponent();
            far = new FarLib.Far();

            if (Program.file != "")
            {
                TryLoad(Program.file);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();

            o.Title = "Open Far Archive";
            o.Filter = "Far Archive (*.far)|*.far";

            if (o.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {

                TryLoad(o.FileName);
            }
        }

        private void TryLoad(string file)
        {
            try
            {
                far.Load(file);
                treeView1.Nodes.Clear();
                BuildView();
                fileDoe = file;

                this.Text = "Far Archive 1.0 - " + System.IO.Path.GetFileName(file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Far Archive 1.0");
            }
        }
        private void BuildView()
        {

            foreach (string key in far.dict.Keys)
            {
                string name = key.PadRight(120 - key.Length, ' ') + far.dict[key].size.ToString() + "  bytes       " + (far.dict[key].compressed == true ? "compressed" : "uncompressed");
                treeView1.Nodes.Add(key, name);
            }

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                far.Clear();
                far = null;
                treeView1.Nodes.Clear();
            }
            catch
            {
            }
            this.Close();


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tFar Archive tool 1.0\n\n\tBy Trigenite\n\n\tVisit:\n\n Http://www.GmrTools.com/FarTool", "Far Archive 1.0");
        }

        private void extractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> toExtract = new List<string>();
            foreach (TreeNode n in treeView1.Nodes)
            {
                if (!n.Checked) continue;

                n.Checked = false;
                toExtract.Add(n.Name);
            }

            if (treeView1.SelectedNode != null)
            {
                if (!toExtract.Contains(treeView1.SelectedNode.Name))
                    toExtract.Add(treeView1.SelectedNode.Name);
            }

            if (toExtract.Count != 0)
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                if (lastdir != "")
                    f.SelectedPath = lastdir;


                if (f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    string dir = f.SelectedPath;
                    if (!dir.EndsWith("\\"))
                        dir = dir + "\\";
                    lastdir = dir;
                    foreach (string key in toExtract)
                    {
                        try
                        {
                            far.Extract(key, dir);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Far Archive 1.0");
                        }
                    }
                }
                toExtract.Clear();
            }
            else
            {
                MessageBox.Show("No Selected files to extract!", "Far Archive 1.0");
            }
            toExtract = null;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node != null)
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                if (lastdir != "")
                    f.SelectedPath = lastdir;
                if (f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    string dir = f.SelectedPath;
                    if (!dir.EndsWith("\\"))
                        dir = dir + "\\";

                    lastdir = dir;

                    try
                    {
                        far.Extract(e.Node.Name, dir);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Far Archive 1.0");
                    }

                }
            }
        }

        private void extractAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count != 0)
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                if (lastdir != "")
                    f.SelectedPath = lastdir;


                if (f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    string dir = f.SelectedPath;
                    if (!dir.EndsWith("\\"))
                        dir = dir + "\\";
                    lastdir = dir;
                    foreach (TreeNode n in treeView1.Nodes)
                    {
                        try
                        {
                            far.Extract(n.Name, dir);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message,"Far Archive 1.0");
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("No files to extract!", "Far Archive 1.0");
            }
        }

        private void extractAllHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count != 0)
            {

                string dir = fileDoe.Substring(0, fileDoe.LastIndexOf("\\") + 1);

                foreach (TreeNode n in treeView1.Nodes)
                {
                    try
                    {
                        far.Extract(n.Name, dir);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Far Archive 1.0");
                    }
                }


            }
            else
            {
                MessageBox.Show("No files to extract!", "Far Archive 1.0");
            }
        }

        private void extractHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> toExtract = new List<string>();
            foreach (TreeNode n in treeView1.Nodes)
            {
                if (!n.Checked) continue;

                n.Checked = false;
                toExtract.Add(n.Name);
            }

            if (treeView1.SelectedNode != null)
            {
                if (!toExtract.Contains(treeView1.SelectedNode.Name))
                    toExtract.Add(treeView1.SelectedNode.Name);
            }

            if (toExtract.Count != 0)
            {
                string dir = fileDoe.Substring(0, fileDoe.LastIndexOf("\\") + 1);

                foreach (string key in toExtract)
                {
                    try
                    {
                        far.Extract(key, dir);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Far Archive 1.0");
                    }
                }

                toExtract.Clear();
            }
            else
            {
                MessageBox.Show("No Selected files to extract!", "Far Archive 1.0");
            }
            toExtract = null;
        }

    }
}

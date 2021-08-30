using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Item_Helper
{
    public partial class Explorer : Form
    {

   //     const string dbsrc = "Data Source=TRIGENITE-PC\\SQLEXPRESS;Initial Catalog=pockie2;Integrated Security=True;Pooling=False";
       // public static SqlConnection cn;
        public static ItemsView v;
        string file = "sedxp.exe";
        public string dir = "explore\\";
        List<string> qs;
        List<int> ids;
        public byte t = 0;
        public Explorer()
        {
            InitializeComponent();

        }
        public Explorer(byte type)
        {
            InitializeComponent();

            if (type == 2)
            {
                file = "pack.exe";
                dir = "packs\\";
                this.Text = "Pack Builder!";
            }
            t = type;
        }

        private void Shop_Manager_Load(object sender, EventArgs e)
        {
            try
            {

                v = new ItemsView();
                CreateDataStream();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void CreateDataStream()
        {
            qs = new List<string>();
            ids = new List<int>();

            if (!System.IO.File.Exists(file) && System.IO.File.Exists(Main.MainFile) && t==2)
            {

                string[] dat = System.IO.File.ReadAllLines(Main.MainFile);

                List<string> Pack = new List<string>();


                for (int x = 0; x < dat.Length; x++)
                {
                    if (dat[x].StartsWith("9020"))
                    {
                        string[] c = dat[x].Split("|".ToCharArray());

                        Pack.Add(c[1]+"|"+c[0]);
                    }
                }

                if (Pack.Count != 0)
                {
                    System.IO.File.WriteAllLines(file,Pack.ToArray());

                }
                Pack.Clear();
                Pack = null;
            }

            if (System.IO.File.Exists(file))
            {
                string[] b = System.IO.File.ReadAllLines(file);

                for (int x = 0; x < b.Length; x++)
                {
                    string[] bs = b[x].Split(new char[] {'|'});

                    if (bs.Length != 2)continue;

                    try
                    {
                        string c = bs[0];
                        int vv = int.Parse(bs[1]);

                        qs.Add(c);

                        ids.Add(vv);
                    }
                    catch
                    {

                    }


                }
            }
            CreateTabs();

        }

        private void CreateTabs()
        {
            for (int i = 0; i < qs.Count; i++)
            {

                CreateTab(ids[i].ToString(), qs[i]);
            }
        }

        private void CreateTab(string name,string id)
        {
            TabPage tp = new TabPage();

            tp.Name = name;
            tp.Text = id;

            ExplorerControl cp = new ExplorerControl();
            cp.Dock = DockStyle.Fill;
            cp.Name = name;

            tp.Controls.Add(cp);

            shops.TabPages.Add(tp);

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewShop n = new NewShop("", 1);

            while(n.ShowDialog(this)==true)
            {


                if (ids.Contains(n.getId))
                {
                    MessageBox.Show("Id already Exists!");
                }
                else
                {
                    ids.Add(n.getId);
                    qs.Add(n.GetName);
                    SaveList();
                    CreateTab(n.getId.ToString(),n.GetName );
                    break;
                }


            }
            n = null;

            
            
        }

        public void SaveList()
        {
            System.IO.StreamWriter rw = new System.IO.StreamWriter(file);

            for (int i = 0; i < ids.Count; i++)
            {
                rw.WriteLine(qs[i] + "|" + ids[i].ToString());
            }
            rw.Flush();
            rw.Close();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (shops.SelectedTab != null)
            {

                if (MessageBox.Show("Delete "+ shops.SelectedTab.Text+" Shop?", "Shop Manager", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    DeleteAll(int.Parse(shops.SelectedTab.Name));

                    qs.Remove(shops.SelectedTab.Text);
                    ids.Remove(int.Parse(shops.SelectedTab.Name));
                    shops.TabPages.RemoveByKey(shops.SelectedTab.Name);

                    SaveList();
                }
            }

        }

        public bool DeleteAll(int id)
        {

          //  string cmm = "DELETE FROM shops WHERE shoptype=" + id.ToString();

          //  return dbtools.ExecuteCount(cn, cmm)!=-1;
            System.IO.File.Delete(dir + id.ToString());
            return true;
        }

        private void accuireFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accuireFromIniToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<string> idz = new List<string>();


            for (int x = 0; x < ids.Count; x++)
            {
                if (System.IO.File.Exists(dir + ids[x].ToString()))
                {
                    idz.Add(ids[x].ToString());
                }

            }

            if (idz.Count == 0)
            {
                MessageBox.Show("File not compiled!\nNo entries to compile");
                return;
            }

            if (t != 2)
            {
                ByteArray ar = new ByteArray();
                ar.WriteShort(idz.Count);

                foreach (string l in idz)
                {
                    ar.WriteInt(int.Parse(l));
                    ar.WriteFile(dir + l);
                }


                System.IO.File.WriteAllBytes("explore.sh", ar.GetByteArray());

                ar.Close();
            }
            else
            {

                
                foreach (string l in idz)
                {
                    ByteArray ar = new ByteArray();

                    //ar.WriteInt(int.Parse(l));
                    ar.WriteByte(2);
                    ar.WriteFile(dir + l);

                    ar.SaveFile("pack_scripts\\" + l+".script");
                    ar.Close();
                }


            }
            MessageBox.Show("Explore file compiled");
        }

        private void Shop_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            v.Close();
           // v = null;
            shops.TabPages.Clear();
           // shops = null;
        }
    }
}

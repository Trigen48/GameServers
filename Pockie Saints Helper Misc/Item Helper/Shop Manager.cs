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
    public partial class Shop_Manager : Form
    {

   //     const string dbsrc = "Data Source=TRIGENITE-PC\\SQLEXPRESS;Initial Catalog=pockie2;Integrated Security=True;Pooling=False";
       // public static SqlConnection cn;
        public static ItemsView v;
        public const string file = "sedo.exe";
        List<string> qs;
        List<int> ids;

        public Shop_Manager()
        {
            InitializeComponent();

        }

        private void Shop_Manager_Load(object sender, EventArgs e)
        {
            try
            {
            //    cn = new SqlConnection(dbsrc);

           
                    v = new ItemsView();
                    CreateDataStream();

                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void CreateDataStream()
        {
            qs = new List<string>();
            ids = new List<int>();

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

            ShopControl cp = new ShopControl();
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
            System.IO.File.Delete("shop\\" + id.ToString());
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
                if (System.IO.File.Exists("shop\\" + ids[x].ToString()))
                {
                    idz.Add(ids[x].ToString());
                }

            }

            if (idz.Count == 0)
            {
                MessageBox.Show("File not compiled!\nNo entries to compile");
                return;
            }

            ByteArray ar = new ByteArray();
            ar.WriteShort(idz.Count);

            foreach (string l in idz)
            {
                ar.WriteInt(int.Parse(l));
                ar.WriteFile("shop\\" + l);
            }

            System.IO.File.WriteAllBytes("Shop.sh", ar.GetByteArray());
            ar.Close();

            MessageBox.Show("Shop file compiled");
        }

        private void Shop_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {
            v.Close();
           // v = null;
            shops.TabPages.Clear();
           // shops = null;
        }

        private void toDailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(shops.SelectedTab!=null)
            {
                System.IO.StreamWriter rw = new System.IO.StreamWriter(shops.SelectedTab.Text+"_DialyShop" + ".cs");
                
                foreach (string k in ((ShopControl)shops.SelectedTab.Controls[0]).index.Keys)
                {
                    item t = ((ShopControl)shops.SelectedTab.Controls[0]).index[k];
                    rw.WriteLine("//" + Shop_Manager.v.items.Nodes[k].Text);
                    rw.WriteLine("new RandomItem(" +t.itemid.ToString() + ",0,0,1,99," + t.cost.ToString() + "),");
                    rw.WriteLine();
                    rw.Flush();
                }
                rw.Close();
            }
            MessageBox.Show("Built!");
        }

        private void toItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShopItem(int Type, int Cost, int Time, Byte CostType, Byte Limit)
            if (shops.SelectedTab != null)
            {
                System.IO.StreamWriter rw = new System.IO.StreamWriter(shops.SelectedTab.Text + "_Items" + ".cs");

                foreach (string k  in ((ShopControl)shops.SelectedTab.Controls[0]).index.Keys)
                {
                    item t = ((ShopControl)shops.SelectedTab.Controls[0]).index[k];
                    rw.WriteLine("//" + Shop_Manager.v.items.Nodes[k].Text);
                    rw.WriteLine("new ShopItem(" + t.itemid.ToString() + "," + t.cost.ToString() +
                        "," + t.time.ToString() + "," + t.costtype + "," +t.limit.ToString()+"),");
                    rw.WriteLine();
                    rw.Flush();
                }
                rw.Close();
            }

            MessageBox.Show("Built!");
        }

        private void buildXMLsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            List<string> idz = new List<string>();


            for (int x = 0; x < ids.Count; x++)
            {
                if (System.IO.File.Exists("shop\\" + ids[x].ToString()))
                {
                    idz.Add(ids[x].ToString());
                }

            }

            if (idz.Count == 0)
            {
                MessageBox.Show("File not compiled!\nNo entries to compile");
                return;
            }

            ByteArray ar = new ByteArray();
            ar.WriteShort(idz.Count);

            foreach (string l in idz)
            {
                ar.WriteInt(int.Parse(l));
                ar.WriteFile("shop\\" + l);
            }

            System.IO.File.WriteAllBytes("Shop.sh", ar.GetByteArray());
            ar.Close();

            MessageBox.Show("Shop file compiled");
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ShopItem(int Type, int Cost, int Time, Byte CostType, Byte Limit)
            if (shops.SelectedTab != null)
            {

                foreach (TabPage p in shops.TabPages)
                {
                    try
                    {
                        ((ShopControl)p.Controls[0]).Save();
                    }
                    catch
                    {
                    }

                }
            }

            MessageBox.Show("Built!");
        }
    }
}

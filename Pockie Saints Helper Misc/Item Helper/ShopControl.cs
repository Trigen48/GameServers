using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Item_Helper
{

    public struct item
    {
     //   public int shopid;
        public int itemid, cost, time;
        public byte costtype, limit;
    }

    public partial class ShopControl : UserControl
    {  


        // SqlDataReader adp;

        byte ctrl = 0;

        public Dictionary<string,item> index;

        string sel = "";
        string ed;

        public ShopControl()
        {
            InitializeComponent();
            cmbCostType.SelectedIndex = 0;

        }

        private void ShopControl_Load(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void RefreshItems()
        {
            //adp;


          //  dbtools.ExecuteReader(Shop_Manager.cn, "SELECT * from shops WHERE shoptype=" + this.Name, out adp);

                index = new Dictionary<string, item>();            
            if (!System.IO.File.Exists("shop\\"+this.Name))
            {
               // this.Enabled = false;

            }
            else
            {
                ByteArray ar = new ByteArray("shop\\" + this.Name);

                

                int len = ar.ReadShort();

                for (int i = 0; i < len; i++)
                {
                       item m = new item();
                        m.itemid = ar.ReadInt();// Convert.ToInt32(adp["itemtype"]);
                        m.cost = ar.ReadInt(); //Convert.ToInt32(adp["cost"]);

                    //    m.shopid = ar.ReadInt();// Convert.ToInt32(adp["ShopItemId"]);
                        m.time = ar.ReadInt();// Convert.ToInt32(adp["time"]);

                        m.costtype = ar.ReadByte(); //Convert.ToByte(adp["costtype"]);
                        m.limit = ar.ReadByte(); //Convert.ToByte(adp["limit"]);



                        TreeNode n =Shop_Manager.v.items.Nodes[m.itemid.ToString()];

                        if (n != null)
                        {

                            index.Add(m.itemid.ToString(), m);
                            ShopItems.Nodes.Add(n.Name, n.Text);
                        }
                }
                ar.Close();

                //adp.Close();

            }

           // adp = null;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            TreeNode n= Shop_Manager.v.ShowDialog(this);

            if (n != null && n.Name!="ends")
            {
                lblDec.Text=n.Text;
                ed = n.Name;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (sel=="")
            {
                MessageBox.Show("no item selected");
                return;
            }
            ctrl = 1;
            ed = sel;
            DisableP();
            ShowD();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DisableP();
            ShowD();
            ResetDetail();
            ed = Shop_Manager.v.items.Nodes[0].Name;
            lblDec.Text = Shop_Manager.v.items.Nodes[0].Text;
            ctrl = 2;

        }

        private void ShowD()
        {
            btnSave.Show();
            btnClose.Show();
            btnBrowse.Show();
            btnMax.Show();
            btnMin.Show();
        }

        private void HideD()
        {
            btnSave.Hide();
            btnClose.Hide();
            btnBrowse.Hide();
            btnMin.Hide();
            btnMax.Hide();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(sel==""||ShopItems.SelectedNode==null)
            {
                MessageBox.Show("Delete error. No item selected!");
                return;
            }

            if(MessageBox.Show("Delete "+ ShopItems.SelectedNode.Text,"Delete items", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
              


                ShopItems.Nodes.RemoveByKey(sel);

                index.Remove(sel);


                if (ShopItems.Nodes.Count != 0)
                {
                    ShopItems.SelectedNode = ShopItems.Nodes[0];
                    sel=ShopItems.SelectedNode.Name;

                    SelectItem(sel, ShopItems.SelectedNode.Text);
                }
                else
                {
                    sel="";
               
                    ResetDetail();
                }

                Save();
            }
        }

        internal void Save()
        {

            System.IO.StreamWriter rw = new System.IO.StreamWriter("shop_xml\\" + this.Parent.Text+".xml");

            rw.WriteLine("<shop>");

            rw.WriteLine("\t<shopinfo shopid=\"{0}\" shoptype=\"{1}\" description=\"{2}\"/>", this.Name, 1, this.Parent.Text);

            ByteArray ar = new ByteArray();
            ar.WriteShort(index.Count);

            rw.WriteLine("\t<items>");

            foreach (string k in index.Keys)
            {
                rw.WriteLine("\t\t<item id=\"{0}\" costvalue=\"{1}\" time=\"{2}\" costtype=\"{3}\" limit=\"{4}\"/>",
                    new object[]{index[k].itemid,index[k].cost,index[k].time,index[k].costtype,index[k].limit});

                ar.WriteInt(index[k].itemid);
                ar.WriteInt(index[k].cost);
                // ar.WriteInt(index[n.Name].shopid);
                ar.WriteInt(index[k].time);

                ar.WriteByte(index[k].costtype);
                ar.WriteByte(index[k].limit);

            }
            rw.WriteLine("\t</items>");
            rw.WriteLine("</shop>");

            rw.Flush();
            rw.Close();

            System.IO.File.WriteAllBytes("shop\\" + this.Name, ar.GetByteArray());
            ar.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearAndRefresh();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            switch(ctrl)
            {

                case 1:


                    if (!SaveEdit()) return;
                   break;
                    

                case 2:
                   if (!CreateNew()) return;
                    break;
            }

            ed = "";
            ctrl = 0;
            HideD();
            EnableP();
            ShopItems.Focus();
        }

        private bool CreateNew()
        {
            item c = new item();
            //item m = index[sel];
           // c = m;


            c.costtype = (byte)((byte)cmbCostType.SelectedIndex + (byte)1);
            c.cost = (int)intCost.Value;
            c.limit = (byte)intMax.Value;
            c.itemid = int.Parse(Shop_Manager.v.items.Nodes[ed].Name);


            if (chkExpire.Checked)
            {
                c.time = (int)DateUtil.GetDateInt(dtExpire.Value);
            }
            else
            {
                c.time = 0;
            }


            if (ed == "")
            {
                MessageBox.Show("empty item record");
                return false;
            }
            else if (ShopItems.Nodes.ContainsKey(ed))
            {
                MessageBox.Show("Item Already Exists");
                return false;
            }


          /*  string cmm = "INSERT INTO shops (itemtype,cost,costtype,limit,time,shoptype) VALUES($1,$2,$4,$5,$6,$3)";

            dbtools.GetParam(ref cmm, "$1", c.itemid);
            dbtools.GetParam(ref cmm, "$2", c.cost);
            dbtools.GetParam(ref cmm,"$3",this.Name);
            dbtools.GetParam(ref cmm, "$4", c.costtype);
            dbtools.GetParam(ref cmm, "$5", c.limit);
            dbtools.GetParam(ref cmm, "$6", c.time);
            //dbtools.GetParam(ref cmm,"$",);

            if (dbtools.ExecuteCount(Shop_Manager.cn, cmm) != 1)
            {
                MessageBox.Show("Could not edit record");
                return false;
            }

            cmm = "SELECT ShopItemId FROM shops WHERE itemtype=$1 and shoptype=$2";
            dbtools.GetParam(ref cmm, "$1", c.itemid);
            dbtools.GetParam(ref cmm, "$2", this.Name);

            object b;
            dbtools.ExecuteScalar(Shop_Manager.cn, cmm, out b);

            if (b == null)
            {
                MessageBox.Show("Could not edit record");
                return false;
            }*/
           // c.shopid = 0;


            index.Add(c.itemid.ToString(), c);

            TreeNode n= new TreeNode();

            ShopItems.Nodes.Add(c.itemid.ToString(),Shop_Manager.v.items.Nodes[c.itemid.ToString()].Text);
            sel = c.itemid.ToString();

            Save();
            /*
            if (sel != ed)
            {
                index.Remove(sel);
                index.Add(ed, c);
                 = Shop_Manager.v.items.Nodes[ed];

                 = n.Text;

                ShopItems.Nodes[sel].Name = n.Name;


            }
            else index[sel] = c;

            //return true;*/
            return true;
        }

        private bool SaveEdit()
        {

            item c = new item();
            item m = index[sel];
            c = m;


            c.costtype = (byte)((byte)cmbCostType.SelectedIndex + (byte)1);
            c.cost = (int)intCost.Value;
            c.limit = (byte)intMax.Value;
            c.itemid = int.Parse(Shop_Manager.v.items.Nodes[ed].Name);


            if (chkExpire.Checked)
            {
                c.time = (int)DateUtil.GetDateInt(dtExpire.Value);
            }
            else
            {
                c.time = 0;
            }


            if (ed == "")
            {
                MessageBox.Show("empty item record");
                return false;
            }
            else if (ShopItems.Nodes.ContainsKey(ed) && sel!=ed)
            {
                MessageBox.Show("Item Already Exists");
                return false;
            }


            /*string cmm = "UPDATE shops SET itemtype=$1,cost=$2,costtype=$4,limit=$5,time=$6 WHERE ShopItemId=" + m.shopid.ToString();

            dbtools.GetParam(ref cmm, "$1", c.itemid);
            dbtools.GetParam(ref cmm, "$2", c.cost);
            //dbtools.GetParam(ref cmm,"$3",);
            dbtools.GetParam(ref cmm, "$4", c.costtype);
            dbtools.GetParam(ref cmm, "$5", c.limit);
            dbtools.GetParam(ref cmm, "$6", c.time);*/
            //dbtools.GetParam(ref cmm,"$",);

            //index[sel] = m;

            /*if (dbtools.ExecuteCount(Shop_Manager.cn, cmm) != 1)
            {
                MessageBox.Show("Could not edit record");
                return false;
            }*/

            if (sel != ed)
            {
                index.Remove(sel);
                index.Add(ed, c);
                TreeNode n = Shop_Manager.v.items.Nodes[ed];

                ShopItems.Nodes[sel].Text = n.Text;

                ShopItems.Nodes[sel].Name = n.Name;


            }
            else index[sel] = c;

            Save();
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ed = "";
            ctrl = 0;
            EnableP();
            if (sel != "")
            {
                ResetDetail();
            }
            HideD();
            ShopItems.Focus();
        }

        private void ShopItems_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if(e.Node!=null)
            {
                SelectItem(e.Node.Name,e.Node.Text);
                sel = e.Node.Name;
            }
            else
            {
                ResetDetail();
            }
        }

        private void SelectItem(string id,string names)
        {
            item m = index[id];

            lblDec.Text = names;

            cmbCostType.SelectedIndex = m.costtype-1;
                
          //  int g = (int)Get();
               
           // DateTime d = GetDate(g);

            if (m.time != 0)
            {


                dtExpire.Value = DateUtil.GetDateFromInt(m.time);
                chkExpire.Checked = true;
            }
            else
            {
            dtExpire.Value = DateTime.Now;
            chkExpire.Checked = false;
            }



            intCost.Value = m.cost;
            intMax.Value = m.limit;

        }

        private void ResetDetail()
        {
            lblDec.Text = "";
            cmbCostType.SelectedIndex = 0;
            dtExpire.Value=DateTime.Now;
            chkExpire.Checked = false;
            intCost.Value = 0;
            intMax.Value = 1;
        }

        void DisableP()
        {
            ShopItems.Enabled = false;
            panel1.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void EnableP()
        {
            ShopItems.Enabled = true;
            panel1.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnAutoPrice_Click(object sender, EventArgs e)
        {
            try
            {
                string[] b = System.IO.File.ReadAllLines("goods\\" + ed);

                int num = int.Parse(b[12]);

                intCost.Value = num;
                b = null;
            }
            catch
            {
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            intMax.Value = 1;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            intMax.Value = 99;
        }

        private void ShopItems_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Node != null && sel != "")
            {
                ctrl = 1;
                ed = sel;
                DisableP();
                ShowD();
            }
            else
            {
                    MessageBox.Show("no item selected");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

          //  this.Parent.Parent.Parent.Enabled = false;
          //  this.Parent.Parent.Parent.Hide();
            MultiAdd a = new MultiAdd();

            if (a.ShowDialog(this))
            {

                item[] b = a.GetItems();

                MultiAddItems(ref b);
                b = null;
            }

            a = null;


        }

        private void MultiAddItems(ref item[] n)
        {

           // string cmm = "INSERT INTO shops (itemtype,cost,costtype,limit,time,shoptype) VALUES";
            if (n == null) return;
            int rec=0;
            for (int x = 0; x < n.Length; x++)
            {
                if(index.ContainsKey(n[x].itemid.ToString()))
                {
                    MessageBox.Show("\"" + n[x].itemid.ToString() + "\" Already exists!");
                }
                else
                {
                    index.Add(n[x].itemid.ToString(), n[x]);

                    rec++;
                 //   cmm += GetInsert(n[x]);
                }
            }
         //   cmm = cmm.Remove(cmm.Length - 2);
            Save();
            if(rec==0)
            {
                MessageBox.Show("No items to add!");
            }
            else
            {
                    ClearAndRefresh();
            }
        }

        private void ClearAndRefresh()
        {
            ShopItems.Nodes.Clear();
            index.Clear();
            ResetDetail();

            RefreshItems();
        }

     /*   public string GetInsert(item c)
        {

            string cmm = "($1,$2,$4,$5,$6,$3), ";

            dbtools.GetParam(ref cmm, "$1", c.itemid);
            dbtools.GetParam(ref cmm, "$2", c.cost);
            dbtools.GetParam(ref cmm, "$3", this.Name);
            dbtools.GetParam(ref cmm, "$4", c.costtype);
            dbtools.GetParam(ref cmm, "$5", c.limit);
            dbtools.GetParam(ref cmm, "$6", c.time);

            return cmm;
        }*/



    }
}

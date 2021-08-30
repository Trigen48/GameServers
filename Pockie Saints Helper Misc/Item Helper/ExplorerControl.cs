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

    public partial class ExplorerControl : UserControl
    {  


        // SqlDataReader adp;

        byte ctrl = 0;

        Dictionary<string,item> index;

        string sel = "";
        string ed;

        public ExplorerControl()
        {
            InitializeComponent();
           // cmbCostType.SelectedIndex = 0;

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
                if (!System.IO.File.Exists(((Explorer)(this.Parent.Parent.Parent)).dir + this.Name))
            {
               // this.Enabled = false;

            }
            else
            {
                ByteArray ar = new ByteArray(((Explorer)(this.Parent.Parent.Parent)).dir + this.Name);

                

                int len = ar.ReadShort();

                for (int i = 0; i < len; i++)
                {
                       item m = new item();
                       m.itemid = ar.ReadInt();
                       m.costtype= ar.ReadByte();
                       m.limit= ar.ReadByte();
                       m.cost = ar.ReadByte(); 
                        TreeNode n =Explorer.v.items.Nodes[m.itemid.ToString()];

                        if (n != null)
                        {

                            index.Add(m.itemid.ToString(), m);
                            ExploreItems.Nodes.Add(n.Name, n.Text);
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
           
            TreeNode n= Explorer.v.ShowDialog(this);

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
            
            ed = Explorer.v.items.Nodes[0].Name;
            lblDec.Text = Explorer.v.items.Nodes[0].Text;
            ctrl = 2;

        }

        private void ShowD()
        {
            btnSave.Show();
            btnClose.Show();
            btnBrowse.Show();
            /*btnMax.Show();
            btnMin.Show();*/
        }

        private void HideD()
        {
            btnSave.Hide();
            btnClose.Hide();
            btnBrowse.Hide();
           /* btnMin.Hide();
            btnMax.Hide();*/
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(sel==""||ExploreItems.SelectedNode==null)
            {
                MessageBox.Show("Delete error. No item selected!");
                return;
            }

            if(MessageBox.Show("Delete "+ ExploreItems.SelectedNode.Text,"Delete items", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {

                string xx = sel;

                ExploreItems.Nodes.RemoveByKey(xx);

                index.Remove(xx);


                if (ExploreItems.Nodes.Count != 0)
                {
                    ExploreItems.SelectedNode = ExploreItems.Nodes[0];
                    sel=ExploreItems.SelectedNode.Name;

                    SelectItem(sel, ExploreItems.SelectedNode.Text);
                }
                else
                {
                    sel="";
               
                    ResetDetail();
                }

                Save();
            }
        }

        private void Save()
        {

            ByteArray ar = new ByteArray();

            ar.WriteShort(index.Count);
            foreach (string k in index.Keys)
            {
                ar.WriteInt(index[k].itemid);
                ar.WriteByte(index[k].costtype);
                ar.WriteByte(index[k].limit);
                ar.WriteByte(index[k].cost);



            }

            System.IO.File.WriteAllBytes(((Explorer)(this.Parent.Parent.Parent)).dir + this.Name, ar.GetByteArray());
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
            ExploreItems.Focus();
        }

        private bool CreateNew()
        {
            item c = new item();
            //item m = index[sel];
           // c = m;


          //  c.costtype = (byte)((byte)cmbCostType.SelectedIndex + (byte)1);
            c.cost = (int)intCost.Value;
           // c.limit = (byte)intMax.Value;
            c.itemid = int.Parse(Explorer.v.items.Nodes[ed].Name);

            c.costtype = 1;
            c.limit = 1;

          /*  if (chkExpire.Checked)
            {
                c.time = (int)DateUtil.GetDateInt(dtExpire.Value);
            }
            else
            {
                c.time = 0;
            }*/


            if (ed == "")
            {
                MessageBox.Show("empty item record");
                return false;
            }
            else if (ExploreItems.Nodes.ContainsKey(ed))
            {
                MessageBox.Show("Item Already Exists");
                return false;
            }

            index.Add(c.itemid.ToString(), c);

            TreeNode n= new TreeNode();

            ExploreItems.Nodes.Add(c.itemid.ToString(),Explorer.v.items.Nodes[c.itemid.ToString()].Text);
            sel = c.itemid.ToString();

            Save();

            return true;
        }

        private bool SaveEdit()
        {

            item c = new item();
            item m = index[sel];
            c = m;


            //c.costtype = (byte)((byte)cmbCostType.SelectedIndex + (byte)1);
            c.cost = (int)intCost.Value;
            //c.limit = (byte)intMax.Value;
            c.itemid = int.Parse(Explorer.v.items.Nodes[ed].Name);

            c.costtype= (byte)(chkBound.Checked==true? 2:1);
            c.limit=(byte)numcount.Value ;


           /* if (chkExpire.Checked)
            {
                c.time = (int)DateUtil.GetDateInt(dtExpire.Value);
            }
            else
            {
                c.time = 0;
            }*/


            if (ed == "")
            {
                MessageBox.Show("empty item record");
                return false;
            }
            else if (ExploreItems.Nodes.ContainsKey(ed) && sel!=ed)
            {
                MessageBox.Show("Item Already Exists");
                return false;
            }


            if (sel != ed)
            {
                index.Remove(sel);
                index.Add(ed, c);
                TreeNode n = Explorer.v.items.Nodes[ed];

                ExploreItems.Nodes[sel].Text = n.Text;

                ExploreItems.Nodes[sel].Name = n.Name;


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
            ExploreItems.Focus();
        }

        private void ShopItems_AfterSelect(object sender, TreeViewEventArgs e)
        {

            if(e.Node!=null)
            {
                SelectItem(e.Node.Name,e.Node.Text);
                sel = e.Node.Name;

               /* c.costtype = (byte)(chkBound.Checked == true ? 2 : 1);
                c.limit = (byte)numcount.Value;*/
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

            chkBound.Checked=(m.costtype==2);//  c.costtype = (byte)( == true ? 2 : 1);
           numcount.Value =m.limit;
            intCost.Value = m.cost;
            //intMax.Value = m.limit;

        }

        private void ResetDetail()
        {
            lblDec.Text = "";

            chkBound.Checked = false;
            numcount.Value = 1;
            intCost.Value = 0;
          //  intMax.Value = 1;
        }

        void DisableP()
        {
            ExploreItems.Enabled = false;
            panel1.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void EnableP()
        {
            ExploreItems.Enabled = true;
            panel1.Enabled = true;
            groupBox1.Enabled = false;
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
            ExploreItems.Nodes.Clear();
            index.Clear();
            ResetDetail();

            RefreshItems();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string[] k = textBox1.Text.Replace(" ", "").Split(",".ToCharArray());
            textBox1.Text = "";

            if (k.Length == 0)
            {
                return;
            }
            List<item> mm = new List<item>();
            foreach(string n in  k)
            {
                try
                {
                    int id = int.Parse(n);
                    item i= new item();
                   
                    i.itemid = id;
                    i.costtype = 1;
                    i.limit = 1;
                    mm.Add(i);
                }
                catch
                {
                }
            }

            if (mm.Count == 0) return;

            try
            {
                item[] b = mm.ToArray();

                MultiAddItems(ref b);
                mm.Clear();

                b = null;
            }
            catch
            {
            }
            
            
        }





    }
}

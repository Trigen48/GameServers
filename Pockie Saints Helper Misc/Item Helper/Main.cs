using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Item_Helper
{

    public partial class Main : Form
    {

        string[] ict = new string[] { "goods_id", "goods_name", "intro", "bind", "trade", "sell", "isdrop", "type", "subtype", "equip_type", "icon", "price_type", "price", "sell_price", "career_id", "sex", "realm", "job", "forza_limit", "agile_limit", "wit_limit", "level", "practice", "star", "forza", "agile", "wit", "hp", "mp", "att", "def", "hit", "dodge", "crit", "ten", "speed", "exp", "attrition", "suit_id", "max_hole", "max_stren", "max_quality", "max_overlap", "color", "cd", "extra", "expire_time", "img" };
        string[] color = new string[]{"White","Blue","Green","Purple","Orange"};

        internal const string MainFile = "rec.exe";



        public Main()
        {
            InitializeComponent();
        }

        Dictionary<string, string> itms = new Dictionary<string, string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            //items= new Dictionary<string,string>();

            Info.LanguageOption = RichTextBoxLanguageOptions.AutoFont;
          
        ret: ;
        if (System.IO.File.Exists(MainFile))
            {
                string[] d = System.IO.File.ReadAllLines(MainFile);
                for (int x = 0; x < d.Length; x++)
                {

                    string[] it = d[x].Split(new char[] { '|' });

               //     itms.Add(it[1], it[0]);
                    itemtree.Nodes.Add(it[0], it[1]);
                 //   items.Add(it[0], it[1]);
                }
                itemtree.Nodes.Add("ends", "____");
            }
            else
            {
                string[] g = System.IO.File.ReadAllLines("all data.txt");
                System.IO.StreamWriter rw = new System.IO.StreamWriter(MainFile);
                rw.AutoFlush=true;
                for (int x = 0; x < g.Length; x++)
                {
                    string[] info=System.IO.File.ReadAllLines("goods\\" + g[x]);

                    
                    rw.WriteLine(g[x] +"|"+ info[1].Trim()+" - " + color[Convert.ToByte(info[43])]);
                }
                rw.Close();
                goto ret;
            }
            

   

        }

        private void byIDToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Find_Form f = new Find_Form();


            if (f.ShowDialog(this) == true)
            {
               TreeNode[] fc= itemtree.Nodes.Find(f.SearchTerm(),true);

               if (fc != null && fc.Length==1)
               {
                   itemtree.SelectedNode = fc[0];
                   itemtree.Focus();
               }
               fc = null;
            }


            f = null;
           //
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Info.Text = "";
            if (e.Node != null)
            {

                string v = e.Node.Name;

                try
                {
                    if (v == "ends") return;
                    string [] t= System.IO.File.ReadAllLines("goods\\"+v);

                    Info.Text = "";
                    string tmp = "";
                    for (int x = 0; x < t.Length; x++)
                    {
                        string sep = "";

                        if (ict[x].Length > 5) sep = "\t\t"; else sep = "\t\t\t";
                        tmp+= x.ToString()+"> \t"+ict[x]+":"+ sep+t[x]+"\n"; 
                    }
                    Info.Text = tmp;
                    tmp = null;
                }
                catch
                {
                }

                v = null;
            }
        }

        public string FindId(string term)
        {
            string fr = term.Trim().ToLower(); ;
            string id = "";
            //itemtree
            //  treeView1.Nodes.Clear();

            List<string> results = new List<string>();
           // List<string> ids = new List<string>();
            //List<string> descript = new List<string>();

            for (int x = 0; x < itemtree.Nodes.Count; x++)
            {
                TreeNode n = itemtree.Nodes[x];
                string[] spl = n.Text.Split(new char[] { '-' });

                string nn = spl[0].Trim().ToLower();
                if (nn.Contains(fr))
                {
                    results.Add(n.Name + "|" + nn + " - " + n.Name);
                 //   ids.Add(n.Name);
                }


                n = null;
                spl = null;
                nn = null;

            }


            if (results.Count == 0)
            {
                return id;
            }

            if (results.Count == 1)
            {
                id = results[0].Split("|".ToCharArray())[0];
            }
            else
            {

                SelectOne sl = new SelectOne(results);
                sl.Text = term;
                id = sl.ShowDialog(this);
            }

            return id;
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            Results r = new Results(itemtree);

            if (r.ShowDialog(this) == true)
            {
                string n = r.GetItem();
                if (n != null) itemtree.SelectedNode = itemtree.Nodes[n];
                itemtree.Focus();
            }

            r = null;
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if(itemtree.SelectedNode==null) return;


            string k= itemtree.SelectedNode.Name;
                               
            if (k == "ends") return;
            string [] t= System.IO.File.ReadAllLines("goods\\"+k);

            string key = k.Remove(4);

            ToScript(k, key, t);


        }

        

        private void allRangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string k = itemtree.SelectedNode.Name;

            if (k == "ends") return;


            string key = k.Remove(4);

            string[] t;

            for (int x = 0; x < itemtree.Nodes.Count; x++)
            {
                if (itemtree.Nodes[x].Name.StartsWith(key))
                {
                    k = itemtree.Nodes[x].Name;
                    t = System.IO.File.ReadAllLines("goods\\" + k);
                    ToScript(k, key, t);
                }
            }


        }


        private void ToScript(string k,string key,string[] t)
        {
            ByteArray ar = new ByteArray();
            switch (key)
            {

                case "2010":
                    ar.WriteByte(6);
                    ar.WriteInt(int.Parse(t[27]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2020":
                    ar.WriteByte(7);
                    ar.WriteInt(int.Parse(t[28]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2030":
                    ar.WriteByte(8);
                    ar.WriteInt(int.Parse(t[27]));
                    ar.WriteInt(int.Parse(t[28]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;


                case "2260":
                    ar.WriteByte(9);
                    ar.WriteByte(1);
                    ar.WriteInt(int.Parse(t[23]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2261":
                    ar.WriteByte(9);
                    ar.WriteByte(2);
                    ar.WriteInt(int.Parse(t[23]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2262":
                    ar.WriteByte(9);
                    ar.WriteByte(3);
                    ar.WriteInt(int.Parse(t[23]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2263":
                    ar.WriteByte(9);
                    ar.WriteByte(4);
                    ar.WriteInt(int.Parse(t[23]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2264":
                    ar.WriteByte(9);
                    ar.WriteByte(5);
                    ar.WriteInt(int.Parse(t[23]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2210":
                    ar.WriteByte(0);
                    ar.WriteInt(int.Parse(t[36]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2220":
                    ar.WriteByte(1);
                    ar.WriteInt(int.Parse(t[22]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2230":
                    ar.WriteByte(2);
                    ar.WriteInt(int.Parse(t[13]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "8010":

                    ar.WriteByte(100);
                    ar.WriteInt(int.Parse(t[27]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "8020":

                    ar.WriteByte(101);
                    ar.WriteInt(int.Parse(t[28]));
                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "2231":
                    ar.WriteByte(3);
                    ar.WriteInt(int.Parse(t[13]));


                    if (byte.Parse(k.Remove(0, k.Length - 2)) > 7)
                    {
                        ar.WriteByte(0);
                    }
                    else
                    {
                        ar.WriteByte(1);
                        ar.WriteByte(8 + (byte.Parse(k[k.Length - 1].ToString()) * 4));
                        ar.WriteInt(int.Parse(k) + 1);
                    }

                    System.IO.File.WriteAllBytes("scripts\\" + k + ".script", ar.GetByteArray());
                    ar.Close();
                    return;

                case "1114":

                    int id = int.Parse(k);
                    byte level;
                    byte type;
                    //  itm = Players.GetPlayer(c).bag.bags[4].items[ix];

                    level = (byte)((id - 1114001) / 8);

                    type = (byte)((id - 1114001) - (level * 8));


                    switch(type)
                    {
                        case 0:
                            id = int.Parse(t[27]);
                            break;
                        case 1:
                            id = int.Parse(t[28]);
                            break;
                        case 2:
                            id = int.Parse(t[29]);
                            break;
                        case 3:
                            id = int.Parse(t[30]);
                            break;
                        case 4:
                            id = int.Parse(t[33]);
                            break;
                        case 5:
                            id = int.Parse(t[32]);
                            break;
                        case 6:
                            id = int.Parse(t[34]);
                            break;
                        case 7:
                            id = int.Parse(t[31]);
                            break;
                      
                    }


                    System.IO.File.AppendAllText("gemout.txt", level.ToString() + "%" + type.ToString() + "%" + id.ToString() + ",");

                    return;

                case "9010":

                    PackBuild bld = new PackBuild(t[2]);
                    bld.Text = t[1];
                    List<string> items = new List<string>();
                    int err = 0;
                    List<string> itemd = new List<string>();
                start: ;
                    if (bld.ShowDialog(this) == true)
                    {
                        items.Clear();
                        itemd.Clear();
                        try
                        {
                            string[] lns = bld.GetLines;

                            for (int x = 0; x < lns.Length; x++)
                            {

                                if (lns[x].Replace(" ", "") == "") continue;
                                string[] dats = lns[x].Trim(" ".ToCharArray()).Split("*".ToCharArray());


                                string gid = FindId(dats[0]);

                                #region Validates
                                if (gid == "")
                                {
                                    if (MessageBox.Show(dats[0] + " not found!\n try again?", "Error item not found", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                                    {
                                        err++;
                                        // itemd = new List<string>();
                                        goto start;
                                    }
                                }

                                byte val;

                                if (!byte.TryParse(dats[1], out val))
                                {
                                    if (MessageBox.Show("\" " + dats[1] + "\" invalid!\n try again?", "Error invalid item count", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
                                    {
                                        err++;
                                        //  itemd = new List<string>();
                                        goto start;
                                    }

                                }

                                #endregion

                                items.Add(gid + "|" + dats[1]);
                                if (err != 0) itemd.Add(dats[0] + "*" + dats[1]);
                            }
                        }
                        catch
                        {
                            items.Clear();
                            MessageBox.Show("An error happend somewhere!\nCannot recover from it.\nContinue with the task");
                            goto start;
                            //  return;
                        }

                        ar = new ByteArray();
                        // ar.WriteByte(1);
                        ar.WriteByte(1);
                        ar.WriteByte(items.Count);
                        string[] datas;
                        for (int x = 0; x < items.Count; x++)
                        {
                            datas = items[x].Split("|".ToCharArray());
                            ar.WriteInt(int.Parse(datas[0]));
                            ar.WriteByte(byte.Parse(datas[1]));
                        }
                        ar.SaveFile("scripts\\" + k + ".script");
                        ar.Close();

                        if (err != 0)
                        {
                            string mod = "Contains: ";

                            for (int x = 0; x < items.Count; x++)
                            {
                                mod += itemd[x] + ",";
                            }
                            mod = mod.TrimEnd(",".ToCharArray());

                            t[2] = mod;

                            System.IO.File.WriteAllLines("goods\\" + k, t);
                        }
                        items.Clear();
                    }


                    break;


            }


            if (key.StartsWith("10"))
            {
                BuildEquip(k,key,t,ar);
            }
        }


        public void BuildEquip(string k, string key, string[] t, ByteArray ar)
        {
          //  ByteArray ar= new 


            //stypes
            // hp
            // mp

            //atk
            //def

            //str
            //int
            //agi

            //hit
            //dod
            //crit
            //fort
            
            short tt = 32767;
            tt = 1;
            if (tt != 1)
            {
            }
                   
            ar.WriteByte(byte.Parse(t[14]));  
            ar.WriteByte(byte.Parse(t[21]));
            

            switch(key)
            {

                case "1010":

                    ar.WriteByte(3);
                    ar.WriteShort(int.Parse(t[29]));
                    
                    break;

                case "1020":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1021":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1022":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1023":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1024":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1025":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1030":
        
                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1031":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1032":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1033":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1040":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;

                case "1050":

                    ar.WriteByte(1);
                    ar.WriteShort(int.Parse(t[29]));
                    break;


            }

            ar.WriteByte(byte.Parse(t[43]));


        }


    
    

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void importXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // string key = k.Remove(4);

            string[] t;
            string k="";

            Dictionary<int, List<int>> costs= new Dictionary<int,List<int>>();

            for (int x = 0; x < itemtree.Nodes.Count; x++)
            {
                    k = itemtree.Nodes[x].Name;
                if(System.IO.File.Exists("goods\\" +k))
                {
                    

                    t = System.IO.File.ReadAllLines("goods\\" + k);
                    int id= int.Parse(t[0]);
                    int cost=int.Parse(t[13]);


                    if(!costs.ContainsKey(cost)) costs.Add(cost,new List<int>());

                    costs[cost].Add(id);

                }
                
            }

            System.IO.StreamWriter rw = new System.IO.StreamWriter("item.cs");


            rw.WriteLine("\t\tpublic static int GetCost(int id)");
            rw.WriteLine("\t\t{");
            rw.WriteLine();
            rw.WriteLine("\t\t\tswitch(id)");
            rw.WriteLine("\t\t\t{");

            int[] costk = new int[costs.Count];

            costs.Keys.CopyTo(costk, 0);

            for (int x = 0; x < costk.Length; x++)
            {
                costs[costk[x]].Sort();

                for (int y = 0; y < costs[costk[x]].Count; y++)
                {
                    rw.WriteLine("\t\t\t\tcase " + costs[costk[x]][y].ToString() + ":");
                }
                rw.WriteLine("\t\t\t\treturn " + costk[x] + ";");

            }

            rw.WriteLine("\t\t\t}");
            rw.WriteLine();
            rw.WriteLine("\t\t\treturn 0;");
            rw.WriteLine("\t\t}");
            rw.Close();
        }

        private void toWeaponStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                       // string key = k.Remove(4);

            string[] t;
            string k="";

            Dictionary<int, string> costs= new Dictionary<int,string>();

            for (int x = 0; x < itemtree.Nodes.Count; x++)
            {
                         k = itemtree.Nodes[x].Name;
                if (int.Parse(k) >= 1110001) break;

   
                if (System.IO.File.Exists("goods\\" + k))
                { 
                    t = System.IO.File.ReadAllLines("goods\\" + k);
                    string v = "";
                    switch (k.Substring(0, 4))
                    {

                        case "1010": //Weapon
                            v = string.Concat(new string[] { "3", ",", t[29] });

                            break;

                        case "1020"://Hood
                            v = string.Concat(new string[] { "1", ",", t[27] });
                            break;

                        case "1021"://Robe
                            v = string.Concat(new string[] { "4", ",", t[30] });
                            break;

                        case "1022"://Pants
                            v = string.Concat(new string[] { "8", ",", t[34] });
                            break;

                        case "1023"://Boots
                            v = string.Concat(new string[] { "2", ",", t[28] });
                            v += "|" + string.Concat(new string[] { "6", ",", t[32] });
                            break;
                        case "1024":// Belt
                            v = string.Concat(new string[] { "4", ",", t[30] });
                            break;

                        case "1025":// Gloves
                            v = string.Concat(new string[] { "2", ",", t[28] });
                            v += "|" + string.Concat(new string[] { "5", ",", t[31] });
                            break;

                        case "1030":
                            v = string.Concat(new string[] { "4", ",", t[30] });
                            break;

                        case "1031":
                            v = string.Concat(new string[] { "4", ",", t[30] });
                            break;

                        case "1032":
                            v = string.Concat(new string[] { "3", ",", t[29] });
                            break;

                        case "1033":
                            v = string.Concat(new string[] { "1", ",", t[27] });
                            v += "|" + string.Concat(new string[] { "7", ",", t[33] });
                            break;

                        case "1040":

                            for (byte i = 27; i < 31; i++)
                            {
                                if(t[i]!="0")
                                v += string.Concat(new string[] { (i-26).ToString(), ",", t[i] })+"|";
                            }
                            v = v.TrimEnd("|".ToCharArray());
                            break;

                        case "1050":
                                                        
                            v = string.Concat(new string[] { "3", ",", t[29] });
                            v += "|" + string.Concat(new string[] { "5", ",", t[31] });
                            v += "|" + string.Concat(new string[] { "7", ",", t[33] });
                            break;


                    }

                    v = t[43] +t[21]+ "?" + v;
                    costs.Add(int.Parse(k), v);
                }

            }

            System.IO.StreamWriter rw = new System.IO.StreamWriter("itemstats.cs");


            rw.WriteLine("\t\tpublic static void GetCost(int id)");
            rw.WriteLine("\t\t{");
            rw.WriteLine();
            rw.WriteLine("\t\t\tswitch(id)");
            rw.WriteLine("\t\t\t{");

            int[] costk = new int[costs.Count];

            costs.Keys.CopyTo(costk, 0);
            
            for (int x = 0; x < costk.Length; x++)
            {
                ByteArray aa = new ByteArray();
                rw.WriteLine("\t\t\t\tcase " + costk[x].ToString() + ":");
                string[] cats = costs[costk[x]].Split("?".ToCharArray());

                string[] stats = cats[1].Split("|".ToCharArray());

                rw.WriteLine("\t\t\t\tb.Color="+cats[0].Substring(0,1)+";");
                rw.WriteLine("\t\t\t\tb.Level=" + cats[0].Substring(1) + ";");

                aa.WriteByte(byte.Parse(cats[0].Substring(0, 1)));
                aa.WriteByte(byte.Parse(cats[0].Substring(1)));

                aa.WriteByte(stats.Length);
                for (int y = 0; y < stats.Length; y++)
                {
                    string[] stat = stats[y].Split(",".ToCharArray());
                    rw.WriteLine("\t\t\t\tb.BaseStats.Add(new Bag.ItemStat("+stat[0]+","+stat[1]+"));");
                    aa.WriteByte(byte.Parse(stat[0]));
                    aa.WriteInt(int.Parse(stat[1]));

                }
                aa.SaveFile("weapons_stats\\" + costk[x].ToString());
                aa.Close();


                rw.WriteLine("\t\t\t\tbreak;");

            }

            rw.WriteLine("\t\t\t}");
            rw.WriteLine();
   
            rw.WriteLine("\t\t}");
            rw.Close();
        
        }

        private void toItemListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // string key = k.Remove(4);
            ByteArray ar = new ByteArray();


            string[] t;
            string k = "";

            ar.WriteInt(itemtree.Nodes.Count);
            ar.WriteByte(1);

            for (int x = 0; x < itemtree.Nodes.Count; x++)
            {
                k = itemtree.Nodes[x].Name;
                if (int.Parse(k) >= 1110001) break;


                if (System.IO.File.Exists("goods\\" + k))
                {
                    t = System.IO.File.ReadAllLines("goods\\" + k);

                    int x2 = -1;

                    ar.WriteInt(t[x2++]);
                    ar.WriteString(t[x2++]);
                    ar.WriteString(t[x2++]);

                    ar.WriteByte(t[x2++]);

                }

            }
        }
    }
}

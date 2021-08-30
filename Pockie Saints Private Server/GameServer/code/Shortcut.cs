 using System;
using System.Collections.Generic;
using System.Text;
namespace GameServer
{
   
    public class Shortcut
    {
        //const string file = "shortcuts";
        ConnectionInfo c;
        
        public class ShortcutItem
        {
           [ContentProto("slotid")]
            public byte index { get; set; }

            [ContentProto("itemid")]
            public int Itemid { get; set; }

            [ContentProto("itype")]
            public byte type { get; set; }

            public ShortcutItem()
            {
            }

            public ShortcutItem(byte Index,int ItemID,byte Type)
            {
                index = Index;
                Itemid = ItemID;
                type = Type;
            }
        }


        public List<ShortcutItem> shortcut{ get; set; }

        public Shortcut(ConnectionInfo cc)
        {
            c = cc;
            shortcut = new List<ShortcutItem>();
        }

        public bool Add(byte slot, int id, byte type)
        {

            int p = shortcut.FindIndex(delegate(ShortcutItem s) { return slot == s.index; });
            ShortcutItem si = new ShortcutItem();
            si.Itemid = id;
            si.index = slot;
            si.type = type;

            if (p != -1)
            {
                if (UpdateSlot(si))
                {
                    shortcut[p] = si;
                    return true;
                }
            }
            else
            {
                c.con.StartCommand("INSERT INTO shortcut(roleid, slotid, itemid, itype) VALUES (?,?,?,?);");
                c.con.AddValue(c.rlid);
                c.con.AddValue(si.index);
                c.con.AddValue(si.Itemid);
                c.con.AddValue(si.type);
    
                if (c.con.ExecuteNoneQuery() > 0)
                {
                    shortcut.Add(si);
                    return true;
                }
            }


            return false;
        }

        public bool UpdateSlot(ShortcutItem si)
        {
            c.con.StartCommand("UPDATE shortcut SET itemid=?,itype=? WHERE slotid=? AND roleid=?;");
            c.con.AddValue(si.Itemid);
            c.con.AddValue(si.type);
            c.con.AddValue(si.index);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool UpdateSlot(ShortcutItem si,byte last)
        {
            c.con.StartCommand("UPDATE shortcut SET itemid=?,itype=?,slotid=? WHERE slotid=? AND roleid=?;");
            c.con.AddValue(si.Itemid);
            c.con.AddValue(si.type);
            c.con.AddValue(si.index);
            c.con.AddValue(last);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        public bool Remove(byte slot)
        {

            int p = shortcut.FindIndex(delegate(ShortcutItem s) { return slot == s.index; });

            if (p == -1) return false;

            c.con.StartCommand("DELETE FROM shortcut WHERE slotid=? AND roleid=?;");
            c.con.AddValue(slot);
            c.con.AddValue(c.rlid);

            if (c.con.ExecuteNoneQuery() > 0 )
            {
                shortcut.RemoveAt(p);
                return true;
            }

            return false;
        }

        public bool Swap(byte slot1, byte slot2)
        {
            int s1, s2;

            s1 = shortcut.FindIndex(delegate(ShortcutItem s) { return slot1 == s.index; });

            s2 = shortcut.FindIndex(delegate(ShortcutItem s) { return slot2 == s.index; });

            if (s1 == -1 ) return false;
                ShortcutItem m = shortcut[s1];

            if(s2 ==-1)
            {
                byte last = 0;
                last = m.index;
                m.index = slot2;

                if (!UpdateSlot(m,last)) return false;

                shortcut[s1] = m;
            }
            else
            {

                byte last = 0;
                last = m.index;
                m.index = slot2;

                if (!UpdateSlot(m)) return false;

                shortcut[s1] = m;
                /////////////////////////////////////////

                m = shortcut[s2];
                m.index = slot1;

                if (!UpdateSlot(m)) return false;
                shortcut[s2] = m;
            }


            return true;
        }

        public bool Load()
        {
            //ByteC.LoadProto(c.accid + file, ref inst);

            c.con.StartCommand("SELECT slotid, itemid, itype FROM shortcut WHERE roleid=?;");
            c.con.AddValue(c.rlid);

            Connector.DataReader rd = c.con.ExecuteRead();

            bool set = rd.CanRead;

            if (set)
            {
                while (rd.NextRow())
                {
                    shortcut.Add(new ShortcutItem(rd.ReadByte(), rd.ReadInt(), rd.ReadByte()));
                }
            }
            rd.Close();

            return set;
        }


    }

}

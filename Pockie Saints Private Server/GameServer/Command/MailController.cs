using System;

using System.Collections;

namespace GameServer.Command
{

    internal static class MailController
    {

        internal static void c19001(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "MailController 19001");


        }

        internal static void c19002(ConnectionInfo c)
        {
            //	Program.Write(">Command invoked: " +"MailController 19002");


            int id = c.ar.ReadInt();

            //int ix = c.Player.mail.mails.FindIndex(delegate(Mail.MailItem n) { return n.mailid == id; });

            c.con.StartCommand("SELECT mailid,mailtime, sender,title,mailmsg,itemid,itemtype,itemnum,gold,bcrystal,crystal,bgold,mailstatus FROM mail WHERE mailid=? AND roleid=? LIMIT 1;");
            c.con.AddValue(id);
            c.con.AddValue(c.rlid);
            Connector.DataReader rd = c.con.ExecuteRead();

            if (rd.CanRead && rd.NextRow())
            {

                // Mail.MailItem m = c.Player.mail.mails[ix];

                c.ot.WriteShort(1);
                c.ot.WriteInt(rd.ReadInt());//id);
                c.ot.WriteInt(rd.ReadInt());//m.time);
                c.ot.WriteString(rd.ReadString());//m.sender);
                c.ot.WriteString(rd.ReadString());//m.title);
                c.ot.WriteString(rd.ReadString());//m.mailmsg);

                c.ot.WriteInt(rd.ReadInt());//m.itemid);
                c.ot.WriteInt(rd.ReadInt());//m.itemtype);
                c.ot.WriteInt(rd.ReadInt());//m.itemnum);

                c.ot.WriteInt(rd.ReadInt());//m.gold);
                c.ot.WriteInt(rd.ReadInt());//m.bcrystal);
                c.ot.WriteInt(rd.ReadInt());//m.crystal);
                c.ot.WriteInt(rd.ReadInt());//m.bgold);


                if (rd.ReadByte() == 2)
                {
                    c.con.ExecuteNoneQuery("UPDATE mail SET mailstatus=1 WHERE mailid=" + id.ToString());

                    /* m.mailstatus = 1;
                     c.Player.mail.mails[ix] = m;
                     c.Player.mail.Save(c);*/
                }


            }
            else
            {
                c.ot.WriteBytes(new byte[44]);
            }
            rd.Close();
            rd = null;
            c.ot.PackArray(19002);
        }

        internal static void c19003(ConnectionInfo c)
        {

            int mailcount = c.ar.ReadShort();
            short res = 2;

            if (mailcount > 0)
            {
                if (mailcount == 1)
                {
                    c.con.StartCommand("DELETE FROM mail WHERE mailid=? AND roleid=?;");
                    c.con.AddValue(c.ar.ReadInt());
                    c.con.AddValue(c.rlid);


                }
                else
                {

                    c.con.StartCommand("DELETE FROM mail WHERE roleid=? AND (?);");
                    c.con.AddValue(c.rlid);
                    string del = "";
                    for (int x = 0; x < mailcount; x++)
                    {

                        int id = c.ar.ReadInt();

                        del += "mailid=" + id.ToString() + " OR ";
                        /* int ix = c.Player.mail.mails.FindIndex(delegate(Mail.MailItem n) { return n.mailid == id; });

                         if (ix != -1)
                         {
                             c.Player.mail.mails.RemoveAt(ix);
                             // c.ot.WriteShort(1);

                         }*/

                    }

                    del = del.Remove(del.Length - 4);
                    c.con.AddValue(del, true);
                }

                res = (short)(c.con.ExecuteNoneQuery() == 1 ? 1 : 2);
            }

            c.ar.Close();
            c.ot.WriteShort(res);
            c.ot.PackArray(19003);
        }

        internal static void c19004(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"MailController 19004");
            c.ar.Close();


            c.con.StartCommand("SELECT mailid,mailtype,mailstatus,mailtime,sender,title,hasitem FROM mail WHERE roleid=? ORDER BY mailtime desc;");
            c.con.AddValue(c.rlid);
            Connector.DataReader rd = c.con.ExecuteRead();

            c.ot.WriteShort(1);
            c.ot.WriteInt((int)DateUtil.GetDateIntZone());

            if (rd.CanRead)
            {
                c.ot.WriteShort(rd.Rows);//c.Player.mail.mails.Count);

                while (rd.NextRow())
                {
                    c.ot.WriteInt(rd.ReadInt());//m.mailid);
                    c.ot.WriteShort(rd.ReadShort());//m.mailtype);
                    c.ot.WriteShort(rd.ReadShort());//m.mailstatus);
                    c.ot.WriteInt(rd.ReadInt());//m.time);
                    c.ot.WriteString(rd.ReadString());//m.sender);
                    c.ot.WriteString(rd.ReadString());//m.title);
                    c.ot.WriteShort(rd.ReadShort());//m.hasitem);
                }
                /* for (short i = 0; i < c.Player.mail.mails.Count; i++)
                 {
                     Mail.MailItem m = c.Player.mail.mails[i];

                     c.ot.WriteInt(m.mailid);
                     c.ot.WriteShort(m.mailtype);
                     c.ot.WriteShort(m.mailstatus);
                     c.ot.WriteInt(m.time);
                     c.ot.WriteString(m.sender);
                     c.ot.WriteString(m.title);
                     c.ot.WriteShort(m.hasitem);
                 }*/

            }
            else
            {
                c.ot.WriteShort(0);
            }
            rd.Close();

            c.ot.PackArray(19004);
        }

        internal static void c19005(ConnectionInfo c)
        {

            short n = 0;

            c.con.StartCommand("SELECT COUNT(*) FROM mail WHERE roleid=? AND mailstatus=2;");
            c.con.AddValue(c.rlid);
            object o = c.con.ExecuteScalar();

            if (o != null)
            {
                n = Convert.ToInt16(o);
            }

            c.ot.WriteShort(n > 0 ? 1 : 0);
            c.ot.PackArray(19005);
        }

        internal static void c19006(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"MailController 19006");

            int id = c.ar.ReadInt();

            c.con.StartCommand("SELECT itemtype,itemnum,gold,bcrystal,crystal,bgold FROM mail WHERE mailid=? AND roleid=? AND claimed=0 LIMIT 1;");
            c.con.AddValue(id);
            c.con.AddValue(c.rlid);
            Connector.DataReader rd = c.con.ExecuteRead();
            short res = 3;

            if (rd.CanRead && rd.NextRow())
            {

                // Mail.MailItem m = c.Player.mail.mails[ix];
                int itemtype = rd.ReadInt();
                int itemnum = rd.ReadInt();

                int gold = rd.ReadInt();
                int bcrystal = rd.ReadInt();
                int crystal = rd.ReadInt();
                int bgold = rd.ReadInt();



                if (itemtype == 0)
                {
                    c.Player.bag.bcrystal += bcrystal;
                    c.Player.bag.crystal += crystal;
                    c.Player.bag.bgold += bgold;
                    c.Player.bag.gold += gold;
                    c.Player.bag.Save();

                    res = 1;
                    // c.con.ExecuteNoneQuery("UPDATE mail SET itemtype=0,itemnum=0,gold=0;bgold=0,crystal=0,bcrystal=0,claimed=1 WHERE mailid=" + id.ToString());

                }
                else
                {


                    if (c.Player.bag.CanBagAdd(1) && c.Player.bag.AddBagItem(itemtype, (byte)itemnum, 2))
                    {
                        c.Player.bag.bcrystal += bcrystal;
                        c.Player.bag.crystal += crystal;
                        c.Player.bag.bgold += bgold;
                        c.Player.bag.gold += gold;
                        c.Player.bag.Save();

                        res = 1;
                    }
                    else
                    {
                        res = 2;
                    };
                }

            }


            rd.Close();
            rd = null;


            if (res == 1)
            {
                c.con.ExecuteNoneQuery("UPDATE mail SET itemtype=0,itemnum=0,gold=0,bgold=0,crystal=0,bcrystal=0,hasitem=0,claimed=1 WHERE mailid=" + id.ToString());
            }
            c.ot.WriteShort(res);
            c.ot.WriteInt(id);
            c.ot.PackArray(19006);
        }

        internal static void c19010(ConnectionInfo c)
        {
            Program.Write(">Command invoked: " + "MailController 19010");


        }

    }
}

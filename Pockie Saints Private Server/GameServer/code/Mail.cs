using System;
using System.Collections.Generic;
using System.Text;


namespace GameServer
{

    public class Mail
    {

        /*  const string file = "mail";
          [ProtoMember(1)]
          public List<MailItem> mails{ get; set; }

          [ProtoMember(2)]
          public int NextID{ get; set; }

          [ProtoContract]
          public class MailItem
          {
              [ProtoMember(1)]
              public int mailid{ get; set; }

              [ProtoMember(2)]
              public byte mailtype{ get; set; }

              [ProtoMember(3)]
              public byte mailstatus{ get; set; }

              [ProtoMember(4)]
              public int time{ get; set; }

              [ProtoMember(5)]
              public string sender{ get; set; }

              [ProtoMember(6)]
              public string title{ get; set; }

              [ProtoMember(7)]
              public byte hasitem{ get; set; }

              [ProtoMember(8)]
              public string mailmsg{ get; set; }

              [ProtoMember(9)]
              public int itemid{ get; set; }

              [ProtoMember(10)]
              public int itemtype{ get; set; }

              [ProtoMember(11)]
              public int itemnum{ get; set; }

              [ProtoMember(12)]
              public int gold{ get; set; }

              [ProtoMember(13)]
              public int bgold{ get; set; }

              [ProtoMember(14)]
              public int crystal{ get; set; }

              [ProtoMember(15)]
              public int bcrystal{ get; set; }

              [ProtoMember(16)]
              public byte claimed{ get; set; }

              public MailItem()
              {
              }
          }

          public Mail()
          {
              mails = new List<MailItem>();
          }

        

          public int GetID()
          {
              NextID++;
              return NextID-1;
          }

          public static void Load<t>(ConnectionInfo c, ref t val)
          {
              ByteC.LoadProto(c.accid + file, ref val);
          }

          public void Save(ConnectionInfo c)
          {
              ByteC.SaveProto(c.accid + file, this);
          }

          public static void Create(ConnectionInfo c)
          {
              Mail m = new Mail();
              m.NextID = 1;

              m.Save(c);
              m = null;
              //System.IO.File.WriteAllBytes(c.charDir + "mail", new byte[]{0,0,0,1,0,0});
          }*/


        public static bool AddMail(int roleid, string Title, String Msg)
        {
            return AddMail(roleid, Title, Msg, 0, 0, 0, 0, 0, 0);
        }

        public static bool AddMail(int roleid, string title, string msg, int item, int count)
        {
            return AddMail(roleid, title, msg, 0, 0, 0, 0, item, count);
        }

        public static bool AddMail(int roleid, string Title, String Msg, int gold, int bgold, int crystal, int bcrystal, int itemtype, int itemcount)
        {

            Connector.MySqlConnector con = DatabaseInfo.GetConnection();

            con.StartCommand("INSERT INTO mail(mailtype,mailstatus,mailtime,hasitem,sender,title,mailmsg,itemid,itemtype,itemnum,gold,bgold,crystal,bcrystal,claimed,roleid)"
                            + " VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);");
            con.AddValue(1);// mailtype
            con.AddValue(2);// mailstatus
            con.AddValue((int)DateUtil.GetDateIntZone());
            con.AddValue(itemcount != 0 ? (byte)1 : (byte)0);
            con.AddValue("Server");
            con.AddValue(Title);
            con.AddValue(Msg);
            con.AddValue(0);//itemid
            con.AddValue(itemtype);
            con.AddValue(itemcount);
            con.AddValue(gold);
            con.AddValue(bgold);
            con.AddValue(crystal);
            con.AddValue(bcrystal);


            if ((itemtype>0 &&itemcount > 0) || gold > 0 || bgold > 0 || crystal > 0 || bcrystal > 0)
            {
                con.AddValue(0);// claimed
            }
            else
            {
                con.AddValue(1);
            }
            con.AddValue(roleid);

            bool ok = con.ExecuteNoneQuery() == 1;
            con = null;
            return ok;
        }


        public static void OfflineMessage(int roleid, string Title, String Msg)
        {
            OfflineMessage(roleid, Title, Msg, 0, 0, 0, 0, 0, 0);
        }

        public static void OfflineMessage(int roleid, string title, string msg, int item, int count)
        {
            OfflineMessage(roleid, title, msg, 0, 0, 0, 0, item, count);
        }

        public static void OfflineMessage(int roleid, string Title, String Msg, int gold, int bgold, int crystal, int bcrystal, int itemtype, int itemcount)
        {

            if (AddMail(roleid, Title, Msg, gold, bgold, crystal, bcrystal, itemtype, itemcount))
            {
                RoleControl rl = Players.GetPlayer(roleid);
                if (rl != null)
                {
                    ByteArray ar = new ByteArray();

                    ar.WriteShort(1);
                    ar.PackArray(19005);

                    rl.Send(ar.GetByteArray());

                    ar.Close();
                    ar = null;
                }
            }

        }
    }
}

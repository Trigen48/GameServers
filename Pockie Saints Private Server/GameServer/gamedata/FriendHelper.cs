using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    internal static class FriendHelper
    {
        internal static bool AddGroups(int roleid)
        {
            ConnectionInfo c = new ConnectionInfo(roleid);
            c.con.StartCommand("INSERT INTO friendgroup(roleid,fgroupid,fgroupdesc) VALUES(?,1,'All'),(?,2,'My group 1'),(?,3,'My Group 2');");

            c.con.AddValue(roleid);
            c.con.AddValue(roleid);
            c.con.AddValue(roleid);

            return c.con.ExecuteNoneQuery() > 0;
        }
        internal static bool AddFriend(ConnectionInfo c, int friendid)
        {
            c.con.StartCommand("INSERT INTO friend(roleid,friendid) VALUES(?,?),(?,?);");

            c.con.AddValue(c.rlid);
            c.con.AddValue(friendid);


            c.con.AddValue(friendid);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        internal static bool AddEnemy(ConnectionInfo c, int eid)
        {
            c.con.StartCommand("INSERT INTO friend(roleid,friendid,fgroupid) VALUES(?,?,3),(?,?,4);");

            c.con.AddValue(c.rlid);
            c.con.AddValue(eid);


            c.con.AddValue(eid);
            c.con.AddValue(c.rlid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        internal static bool ChangeToFriend(ConnectionInfo c, int friendid)
        {
            c.con.StartCommand("UPDATE friend SET ftypeid=1 WHERE (roleid=? AND friendid=?) OR (roleid=? AND friendid=?);");
     
            c.con.AddValue(c.rlid);
            c.con.AddValue(friendid);

            c.con.AddValue(friendid);
            c.con.AddValue(c.rlid);


            return c.con.ExecuteNoneQuery() > 0;
        }
        internal static bool DeleteFriend(ConnectionInfo c, int friendid)
        {

            c.con.StartCommand("DELETE FROM friend WHERE (roleid=? AND friendid=?) OR (roleid=? AND friendid=?);");


            c.con.AddValue(c.rlid);
            c.con.AddValue(friendid);


            c.con.AddValue(friendid);
            c.con.AddValue(c.rlid);


            return c.con.ExecuteNoneQuery() > 0;
        }


        internal static bool BlackListFriend(ConnectionInfo c, int friendid)
        {
            c.con.StartCommand("UPDATE friend SET ftypeid=2 WHERE roleid=? AND friendid=? AND ftypeid=1;");

            c.con.AddValue(c.rlid);
            c.con.AddValue(friendid);

            return c.con.ExecuteNoneQuery() > 0;
        }

        internal static void GetBlackList(ConnectionInfo c)
        {
            c.con.StartCommand("SELECT f.friendid,r.isonline,r.lvl,r.sex,r.career,r.faction,v.viplvl,r.constellation,r.charname FROM friend f INNER JOIN role r ON f.friendid=r.roleid INNER JOIN vip v ON v.roleid= r.roleid WHERE f.roleid=? AND f.ftypeid=2;");
            c.con.AddValue(c.rlid);
     
            Connector.DataReader rd = c.con.ExecuteRead();

            if (rd.CanRead)
            {
                c.ot.WriteShort(rd.Rows);

                while (rd.NextRow())
                {

                 
                    c.ot.WriteInt(rd.ReadInt());//roleid
                    c.ot.WriteByte(rd.ReadByte());//isonline


                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].level);
                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].sex);
                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].carear);
                    c.ot.WriteByte(rd.ReadByte());//c.Player.friends.Friends[0].friends[ids[i]].faction);
                    c.ot.WriteByte(rd.ReadByte());//c.Player.friends.Friends[0].friends[ids[i]].vip);
                    c.ot.WriteByte(rd.ReadByte());//c.Player.friends.Friends[0].friends[ids[i]].constelation);
                    c.ot.WriteString(rd.ReadString());//c.Player.friends.Friends[0].friends[ids[i]].name);
                }
            }
            else
            {
                c.ot.WriteShort(0);
            }

            rd.Close();
        }

        
        internal static void GetEnemy(ConnectionInfo c)
        {
            c.con.StartCommand("SELECT r.isonline,f.friendid,r.lvl,r.sex,r.career,r.faction,v.viplvl,r.constellation,r.charname FROM friend f INNER JOIN role r ON f.friendid=r.roleid INNER JOIN vip v ON v.roleid= r.roleid WHERE f.roleid=? AND f.ftypeid=3;");
            c.con.AddValue(c.rlid);
            Connector.DataReader rd = c.con.ExecuteRead();

            if (rd.CanRead)
            {
                c.ot.WriteShort(rd.Rows);

                while (rd.NextRow())
                {

                    c.ot.WriteShort(rd.ReadByte());//isonline
                    c.ot.WriteInt(rd.ReadInt());//roleid
    
                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].level);
                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].sex);
                    c.ot.WriteShort(rd.ReadShort());//c.Player.friends.Friends[0].friends[ids[i]].carear);
                    c.ot.WriteByte(rd.ReadByte());//c.Player.friends.Friends[0].friends[ids[i]].faction);
                    c.ot.WriteByte(rd.ReadByte());//c.Player.friends.Friends[0].friends[ids[i]].vip);
                    c.ot.WriteByte(rd.ReadByte());//c.Player.friends.Friends[0].friends[ids[i]].constelation);
                    c.ot.WriteString(rd.ReadString());//c.Player.friends.Friends[0].friends[ids[i]].name);
                }
            }
            else
            {
                c.ot.WriteShort(0);
            }

            rd.Close();
        }


        internal static bool AddIntimacy(ConnectionInfo c, int friendid,int intimacy)
        {
            c.con.StartCommand("UPDATE friend SET intimacy= intimacy+? WHERE (roleid=? AND friendid=?) OR (roleid=? AND friendid=?) AND ftypeid=1;");
            c.con.AddValue(intimacy);
           
            c.con.AddValue(c.rlid);
            c.con.AddValue(friendid);

            c.con.AddValue(friendid);
            c.con.AddValue(c.rlid);


            return c.con.ExecuteNoneQuery() > 0;
        }

        internal static bool NotBlackListed(ConnectionInfo c, int friendid)
        {
            c.con.StartCommand("SELECT friendid FROM friend WHERE roleid=? AND friendid=? AND ftypeid!=2 LIMIT 1;");
            c.con.AddValue(friendid);           
            c.con.AddValue(c.rlid);


            object o = c.con.ExecuteScalar();

            return o != null && Convert.ToInt32(o) > 0;
        }

        /*internal static bool IsListed(ConnectionInfo c, int friendid)
        {
            c.con.StartCommand("SELECT friendid FROM friend WHERE roleid=? AND friendid=? AND ftypeid!=2 LIMIT 1;");
            c.con.AddValue(friendid);
            c.con.AddValue(c.rlid);


            object o = c.con.ExecuteScalar();

            return o != null && Convert.ToInt32(o) > 0;
        }*/

        internal static bool MoveToGroup(ConnectionInfo c, int friendid, int group)
        {
            c.con.StartCommand("UPDATE friend SET fgroupid=? WHERE (roleid=? AND friendid=?) AND ftypeid=1;");
            c.con.AddValue(group);
            c.con.AddValue(c.rlid);
            c.con.AddValue(friendid);

            return c.con.ExecuteNoneQuery() > 0;
        
        }

        internal static bool RenameGroup(ConnectionInfo c, int group, string groupname)
        {
            c.con.StartCommand("UPDATE friendgroup SET fgroupdesc=? WHERE roleid=? AND fgroupid=?;");
            c.con.AddValue(groupname);
          
            c.con.AddValue(c.rlid);
            c.con.AddValue(group);

            return c.con.ExecuteNoneQuery() > 0;
        }
    }
}

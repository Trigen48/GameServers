using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace GameServer
{
    public class Guild
    {

        ConnectionInfo c;

        [ContentProto("guildid")]
        public int GuildID { get; set; }

        [ContentProto("gname")]
        public string GuildName { get; set; }

        public Guild(ConnectionInfo cc)
        {
            c = cc;
            GuildName = "";
        }


        public bool Load()
        {
            c.con.StartCommand("SELECT g.guildid,g.gname FROM guild g, guildmember r WHERE g.guildid=r.guildid AND r.roleid=? LIMIT 1;");
            c.con.AddValue(c.rlid);

            Connector.DataReader rd = c.con.ExecuteRead();
            bool l = rd.CanRead ;

            if (l && rd.NextRow())
            {
                GuildID = rd.ReadInt();
                GuildName = rd.ReadString();
            }

            rd.Close();
            return l;

        }

    }
}

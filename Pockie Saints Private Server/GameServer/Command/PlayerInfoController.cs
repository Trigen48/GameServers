using System;

using System.Collections;

namespace GameServer.Command
{

    internal static class PlayerInfoController
    {


        internal static void c39001(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"PlayerInfoController 39001");
            c.Player.title.CheckTitles();

            c.ot.WriteShort(c.Player.title.titles.Count);

            for (byte i = 0; i < c.Player.title.titles.Count; i++)
            {
                c.ot.WriteShort(c.Player.title.titles[i].title_id);
                c.ot.WriteInt(c.Player.title.titles[i].title_time);
            }

            c.ot.PackArray(39001);


            //ot.WriteBytes(x.GetByteArray());
            //ot.Flush();
        }

        internal static void c39002(ConnectionInfo c)
        {
            //Program.Write(">Command invoked: " +"PlayerInfoController 39002");
            c.Player.title.CheckTitles();


            short idx = (short)c.ar.ReadShort();//, idx2 = 0;


            if (idx != 0)
            {
                bool found = false;
                for (byte i = 0; i < c.Player.title.titles.Count; i++)
                {
                    if (c.Player.title.titles[i].title_id == idx)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    c.ot.WriteByte(2);
                    c.ot.PackArray(39002);
                    return;
                }

            }

            if (idx == c.Player.role.title_id)
            {
                c.ot.WriteByte(0);
                c.ot.PackArray(39002);
                return;
            }

            c.Player.role.title_id = idx;
            c.Player.role.Save();

            c.ot.WriteByte(1);
            c.ot.PackArray(39002);
            c.Player.combat.Compute(true);
            //RoleController.SendRoles(c);

            c.currentScene.UpdateTitle(c);
        }

        internal static void c39003(ConnectionInfo c)
        {
            //	Program.Write(">Command invoked: " +"PlayerInfoController 39003");

            c.ot.WriteShort(c.ar.ReadShort());
            c.ot.WriteByte(1);
            c.ot.PackArray(39003);
        }

        internal static void SendTitle(ConnectionInfo c, int id)
        {
            ByteArray ar = new ByteArray();
            ar.WriteShort(id);
            ar.WriteByte(1);
            ar.PackArray(39003);

            byte[] d = ar.GetByteArray();
            ar.Close();
            ar = null;
            c.Player.Send(d);//Players.GetPlayer(c).Send();

            d = null;
        }

        internal static void SendTitles(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();
            ot.WriteShort(c.Player.title.titles.Count);

            for (byte i = 0; i < c.Player.title.titles.Count; i++)
            {
                ot.WriteShort(c.Player.title.titles[i].title_id);
                ot.WriteInt(c.Player.title.titles[i].title_time);
            }

            ot.PackArray(39001);

            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            c.Player.Send(d);//Players.GetPlayer(c).Send();
            ot = null;
        }
    }
}

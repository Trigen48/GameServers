


using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace GameServer
{
    
    public partial class Scene: IDisposable
    {

        public void Temp(ConnectionInfo c)
        {
            ByteArray ot = new ByteArray();

            byte[] d = ot.GetByteArray();
            ot.Close();
            ot = null;

            int[] plz = null;
            lock (players)
            {
                plz = new int[players.Count];
                players.Keys.CopyTo(plz, 0);
            }
            for (int x = 0; x < plz.Length; x++)
            {
                RoleControl rl = Players.GetPlayer(plz[x]);
                if (rl == null) continue;

                if (rl.cc.currentScene.ID == ID)
                    if (!rl.Send(d))
                        Program.CloseConnection(rl.cc);
            }
            d = null;
        }

    }
}

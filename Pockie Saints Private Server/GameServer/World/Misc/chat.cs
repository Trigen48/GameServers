#define Con1

using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer.World
{
    internal static class chat
    {

        internal static void SendWorldMsg(ref byte [] d,int i)
        {
#if Con1
            lock (Program.conns)
            {


                ConnectionInfo[] vals = new ConnectionInfo[Program.conns.Count];
                Program.conns.Values.CopyTo(vals, 0);

                foreach (ConnectionInfo c in vals)
                {
                   // CloseConnection(c);
                    c.Socket.Send(d);
                    
                    try
                    {
                        if (c.rlid == i) continue;

                        lock (c.Socket)
                        {
                            
                        }


                    }
                    catch(Exception ex)
                    {
                        log.Save(ex);
                    }
                }

                vals = null;
                /*conns.Clear();*/

            }
#else
            lock (Program.connections)
            {
                for (int x = 0; x < Program.connections.Count; x++)
                {
                    try
                    {
                        if (Program.connections[x].rlid == i) continue;

                        lock (Program.connections[x].Socket)
                        {
                            Program.connections[x].Socket.Send(d);
                        }
                    }
                    catch (Exception ex)
                    {
                        log.Save(ex);
                    }
                }
            }
#endif

        }

    }
}

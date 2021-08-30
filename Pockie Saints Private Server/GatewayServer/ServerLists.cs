using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace System
{

    internal struct ServerEntity
    {
        public String IP;
        public int Port;
        public byte State;
        public int Count;
        public byte Id;

        public ServerEntity(string ip, int port, byte state, int count, byte id)
        {
            IP = ip;
            Port = port;
            State = state;
            Count = count;
            Id = id;
        }
    }

    internal static class ServerLists
    {

        static List<ServerEntity> lists;
        const string file = "config.log";
        static bool Defined = false;

        internal static void InitServerList()
        {
            if (Defined) return;
            if (lists == null)
                lists = new List<ServerEntity>();

            if (System.IO.File.Exists(file))
            {
                string[] cgf = System.IO.File.ReadAllLines(file);

                for (int x = 0; x < cgf.Length; x++)
                {
                    if (cgf[x].Replace(" ", "") == "") continue;

                    string[] spl = cgf[x].Split(new char[] { '|' });
                    if (spl.Length != 5) continue;

                    try
                    {
                        string ip = spl[0];
                        int port = Convert.ToInt16(spl[1]);
                        byte state = Convert.ToByte(spl[2]), count = Convert.ToByte(spl[3]), id = Convert.ToByte(spl[4]);

                        System.Net.IPAddress.Parse(ip);
                        lists.Add(new ServerEntity(ip, port, state, count, id));
                        Console.WriteLine("Server Loaded- " + ip + ":" + port.ToString());
                    }
                    catch
                    {
                        continue;
                    }
                }

                if (lists.Count == 0)
                {
                    lists.Add(new ServerEntity("127.0.0.1", 6666, 1, 0, 1));
                }
            }
            else
            {
                lists.Add(new ServerEntity("127.0.0.1", 6666, 1, 0, 1));
            }
            // lists.Add(new ServerEntity("127.0.0.1", 6699, 1, 0, 1));

        }

        internal static void InitConfig(config.ConfigLoader cf)
        {
            lists = new List<ServerEntity>();
            int servercount = 0;
            cf.GetInt(ref servercount, "server-count");

            if (servercount > 0)
            {
                for (int x = 0; x < servercount; x++)
                {
                    ServerEntity se = new ServerEntity();
                    bool on = false;

                    cf.GetBool(ref on, "server-active-" + x.ToString());

                    if (on == false)
                        continue;

                    cf.GetInt(ref se.Port, "server-port-" + x.ToString());
                    cf.GetByte(ref se.Id, "server-id-" + x.ToString());
                    cf.GetString(ref se.IP, "server-ip-" + x.ToString());

                    cf.GetByte(ref se.State, "server-state-" + x.ToString());
                    cf.GetInt(ref se.Count, "server-count-" + x.ToString());

                    lists.Add(se);
                }

                if (lists.Count != 0)
                    Defined = true;

            }


        }

        internal static byte[] GetServerBytes()
        {
            ByteArray ar = new ByteArray();

            ar.WriteShort(lists.Count);

            for (int x = 0; x < lists.Count; x++)
            {
                ServerEntity e = lists[x];


                ar.WriteByte(e.Id);
                ar.WriteString(e.IP);
                ar.WriteShort(e.Port);
                ar.WriteByte(e.State);
                ar.WriteShort(e.Count);
            }


            ar.Flush();
            return ar.GetByteArray();
        }

    }
}

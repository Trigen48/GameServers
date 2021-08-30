using System;
using System.Collections.Generic;
using System.Text;

namespace gateway
{
    internal static class Commands
    {
        const int Header = 2;
        public static byte[] Parse(byte[] data, out bool cut)
        {

            try
            {
                int cmd, len;
                cut = false;
                ByteArray ar = new ByteArray(data); // Read Command
                ByteArray ot = new ByteArray();// Out Command

                len = ar.ReadShort();
                cmd = ar.ReadShort();

                Program.WriteLineLog("Received Command: " + cmd.ToString());


                switch (cmd)
                {
                    case 60001:

                        int acc = ar.ReadInt();
                        String v = ar.ReadString();

                        if (v == "" || v.Length == 0)
                        {
                            ar.Close();
                            cut = true;
                            return null;
                        }

                        ot.WriteByte(1);
                        ot.PackArray(60001);
                        ar.Close();
                        return ot.GetByteArray();

                    case 60000:

                        byte[] servers = ServerLists.GetServerBytes();
                        ot.WriteShort(servers.Length + 4);
                        ot.WriteShort(60000);
                        ot.WriteBytes(servers);
                        ot.Flush();
                        servers = null;
                        ar.Close();
                        //cut = true;

                        return ot.GetByteArray();

                    default:
                        throw new Exception();
                }

            }
            catch (Exception ex)
            {
                log.Save(ex);
                Console.WriteLine(ex.ToString());
            }

            cut = true;
            return null;
        }


    }
}

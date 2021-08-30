using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    internal static class ByteTool
    {

        internal static byte[][] GetCommands(byte[] buffer, int lens)
        {

            List<byte[]> l = new List<byte[]>();

            ByteArray ar = new ByteArray(buffer, lens);

            int len = ar.ReadShort();

            while (len > 0 && !ar.Eof())
            {
                try
                {
                    byte[] data = ar.ReadBytes(len - 2);

                    l.Add(data);


                    len = ar.ReadShort();
                }
                catch
                {
                    break;
                }
            }

            ar.Close();

            return l.ToArray();
        }

       /* internal static byte[][] GetCommands(byte[] buffer, int lens)
        {

            List<byte[]> l = new List<byte[]>();
            List<int> codes = new List<int>();


            ByteArray ar = new ByteArray(buffer, lens);
            
            int len = ar.ReadShort();
            ByteArray core = new ByteArray();
            int code = 0;
            while (len > 0 && !ar.Eof())
            {
                try
                {
                    byte[] data = ar.ReadBytes(len - 2);


                    core.WriteShort(len);
                    core.WriteByte(data[0]);
                    core.WriteByte(data[1]);

                    core.Rest();

                    code = core.ReadInt();
                    core.Clear();

                    if (!codes.Contains(code))
                    {
                        l.Add(data);

                        codes.Add(code);
                    }
                    else
                    {
                        Program.Write("Duplicate Command Found!");
                    }

                    len = ar.ReadShort();
                }
                catch
                {
                    break;
                }
            }

            ar.Close();

            return l.ToArray();
        }*/

    }
}

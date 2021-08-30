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
            //  ar.WriteBytes(buffer,lens);
            int len = ar.ReadShort();

            while (len > 0 && !ar.Eof())
            {
                try
                {
                    l.Add(ar.ReadBytes(len - 2));


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

    }
}

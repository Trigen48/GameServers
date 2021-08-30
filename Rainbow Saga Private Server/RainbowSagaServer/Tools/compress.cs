using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowServer
{
    class Zip
    {

        public static ByteArray Compress(ByteArray ar)
        {
            System.IO.MemoryStream mem = new System.IO.MemoryStream();
            byte[] data = ar;
            ZLibNet.ZLibStream sm = new ZLibNet.ZLibStream(mem, ZLibNet.CompressionMode.Compress, ZLibNet.CompressionLevel.BestCompression);
            sm.Write(data, 0, data.Length);
            sm.Flush();
            sm.Close();
            ByteArray t = mem.ToArray();
            mem.Close();
            return t;
        }

        public static ByteArray Decompress(ByteArray ar)
        {
            System.IO.MemoryStream m = new System.IO.MemoryStream();
            byte[] data = ar;
            ZLibNet.ZLibStream df = new ZLibNet.ZLibStream(new System.IO.MemoryStream(data), ZLibNet.CompressionMode.Decompress);
            long tot = df.TotalOut;
            df.CopyTo(m);
            m.Flush();
            df.Close();
            ByteArray t = m.ToArray();
            m.Close();
            return t;
        }
    }
}

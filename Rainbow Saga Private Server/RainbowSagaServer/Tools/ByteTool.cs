using System;
using System.Collections.Generic;
using System.Text;

namespace RainbowServer
{
    internal static class ByteTool
    {

        internal static void SaveProto<t>(string file,ref t inst)
        {
            System.IO.FileStream fs = new System.IO.FileStream(file, System.IO.FileMode.Create);
            ProtoBuf.Serializer.Serialize(fs, inst);
            fs.Flush();
            fs.Close();
            fs = null;
            
        }

        internal static void LoadProto<t>(string file,ref t inst)
        {
            System.IO.FileStream fs = new System.IO.FileStream(file, System.IO.FileMode.Open);
            inst= ProtoBuf.Serializer.Deserialize<t>(fs);
            fs.Close();
            fs = null;

        }
        internal static byte[] GetProto<t>(ref t inst)
        {
            byte[] da = null;
            SaveProto(ref da, ref inst);
            return da;
        }
        internal static void SaveProto<t>(ref byte[] stream, ref t inst)
        {
            System.IO.MemoryStream m = new System.IO.MemoryStream();
            ProtoBuf.Serializer.Serialize(m, inst);
            stream = m.ToArray();
            m.Close();
            m = null;
        }

        internal static void LoadProto<t>(byte[] stream, ref t inst)
        {
            System.IO.MemoryStream m = new System.IO.MemoryStream(stream);
            inst = ProtoBuf.Serializer.Deserialize<t>(m);
            m.Close();
            m = null;

        }
        
        internal static Stack<RequestItem> GetCommands(byte[] buffer)
        {
            Stack<RequestItem> reqs = new Stack<RequestItem>();

            ByteArray ar = buffer;


            while (ar.bytesAvailable > 0)
            {
                RequestItem req = new RequestItem();
                req.MsgType = ar;
                req.MsgID = ar;
                req.Length = ar;
                req.SessionID = ar;
                req.data = ar.ReadBytes((int)req.Length);
                reqs.Push(req);
            }


            ar.Close();
            ar = null;
            return reqs;
        }
    }
}

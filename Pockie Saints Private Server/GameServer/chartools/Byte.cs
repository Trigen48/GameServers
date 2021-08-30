using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    internal static class ByteC
    {
        internal static void Blank(string file)
        {
            System.IO.File.WriteAllBytes(file, new byte[0]);
        }
        internal static void SaveProto<t>(string file, t inst)
        {
            int retry = 0;
            System.IO.FileStream fs = null;
        tt: ;
            try
            {
                if (fs == null)
                    fs = new System.IO.FileStream(file, System.IO.FileMode.Create);

                ProtoBuf.Serializer.Serialize(fs, inst);
                fs.Flush();
                fs.Close();
                fs = null;
            }
            catch (Exception ex)
            {
                if (retry > 3)
                {
                    //retry++;
                    log.Save(ex);

                    try
                    {
                        if (fs != null)
                            fs.Close();
                    }
                    catch (Exception exe)
                    {
                        log.Save(exe);
                    }
                    throw ex;
                }
                else
                {
                    Program.Write(ex.Message);
                    retry++;
                    System.Threading.Thread.Sleep(1000);
                    goto tt;
                }
            }

        }

        internal static void LoadProto<t>(string file, ref t inst)
        {
            int retry = 0;
            System.IO.FileStream fs = null;
        tt: ;

            try
            {
                if (fs == null)
                    fs = new System.IO.FileStream(file, System.IO.FileMode.Open);
                inst = ProtoBuf.Serializer.Deserialize<t>(fs);
                fs.Close();
                fs = null;
            }
            catch (Exception ex)
            {
                if (retry > 3)
                {
                    log.Save(ex);
                    retry++;

                    try
                    {
                        if (fs != null)
                            fs.Close();
                    }
                    catch (Exception exe)
                    {
                        log.Save(exe);
                    }
                    throw ex;
                }
                else
                {
                    Program.Write(ex.Message);
                    retry++;
                    System.Threading.Thread.Sleep(1000);
                    goto tt;
                }
            }
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
    }
}

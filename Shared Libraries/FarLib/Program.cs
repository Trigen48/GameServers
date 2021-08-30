using System;
using System.Collections.Generic;
using System.Linq;


namespace FarLib
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        static string SteamID = "76561198304764969";
        [STAThread]
        static void Main()
        {

            Environment.CurrentDirectory = @"C:\Users\Trigenite\AppData\Roaming\BrawlhallaAir\Local Store\";
            ZLibNet.ZLibStream z = new ZLibNet.ZLibStream(new System.IO.FileStream(@"cdsnt.dat", System.IO.FileMode.Open), ZLibNet.CompressionMode.Decompress);


            System.IO.MemoryStream st = new System.IO.MemoryStream();
            long tot = z.TotalOut;

            z.CopyTo(st);

            st.Flush();

            byte[] data = st.ToArray();
            st.Close();
            z.Close();

           /* class_139();

            Decrypt(data);*/

            System.IO.File.WriteAllBytes("test.dat",data);
            /* Compress
            sm.Write(data, 0, data.Length);
            sm.Flush();
            RawData.WriteBytes(mem.ToArray());
            itm.size = (int)mem.Length;
            sm.Close();
            sm = null;
            data = null;
            mem.Close();*/

            /* Decompress
             ZLibNet.ZLibStream df = new ZLibNet.ZLibStream(new System.IO.MemoryStream(data), ZLibNet.CompressionMode.Decompress);

                    //ZLibDll.
                    System.IO.MemoryStream st = new System.IO.MemoryStream();
                    long tot = df.TotalOut;

                    df.CopyTo(st);

                    st.Flush();

                    data = st.ToArray();
                    st.Close();
                    df.Close(); 
             
              */




        }
        static string var_7319;
        static List<uint> var_2221 = new List<uint>();
        public static uint var_3000;

        public static void class_139()
        {
            int _loc4_ = 0;
            uint _loc5_ = 0;
            uint _loc6_ = 0;
            uint _loc7_ = 0;
            uint _loc8_ = 0;
            //var_1797 = param1;
            var_7319 = SteamID;//var_1797.var_157.GetSteamID();
            var_2221 = new List<uint>();
            var_2221.Add(61);// var_2221.push(uint(61));
            int _loc2_ = 9;
            int _loc3_ = var_7319.Length - 2;

            while (_loc2_ < _loc3_)
            {
                _loc2_++;
                _loc4_ = _loc2_;
                _loc5_ = (uint)(var_7319[_loc4_]);
                _loc6_ = (uint)(var_7319[_loc4_ + 1]);
                _loc7_ = (uint)(var_7319[_loc4_ + 2]);
                _loc8_ = ((uint)((uint)(_loc5_ + (uint)(_loc6_ * 10)) + (uint)(_loc7_ * 100))) % 256;

                var_2221.Add(_loc8_);//var_2221.push(_loc8_);
                if (_loc4_ == var_7319.Length - 3)
                {
                    var_3000 = _loc8_;
                }
            }
            var_2221.Add(98);//var_2221.push(uint(98));
        }

        static void Decrypt(byte[] data)
        {
            int _loc5_ = 0;
            uint _loc6_ = 0;
            uint _loc7_ = 0;
            uint _loc2_ = (uint)var_2221.Count;//uint  _loc2_= var_2221.Length;
            int _loc3_ = 0;
            int _loc4_ = data.Length;
            while (_loc3_ < _loc4_)
            {
                _loc3_++;
                _loc5_ = _loc3_;
                _loc6_ = (uint)(var_3000 + _loc5_);
                _loc7_ = (uint)(var_2221[(int)(_loc6_ % _loc2_)]);
                data[_loc5_] = (byte)(_loc7_ ^ (int)(data[_loc5_]));
            }
        }
    }
}

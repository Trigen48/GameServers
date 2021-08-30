using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
namespace GameServer
{
    public static class MD5Checksum
    {
        /// <summary>
        /// Compute MD5 Checksum
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static byte[] Compute(byte[] Input)
        {
            byte[] checksum = new byte[16];
            MD5 md5 = MD5.Create();
           
            checksum = md5.ComputeHash(Input);
            md5.Dispose();
            md5 = null;
            return checksum;
        }

        public static byte[] Compute(string Input)
        {

            return Compute(Encoding.UTF8.GetBytes(Input));
        }

        public static string ComputeToString(byte[] input)
        {
            byte[] compute = Compute(input);

            string value = "";

            foreach (byte b in compute)
            {
                value += b.ToString("x2");
            }

            return value;
        }

        public static string ComputeToString(string input)
        {
            return ComputeToString(Encoding.UTF8.GetBytes(input));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    internal static class FlashPolicy
    {

        internal static byte[] FlashPolicyFile;

        internal static void InitFlashData()
        {

            if (System.IO.File.Exists("policy.xml"))
            {
                FlashPolicyFile = System.IO.File.ReadAllBytes("policy.xml");
            }
            else
            {
                FlashPolicyFile = System.Text.Encoding.UTF8.GetBytes(gateway.Properties.Resources.Policy);
            }
        }



    }
}

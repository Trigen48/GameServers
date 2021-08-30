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
            
            FlashPolicyFile = System.Text.Encoding.UTF8.GetBytes(RainbowServer.Properties.Resources.Policy);
        }



    }
}

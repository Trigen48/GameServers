using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    internal static class FlashPolicy
    {

        internal static byte[] FlashPolicyFile;

        static FlashPolicy()
        {
            FlashPolicyFile = System.Text.Encoding.UTF8.GetBytes(GameServer.Properties.Resources.Policy);
        }



    }
}

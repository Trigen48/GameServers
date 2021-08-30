using System;
using System.Collections.Generic;
using System.Text;

namespace RainbowServer
{
    internal static class Loads
    {
        public static void Load()
        {
            Folders.Init();

            //
            CharData.Load();
            Players.init();

            Zones.Init();
        }
    }
}

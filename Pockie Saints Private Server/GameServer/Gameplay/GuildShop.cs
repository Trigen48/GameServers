using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer.Gameplay
{


    public static class GuildShop
    {
        public struct GuildShopItem
        {
        }

        public static  Dictionary<int, GuildShopItem> shop;
        static GuildShop()
        {
            shop = new Dictionary<int, GuildShopItem>();
        }
    }
}

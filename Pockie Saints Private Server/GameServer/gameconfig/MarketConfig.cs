using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer.gameconfig
{
    internal static class MarketConfig
    {
        internal static bool canSellCrystal = false;
        internal static int Calculate(int selling, byte type, byte duration)
        {
            if (type == 1)
            {
                return CalculateCrystal(selling, duration);
            }
            else
            {
                return CalculateGold(selling, duration);
            }

        }


        static int CalculateGold(int selling, byte duration)
        {
            double goldRate = 0.02;

            switch (duration)
            {
                case 6:
                    goldRate = 0.02;
                    break;
                case 12:
                    goldRate = 0.03;
                    break;

                case 24:
                    goldRate = 0.05;
                    break;
            }

            return (int)Math.Ceiling((double)(selling) * goldRate);
        }

        static int CalculateCrystal(int selling, byte duration)
        {
            double crystalRate = 15;

            switch (duration)
            {
                case 6:
                    crystalRate = 15;
                    break;
                case 12:
                    crystalRate = 22.5;
                    break;

                case 24:
                    crystalRate = 37.5;
                    break;
            }

            return (int)Math.Ceiling((double)(selling) * crystalRate);
        }

    }
}

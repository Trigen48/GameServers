using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
namespace GameServer
{

    public class Chance
    {
        public Random rand;
        const double max = 100;
        public ShuffleList<byte> prob;
        public ShuffleList<byte> extraProb;

        public Chance()
        {
            prob = new ShuffleList<byte>();
            var cryptoResult = new byte[4];
            new RNGCryptoServiceProvider().GetBytes(cryptoResult);
            int seed = BitConverter.ToInt32(cryptoResult, 0);
            rand = new Random(seed + (new Random()).Next(0, DateUtil.GetZoneDate().Second));
            extraProb = new ShuffleList<byte>();

        }
        public bool HardChance(double d)
        {

            if (d == 0) return false;
            if (d >= 1) return true;


            int chan = (int)(d * max);

            if (chan != max) prob.AddRange(new byte[(int)max - chan]);

            for (int i = 0; i < chan; i++)
            {
                prob.Add(1, true);

            }

            prob.ShuffleInplace();
            if (prob[0] == 1) prob.ShuffleShift();

            bool res = prob[0] == 1;
            prob.Clear();

            double x = rand.NextDouble();
            res = res && x < d && chan >= rand.Next(0, (int)(max * 100)) / max;


            return res;
        }

        public bool MediumChance(double d)
        {
            return MediumChance(d, true);
        }
        public bool MediumChance(double d, bool redo)
        {
            if (d == 0) return false;
            if (d >= 1) return true;

            int chan = (int)(d * max);

            if (chan != max)
                prob.AddRange(new byte[(int)max - chan]);

            for (int i = 0; i < chan; i++)
                prob.Add(1, true);

            prob.ShuffleInplace();

            if (prob.SelectRandom() == 1 && redo) prob.ShuffleShift();

            bool res = prob.SelectRandom() == 1;
            prob.Clear();

            return res;
        }

        public bool SimpleChance(double d)
        {
            if (d == 0) return false;
            if (d >= 1) return true;

            int chan = (int)(d * max);
            bool res;

            res = Random((int)max) <= chan;

            return res;
        }


        public bool NoviceChance(double d)
        {

            if (d == 0) return false;
            if (d >= 1) return true;


            int chan = (int)(d * max);

            if (chan != max) prob.AddRange(new byte[(int)max - chan]);

            for (int i = 0; i < chan; i++)
            {
                prob.Add(1, true);

            }

            prob.ShuffleInplace();
            if (prob[0] == 1) prob.ShuffleShift();

            bool res = prob[0] == 1;
            prob.Clear();

            double x = rand.NextDouble();
            res = res && x < d;


            return res;
        }
        public int Random(int max)
        {
            return rand.Next(max);
        }
    }
}

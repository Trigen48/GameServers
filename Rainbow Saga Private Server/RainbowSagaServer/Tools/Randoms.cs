using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace RainbowServer
{
    static class Randoms
    {
        static Random _random;
        public static int Next(int min, int max)
        {

            if (_random == null)
            {
                var cryptoResult = new byte[4];
                new RNGCryptoServiceProvider().GetBytes(cryptoResult);

                int seed = BitConverter.ToInt32(cryptoResult, 0);

                _random = new Random(seed + (new Random()).Next(0, DateTime.UtcNow.AddHours(DateUtil.Zone).Second));
            }

             //System.Threading.Thread.Sleep(2);
            int exclusiveUpperBound = max;
            return _random.Next(min, exclusiveUpperBound);
        }
    }

    static class Randomizer
    {

        internal static int Next(int min, int max)
        {
            return Next(min, max, max);

        }

        internal static int Next(int min, int max, int factor)
        {
            if (max > factor) factor = max;

            if (min >= max) return -1;

            double f = (double)factor / (double)max;
            int fm=(int)(decimal.Round(((decimal)min*(decimal)f)));

            int r = new Random().Next(min, factor);
            return (int)(decimal.Round((decimal)r / (decimal)f));

        }

    }


    public class ShuffleList<T> : List<T>
    {
        private Random _random;
        public ShuffleList()
        {
            
        }
		
        public void Add(T item, bool israndom)
        {
            try
            {
                if (Count == 0)
                {
                    Add(item);
                }
                else
                {
                    int index = Next(0, Count + 1);
                    if (index == Count)
                    {
                        Add(item);
                    }
                    else
                    {
                        T x = this[index];
                        this[index] = item;
                        Add(x);
                    }
                }
            }
            catch(Exception ex)
            {
            
                Console.WriteLine(ex.Message);
            }
        }

        public void ShuffleShift()
        {
            //  T[] tmp = this.ToArray();


            List<T> tmp = new List<T>();

            while (this.Count > 0)
            {
                int i = Next(0, base.Count - 1);
                tmp.Add(base[i]);
                base.RemoveAt(i);
            }

            base.AddRange(tmp.ToArray());

            tmp.Clear();
            tmp = null;
        }

        public void ShuffleInplace()
        {
            _random = new Random();
            for (int i = base.Count - 1; i >= 0; i--)
            {
                T tmp = base[i];
                int randomIndex = Next(0, i + 1);

                //Swap elements
                base[i] = base[randomIndex];
                base[randomIndex] = tmp;
            }
        }

        public T Pop()
        {
            T t = base[0];
            base.RemoveAt(0);
            return t;
        }

        public T PopRandom()
        {
            int i = 0;
            i = Next(0, base.Count);
            T t = base[i];
            base.RemoveAt(i);
            return t;
        }

        public T SelectRandom()
        {
            int i = 0;
            i = Next(0, base.Count);
            T t = base[i];
            return t;
        }

        private int Next(int min, int max)
        {
            if (_random == null)
            {
                var cryptoResult = new byte[4];
                new RNGCryptoServiceProvider().GetBytes(cryptoResult);
                int seed = BitConverter.ToInt32(cryptoResult, 0);
                _random = new Random(seed);
            }


            return _random.Next(min, max);
        }
    }
}

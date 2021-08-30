using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace GameServer
{

    public static class SynthHelper
    {

        public class SynthCat
        {
            public int id { get; set; }
            public int cost { get; set; }
            public SynthItem[] Items { get; set; }
        }
        public struct SynthItem
        {
            public int ID { get; set; }
            public byte num { get; set; }
        }

        public static Dictionary<int, SynthCat>[] Synth;


        public static void init()
        {
            Synth = JsonLib.LoadFile<Dictionary<int, SynthCat>[]>("shop/Synth.json");
      
        }


    }
}

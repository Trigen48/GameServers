using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
namespace GameServer.gamedata
{


    public class SuitEffect
    {
        public byte Count { get; set; }
        public byte Type { get; set; }
        public int Value { get; set; }

        public SuitEffect()
        {
            Count = 0;
            Type = 0;
            Value = 0;
        }

        public SuitEffect(byte count, byte type, int value)
        {
            this.Count = count;
            this.Type = type;
            this.Value = value;
        }

    }
    public class SuitItem
    {

        public int ID { get; set; }

        public Dictionary<int, byte> Equip { get; set; }
        public List<SuitEffect> SuiteEffects { get; set; }

        public SuitItem()
        {
            Equip = new Dictionary<int, byte>();
            SuiteEffects = new List<SuitEffect>();
        }
    }

    internal static class SuitInfo
    {
        internal static Dictionary<int, SuitItem> suits = new Dictionary<int, SuitItem>();

        internal static bool Load()
        {
            suits = JsonLib.LoadFile<Dictionary<int, SuitItem>>("system/suit.json");
            //suits = JsonConvert.DeserializeObject<Dictionary<int, SuitItem>>(System.IO.File.ReadAllText("system/suit.json"));
            return true;
        }
    }
}

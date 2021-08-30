using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
namespace GameServer.World
{
    [ProtoContract]
    internal class MonsterInfo
    {
        [ProtoMember(1)]
        public int ID { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public byte Type { get; set; }

        public MonsterInfo()
        {
            Name = "";
            ID = 0;
            Type = 0;
        }
    }

    [ProtoContract]
    internal class MonsterInfoPack
    {
        [ProtoMember(1)]
        public List<int> MonsterIDS { get; set; }

        public MonsterInfoPack()
        {
            MonsterIDS = new List<int>();
        }
    }

    [ProtoContract]
    internal class Monsters
    {
        [ProtoMember(1)]
        public Dictionary<int, MonsterInfo> MonstersData { get; set; }

        [ProtoMember(2)]
        public Dictionary<int, MonsterInfoPack> MonstersPacks { get; set; }

        [ProtoMember(3)]
        public Dictionary<int, int> InstanceMonsters { get; set; }

        public Monsters()
        {
            MonstersData = new Dictionary<int, MonsterInfo>();
            MonstersPacks = new Dictionary<int, MonsterInfoPack>();
            InstanceMonsters = new Dictionary<int, int>();
        }

    }


    internal static class MonsterDetail
    {
        internal static Monsters Mons;


        internal static void Init()
        {
            Mons = new Monsters();
            ByteC.LoadProto("world/MonsterData.bin", ref Mons);
        }

    }
    
}

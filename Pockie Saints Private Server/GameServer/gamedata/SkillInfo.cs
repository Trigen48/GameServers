using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProtoBuf;
namespace GameServer.gamedata
{

    [ProtoContract]
    public class SkillItem
    {

        public int SkillId { get; set; }
        public byte Career { get; set; }
        public byte type { get; set; }
        public byte obj { get; set; }
    }
    static class SkillInfo
    {
    }
}

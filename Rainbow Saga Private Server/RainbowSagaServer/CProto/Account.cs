using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
namespace RainbowServer.CProto
{
    [ProtoContract]
    internal class Account
    {
        [ProtoMember(1)]
        internal string AccountName { get; set; }

        [ProtoMember(2)]
        internal string AccountPass { get; set; }

        [ProtoMember(3)]
        internal int Bann { get; set; }

        [ProtoMember(4)]
        internal List<int> CharIds { get; set; }

        internal Account()
        {
            AccountName = "";
            AccountPass = "";
            CharIds = new List<int>();
        }
    }
}

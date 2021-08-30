using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using RainbowServer.proto.msg;
namespace RainbowServer.CProto
{
    [ProtoContract]
    internal class Friends
    {
        [ProtoMember(1)]
        internal GetFriendListAck friends { get; set; } // = new GetFriendListAck();

        [ProtoMember(2)]
        internal GetTempFriendListAck friendst { get; set; } // = new GetTempFriendListAck();

        [ProtoMember(3)]
        internal GetBlackListAck friendsb { get; set; } // = new GetBlackListAck();

        [ProtoMember(4)]
        internal GetReqListAck friendsr { get; set; } // = new GetReqListAck();

        internal Friends()
        {
            friends = new GetFriendListAck();
            friendsb = new GetBlackListAck();
            friendsr = new GetReqListAck();
            friendst = new GetTempFriendListAck();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetTempFriendListAck
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public List<Friend> tmpfriends{ get; set; }


		internal GetTempFriendListAck()
		{
			this.unused = 0;
			this.tmpfriends = new List<Friend>();
		}

	}

}

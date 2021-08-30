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
	internal class GetFriendListAck
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public List<Friend> friends{ get; set; }


		internal GetFriendListAck()
		{
			this.unused = 0;
			this.friends = new List<Friend>();
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFriendList
	{

		[ProtoMember(1)]
		public int reserved{ get; set; }


		internal GetFriendList()
		{
			this.reserved = 0;
		}

	}

}

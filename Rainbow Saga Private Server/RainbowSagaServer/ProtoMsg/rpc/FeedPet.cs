using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class FeedPet
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int itemId{ get; set; }

		[ProtoMember(3)]
		public int itemNum{ get; set; }


		internal FeedPet()
		{
			this.uuid = 0;
			this.itemId = 0;
			this.itemNum = 0;
		}

	}

}

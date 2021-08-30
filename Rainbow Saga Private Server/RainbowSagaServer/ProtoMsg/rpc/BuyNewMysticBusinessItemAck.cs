using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class BuyNewMysticBusinessItemAck
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int itemtype{ get; set; }

		[ProtoMember(3)]
		public int type{ get; set; }

		[ProtoMember(4)]
		public int starttime{ get; set; }

		[ProtoMember(5)]
		public int result{ get; set; }

		[ProtoMember(6)]
		public int id{ get; set; }


		internal BuyNewMysticBusinessItemAck()
		{
			this.itemid = 0;
			this.itemtype = 0;
			this.type = 0;
			this.starttime = 0;
			this.result = 0;
			this.id = 0;
		}

	}

}

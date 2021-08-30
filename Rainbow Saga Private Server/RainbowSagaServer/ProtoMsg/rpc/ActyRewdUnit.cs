using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ActyRewdUnit
	{

		[ProtoMember(1)]
		public int value{ get; set; }

		[ProtoMember(2)]
		public int itemid{ get; set; }

		[ProtoMember(3)]
		public int getitem{ get; set; }


		internal ActyRewdUnit()
		{
			this.value = 0;
			this.itemid = 0;
			this.getitem = 0;
		}

	}

}

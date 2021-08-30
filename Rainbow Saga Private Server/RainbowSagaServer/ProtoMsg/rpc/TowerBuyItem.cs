using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class TowerBuyItem
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }


		internal TowerBuyItem()
		{
			this.id = 0;
			this.num = 0;
		}

	}

}

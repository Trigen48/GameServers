using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetConsumeBonusInfoRsp
	{

		[ProtoMember(1)]
		public int consume{ get; set; }

		[ProtoMember(2)]
		public int leftBonus{ get; set; }


		internal GetConsumeBonusInfoRsp()
		{
			this.consume = 0;
			this.leftBonus = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SendFlowersReq
	{

		[ProtoMember(1)]
		public int flowerType{ get; set; }

		[ProtoMember(2)]
		public int flowerNum{ get; set; }


		internal SendFlowersReq()
		{
			this.flowerType = 0;
			this.flowerNum = 0;
		}

	}

}

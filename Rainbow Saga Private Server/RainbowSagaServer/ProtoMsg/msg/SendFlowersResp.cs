using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SendFlowersResp
	{

		[ProtoMember(1)]
		public int charId{ get; set; }

		[ProtoMember(2)]
		public int cpId{ get; set; }

		[ProtoMember(3)]
		public int flowerType{ get; set; }

		[ProtoMember(4)]
		public int flowerNum{ get; set; }


		internal SendFlowersResp()
		{
			this.charId = 0;
			this.cpId = 0;
			this.flowerType = 0;
			this.flowerNum = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetChargeRewardReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }


		internal GetChargeRewardReq()
		{
			this.op = 0;
			this.type = 0;
		}

	}

}

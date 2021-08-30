using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetMultiChargeRewardReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }


		internal GetMultiChargeRewardReq()
		{
			this.op = 0;
		}

	}

}

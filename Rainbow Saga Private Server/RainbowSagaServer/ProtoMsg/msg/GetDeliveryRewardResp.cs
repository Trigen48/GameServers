using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetDeliveryRewardResp
	{

		[ProtoMember(1)]
		public int ret{ get; set; }


		internal GetDeliveryRewardResp()
		{
			this.ret = 0;
		}

	}

}

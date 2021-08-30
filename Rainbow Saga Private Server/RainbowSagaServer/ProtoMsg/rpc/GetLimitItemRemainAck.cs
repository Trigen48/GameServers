using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetLimitItemRemainAck
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public List<LimitItemInfo> items{ get; set; }


		internal GetLimitItemRemainAck()
		{
			this.type = 0;
			this.result = 0;
			this.items = new List<LimitItemInfo>();
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LimitTimeSaleItemListRsp
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public List<LimitTimeSaleSyncInfo> items{ get; set; }


		internal LimitTimeSaleItemListRsp()
		{
			this.result = 0;
			this.items = new List<LimitTimeSaleSyncInfo>();
		}

	}

}

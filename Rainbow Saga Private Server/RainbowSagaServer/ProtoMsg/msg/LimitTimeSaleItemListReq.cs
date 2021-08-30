using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LimitTimeSaleItemListReq
	{

		[ProtoMember(1)]
		public int unused{ get; set; }


		internal LimitTimeSaleItemListReq()
		{
			this.unused = 0;
		}

	}

}

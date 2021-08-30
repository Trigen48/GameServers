using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class LimitItemInfo
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int remain{ get; set; }


		internal LimitItemInfo()
		{
			this.itemid = 0;
			this.remain = 0;
		}

	}

}

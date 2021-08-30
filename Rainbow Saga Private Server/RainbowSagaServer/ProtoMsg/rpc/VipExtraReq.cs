using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class VipExtraReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int index{ get; set; }


		internal VipExtraReq()
		{
			this.op = 0;
			this.index = 0;
		}

	}

}

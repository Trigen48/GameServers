using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class TencentVipReq
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int op{ get; set; }

		[ProtoMember(3)]
		public int level{ get; set; }

		[ProtoMember(4)]
		public int isYear{ get; set; }


		internal TencentVipReq()
		{
			this.type = 0;
			this.op = 0;
			this.level = 0;
			this.isYear = 0;
		}

	}

}

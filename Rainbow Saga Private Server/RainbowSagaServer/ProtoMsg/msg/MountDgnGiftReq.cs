using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MountDgnGiftReq
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int rate{ get; set; }


		internal MountDgnGiftReq()
		{
			this.dgnid = 0;
			this.rate = 0;
		}

	}

}

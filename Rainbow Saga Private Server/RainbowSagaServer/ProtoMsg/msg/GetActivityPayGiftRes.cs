using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetActivityPayGiftRes
	{

		[ProtoMember(1)]
		public uint uin{ get; set; }

		[ProtoMember(2)]
		public int opt{ get; set; }

		[ProtoMember(3)]
		public uint multiGiftid{ get; set; }


		internal GetActivityPayGiftRes()
		{
			this.uin = 0;
			this.opt = 0;
			this.multiGiftid = 0;
		}

	}

}

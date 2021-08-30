using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GainNewbieGift
	{

		[ProtoMember(1)]
		public uint index{ get; set; }

		[ProtoMember(2)]
		public uint quickLogin{ get; set; }


		internal GainNewbieGift()
		{
			this.index = 0;
			this.quickLogin = 0;
		}

	}

}

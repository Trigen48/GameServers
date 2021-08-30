using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class getMagicsuitUpResp
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public int exp{ get; set; }


		internal getMagicsuitUpResp()
		{
			this.level = 0;
			this.exp = 0;
		}

	}

}

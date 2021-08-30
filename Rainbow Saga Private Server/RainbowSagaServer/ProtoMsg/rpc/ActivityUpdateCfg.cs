using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ActivityUpdateCfg
	{

		[ProtoMember(1)]
		public int i{ get; set; }

		[ProtoMember(2)]
		public ActivityCfg cfg{ get; set; }


		internal ActivityUpdateCfg()
		{
			this.i = 0;
			this.cfg = new ActivityCfg();
		}

	}

}

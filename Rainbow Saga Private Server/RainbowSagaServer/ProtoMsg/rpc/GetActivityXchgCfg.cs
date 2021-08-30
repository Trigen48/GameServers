using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetActivityXchgCfg
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public ItemXchgCfg cfg{ get; set; }


		internal GetActivityXchgCfg()
		{
			this.id = 0;
			this.cfg = new ItemXchgCfg();
		}

	}

}

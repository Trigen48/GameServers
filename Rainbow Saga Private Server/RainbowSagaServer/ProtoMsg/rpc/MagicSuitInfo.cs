using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MagicSuitInfo
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int status{ get; set; }


		internal MagicSuitInfo()
		{
			this.id = 0;
			this.status = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DoItemXchg
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int i{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }


		internal DoItemXchg()
		{
			this.id = 0;
			this.i = 0;
			this.num = 0;
		}

	}

}

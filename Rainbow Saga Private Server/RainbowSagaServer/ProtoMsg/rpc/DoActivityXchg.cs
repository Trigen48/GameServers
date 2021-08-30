using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DoActivityXchg
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int i{ get; set; }


		internal DoActivityXchg()
		{
			this.id = 0;
			this.i = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class Regain
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int category{ get; set; }


		internal Regain()
		{
			this.type = 0;
			this.category = 0;
		}

	}

}

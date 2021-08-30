using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetSignItems
	{

		[ProtoMember(1)]
		public uint signtype{ get; set; }

		[ProtoMember(2)]
		public uint days{ get; set; }


		internal GetSignItems()
		{
			this.signtype = 0;
			this.days = 0;
		}

	}

}

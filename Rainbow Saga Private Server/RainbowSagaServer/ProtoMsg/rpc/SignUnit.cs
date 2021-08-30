using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SignUnit
	{

		[ProtoMember(1)]
		public int day{ get; set; }

		[ProtoMember(2)]
		public int itemid{ get; set; }


		internal SignUnit()
		{
			this.day = 0;
			this.itemid = 0;
		}

	}

}

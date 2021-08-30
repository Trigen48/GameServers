using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetFestival
	{

		[ProtoMember(1)]
		public int itemindex{ get; set; }

		[ProtoMember(2)]
		public int itemid{ get; set; }


		internal GetFestival()
		{
			this.itemindex = 0;
			this.itemid = 0;
		}

	}

}

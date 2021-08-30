using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DartItem
	{

		[ProtoMember(1)]
		public int itemid{ get; set; }

		[ProtoMember(2)]
		public int itemnum{ get; set; }


		internal DartItem()
		{
			this.itemid = 0;
			this.itemnum = 0;
		}

	}

}

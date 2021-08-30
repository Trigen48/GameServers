using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DrawItem
	{

		[ProtoMember(1)]
		public int drawtime{ get; set; }

		[ProtoMember(2)]
		public int itemid{ get; set; }

		[ProtoMember(3)]
		public int itemnum{ get; set; }


		internal DrawItem()
		{
			this.drawtime = 0;
			this.itemid = 0;
			this.itemnum = 0;
		}

	}

}

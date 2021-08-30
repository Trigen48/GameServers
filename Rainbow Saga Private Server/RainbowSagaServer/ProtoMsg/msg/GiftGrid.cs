using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GiftGrid
	{

		[ProtoMember(1)]
		public int state{ get; set; }

		[ProtoMember(2)]
		public int iid{ get; set; }

		[ProtoMember(3)]
		public int inum{ get; set; }

		[ProtoMember(4)]
		public int grid{ get; set; }


		internal GiftGrid()
		{
			this.state = 0;
			this.iid = 0;
			this.inum = 0;
			this.grid = 0;
		}

	}

}

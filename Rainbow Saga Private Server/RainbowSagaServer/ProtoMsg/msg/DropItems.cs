using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DropItems
	{

		[ProtoMember(1)]
		public List<DropItem> dropItem{ get; set; }

		[ProtoMember(2)]
		public int mobDieX{ get; set; }

		[ProtoMember(3)]
		public int mobDieY{ get; set; }

		[ProtoMember(4)]
		public int mobid{ get; set; }


		internal DropItems()
		{
			this.dropItem = new List<DropItem>();
			this.mobDieX = 0;
			this.mobDieY = 0;
			this.mobid = 0;
		}

	}

}

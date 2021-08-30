using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ThrowItem
	{

		[ProtoMember(1)]
		public ThrowableItemList items{ get; set; }

		[ProtoMember(2)]
		public int speed{ get; set; }


		internal ThrowItem()
		{
			this.items = new ThrowableItemList();
			this.speed = 0;
		}

	}

}

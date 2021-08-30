using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DropItem
	{

		[ProtoMember(1, IsRequired=true)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public int x{ get; set; }

		[ProtoMember(4)]
		public int y{ get; set; }

		[ProtoMember(5)]
		public int charid{ get; set; }

		[ProtoMember(6)]
		public uint dropTime{ get; set; }

		[ProtoMember(7)]
		public int num{ get; set; }

		[ProtoMember(8)]
		public int groupID{ get; set; }

		[ProtoMember(9)]
		public Item prop{ get; set; }

		[ProtoMember(10)]
		public int dropType{ get; set; }


		internal DropItem()
		{
			this.uuid = 0;
			this.id = 0;
			this.x = 0;
			this.y = 0;
			this.charid = 0;
			this.dropTime = 0;
			this.num = 0;
			this.groupID = 0;
			this.prop = new Item();
			this.dropType = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Quest
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int objNum1{ get; set; }

		[ProtoMember(3)]
		public int objNum2{ get; set; }

		[ProtoMember(4)]
		public int objNum3{ get; set; }

		[ProtoMember(5)]
		public int state{ get; set; }

		[ProtoMember(6)]
		public int num{ get; set; }

		[ProtoMember(7)]
		public int exp{ get; set; }

		[ProtoMember(8)]
		public int money{ get; set; }

		[ProtoMember(9)]
		public int itemid{ get; set; }

		[ProtoMember(10)]
		public int itemnum{ get; set; }

		[ProtoMember(11)]
		public int step{ get; set; }

		[ProtoMember(12)]
		public int starttime{ get; set; }

		[ProtoMember(13)]
		public int challengetimes{ get; set; }

		[ProtoMember(14)]
		public int mode{ get; set; }

		[ProtoMember(15)]
		public int depositamount{ get; set; }

		[ProtoMember(16)]
		public int depositmaturity{ get; set; }

		[ProtoMember(17)]
		public int depositstartime{ get; set; }

		[ProtoMember(18)]
		public int depositonlinetime{ get; set; }

		[ProtoMember(19)]
		public int maxstep{ get; set; }


		internal Quest()
		{
			this.id = 0;
			this.objNum1 = 0;
			this.objNum2 = 0;
			this.objNum3 = 0;
			this.state = 0;
			this.num = 0;
			this.exp = 0;
			this.money = 0;
			this.itemid = 0;
			this.itemnum = 0;
			this.step = 0;
			this.starttime = 0;
			this.challengetimes = 0;
			this.mode = 0;
			this.depositamount = 0;
			this.depositmaturity = 0;
			this.depositstartime = 0;
			this.depositonlinetime = 0;
			this.maxstep = 0;
		}

	}

}

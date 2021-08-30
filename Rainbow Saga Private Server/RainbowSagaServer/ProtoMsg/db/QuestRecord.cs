using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class QuestRecord
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int state{ get; set; }

		[ProtoMember(3)]
		public int objnum0{ get; set; }

		[ProtoMember(4)]
		public int objnum1{ get; set; }

		[ProtoMember(5)]
		public int objnum2{ get; set; }

		[ProtoMember(6)]
		public int givetime{ get; set; }

		[ProtoMember(7)]
		public int endtime{ get; set; }

		[ProtoMember(8)]
		public int color{ get; set; }

		[ProtoMember(9)]
		public int item{ get; set; }

		[ProtoMember(10)]
		public int exp{ get; set; }

		[ProtoMember(11)]
		public int money{ get; set; }

		[ProtoMember(12)]
		public int loop{ get; set; }

		[ProtoMember(13)]
		public int objnum3{ get; set; }

		[ProtoMember(14)]
		public int objnum4{ get; set; }

		[ProtoMember(15)]
		public int objnum5{ get; set; }

		[ProtoMember(16)]
		public int startdate{ get; set; }

		[ProtoMember(17)]
		public int enddate{ get; set; }


		internal QuestRecord()
		{
			this.id = 0;
			this.state = 0;
			this.objnum0 = 0;
			this.objnum1 = 0;
			this.objnum2 = 0;
			this.givetime = 0;
			this.endtime = 0;
			this.color = 0;
			this.item = 0;
			this.exp = 0;
			this.money = 0;
			this.loop = 0;
			this.objnum3 = 0;
			this.objnum4 = 0;
			this.objnum5 = 0;
			this.startdate = 0;
			this.enddate = 0;
		}

	}

}

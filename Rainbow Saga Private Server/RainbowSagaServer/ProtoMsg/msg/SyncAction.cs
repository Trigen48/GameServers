using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncAction
	{

		[ProtoMember(1)]
		public int unitType{ get; set; }

		[ProtoMember(2)]
		public int unitId{ get; set; }

		[ProtoMember(3)]
		public int id{ get; set; }

		[ProtoMember(4)]
		public int direction{ get; set; }

		[ProtoMember(5)]
		public int startX{ get; set; }

		[ProtoMember(6)]
		public int startY{ get; set; }

		[ProtoMember(7)]
		public int destX{ get; set; }

		[ProtoMember(8)]
		public int destY{ get; set; }

		[ProtoMember(9)]
		public int foothold{ get; set; }

		[ProtoMember(10)]
		public int ladderrope{ get; set; }

		[ProtoMember(11)]
		public int timestamp{ get; set; }

		[ProtoMember(14)]
		public int vx{ get; set; }

		[ProtoMember(15)]
		public int vy{ get; set; }

		[ProtoMember(16)]
		public string action{ get; set; }

		[ProtoMember(17)]
		public int delay{ get; set; }

		[ProtoMember(18)]
		public int duration{ get; set; }

		[ProtoMember(19)]
		public int misc0{ get; set; }


		internal SyncAction()
		{
			this.unitType = 0;
			this.unitId = 0;
			this.id = 0;
			this.direction = 0;
			this.startX = 0;
			this.startY = 0;
			this.destX = 0;
			this.destY = 0;
			this.foothold = 0;
			this.ladderrope = 0;
			this.timestamp = 0;
			this.vx = 0;
			this.vy = 0;
			this.action ="";
			this.delay = 0;
			this.duration = 0;
			this.misc0 = 0;
		}

	}

}

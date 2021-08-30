using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdateDynamicObject
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int opcode{ get; set; }

		[ProtoMember(3)]
		public int ltx{ get; set; }

		[ProtoMember(4)]
		public int lty{ get; set; }

		[ProtoMember(5)]
		public int rbx{ get; set; }

		[ProtoMember(6)]
		public int rby{ get; set; }

		[ProtoMember(7)]
		public int x{ get; set; }

		[ProtoMember(8)]
		public int y{ get; set; }

		[ProtoMember(9)]
		public int skillId{ get; set; }

		[ProtoMember(10)]
		public int skillLv{ get; set; }


		internal UpdateDynamicObject()
		{
			this.id = 0;
			this.opcode = 0;
			this.ltx = 0;
			this.lty = 0;
			this.rbx = 0;
			this.rby = 0;
			this.x = 0;
			this.y = 0;
			this.skillId = 0;
			this.skillLv = 0;
		}

	}

}

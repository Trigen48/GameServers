using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SkillRepel
	{

		[ProtoMember(1)]
		public int srcObjType{ get; set; }

		[ProtoMember(2)]
		public int srcObjId{ get; set; }

		[ProtoMember(3)]
		public int destObjType{ get; set; }

		[ProtoMember(4)]
		public int destObjId{ get; set; }

		[ProtoMember(5)]
		public int fh{ get; set; }

		[ProtoMember(6)]
		public int x{ get; set; }

		[ProtoMember(7)]
		public int y{ get; set; }

		[ProtoMember(8)]
		public int dir{ get; set; }

		[ProtoMember(9)]
		public int duration{ get; set; }

		[ProtoMember(10)]
		public int skillId{ get; set; }

		[ProtoMember(11)]
		public int seqId{ get; set; }

		[ProtoMember(12)]
		public int speed{ get; set; }


		internal SkillRepel()
		{
			this.srcObjType = 0;
			this.srcObjId = 0;
			this.destObjType = 0;
			this.destObjId = 0;
			this.fh = 0;
			this.x = 0;
			this.y = 0;
			this.dir = 0;
			this.duration = 0;
			this.skillId = 0;
			this.seqId = 0;
			this.speed = 0;
		}

	}

}

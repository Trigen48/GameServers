using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SkillInvincible
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
		public int skillId{ get; set; }

		[ProtoMember(6)]
		public int type{ get; set; }

		[ProtoMember(7)]
		public int seqId{ get; set; }


		internal SkillInvincible()
		{
			this.srcObjType = 0;
			this.srcObjId = 0;
			this.destObjType = 0;
			this.destObjId = 0;
			this.skillId = 0;
			this.type = 0;
			this.seqId = 0;
		}

	}

}

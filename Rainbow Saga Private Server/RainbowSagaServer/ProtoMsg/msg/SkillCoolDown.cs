using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SkillCoolDown
	{

		[ProtoMember(1)]
		public int skillId{ get; set; }

		[ProtoMember(3)]
		public int seqId{ get; set; }

		[ProtoMember(5)]
		public int targetSkillId{ get; set; }

		[ProtoMember(6)]
		public int remainTime{ get; set; }

		[ProtoMember(9)]
		public int opt{ get; set; }


		internal SkillCoolDown()
		{
			this.skillId = 0;
			this.seqId = 0;
			this.targetSkillId = 0;
			this.remainTime = 0;
			this.opt = 0;
		}

	}

}

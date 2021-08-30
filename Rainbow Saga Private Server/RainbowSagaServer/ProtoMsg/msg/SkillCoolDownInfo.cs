using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SkillCoolDownInfo
	{

		[ProtoMember(1)]
		public int skillId{ get; set; }

		[ProtoMember(2)]
		public uint remainTime{ get; set; }


		internal SkillCoolDownInfo()
		{
			this.skillId = 0;
			this.remainTime = 0;
		}

	}

}

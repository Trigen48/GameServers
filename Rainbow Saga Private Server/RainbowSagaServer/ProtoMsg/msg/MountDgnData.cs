using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MountDgnData
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int lastAttendTime{ get; set; }

		[ProtoMember(3)]
		public int passedLevel{ get; set; }

		[ProtoMember(4)]
		public int maxPassedLevel{ get; set; }

		[ProtoMember(5)]
		public int timeUsed{ get; set; }

		[ProtoMember(6)]
		public int getGiftLevel{ get; set; }

		[ProtoMember(7)]
		public int addBuffId{ get; set; }

		[ProtoMember(8)]
		public List<SkillCoolDownInfo> skillCoolDownInfo{ get; set; }

		[ProtoMember(9)]
		public int hpLeft{ get; set; }

		[ProtoMember(10)]
		public int mpLeft{ get; set; }


		internal MountDgnData()
		{
			this.id = 0;
			this.lastAttendTime = 0;
			this.passedLevel = 0;
			this.maxPassedLevel = 0;
			this.timeUsed = 0;
			this.getGiftLevel = 0;
			this.addBuffId = 0;
			this.skillCoolDownInfo = new List<SkillCoolDownInfo>();
			this.hpLeft = 0;
			this.mpLeft = 0;
		}

	}

}

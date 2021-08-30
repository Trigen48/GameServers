using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpgradeFamilySkillResult
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public int maxLevel{ get; set; }


		internal UpgradeFamilySkillResult()
		{
			this.result = 0;
			this.id = 0;
			this.maxLevel = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpgradeSkillResult
	{

		[ProtoMember(1, IsRequired=true)]
		public int result{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int id{ get; set; }

		[ProtoMember(4)]
		public int type{ get; set; }

		[ProtoMember(5)]
		public int maxLevel{ get; set; }


		internal UpgradeSkillResult()
		{
			this.result = 0;
			this.id = 0;
			this.type = 0;
			this.maxLevel = 0;
		}

	}

}

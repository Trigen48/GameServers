using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpgradeSkill
	{

		[ProtoMember(1, IsRequired=true)]
		public int id{ get; set; }

		[ProtoMember(4)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int maxLevel{ get; set; }


		internal UpgradeSkill()
		{
			this.id = 0;
			this.type = 0;
			this.maxLevel = 0;
		}

	}

}

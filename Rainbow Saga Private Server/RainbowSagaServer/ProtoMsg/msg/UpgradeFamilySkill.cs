using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpgradeFamilySkill
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int contri{ get; set; }


		internal UpgradeFamilySkill()
		{
			this.id = 0;
			this.contri = 0;
		}

	}

}

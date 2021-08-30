using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SkillEnergyStar
	{

		[ProtoMember(1)]
		public int objOpt{ get; set; }

		[ProtoMember(2)]
		public int objNum{ get; set; }


		internal SkillEnergyStar()
		{
			this.objOpt = 0;
			this.objNum = 0;
		}

	}

}

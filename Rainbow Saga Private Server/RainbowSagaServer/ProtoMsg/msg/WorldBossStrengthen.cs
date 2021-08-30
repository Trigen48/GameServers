using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class WorldBossStrengthen
	{

		[ProtoMember(1)]
		public int strengthenType{ get; set; }

		[ProtoMember(2)]
		public int buffLv{ get; set; }


		internal WorldBossStrengthen()
		{
			this.strengthenType = 0;
			this.buffLv = 0;
		}

	}

}

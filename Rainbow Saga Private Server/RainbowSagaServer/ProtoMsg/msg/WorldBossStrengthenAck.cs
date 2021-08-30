using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class WorldBossStrengthenAck
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int buffLv{ get; set; }


		internal WorldBossStrengthenAck()
		{
			this.result = 0;
			this.buffLv = 0;
		}

	}

}

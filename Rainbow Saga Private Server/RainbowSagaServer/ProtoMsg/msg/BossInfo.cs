using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BossInfo
	{

		[ProtoMember(1)]
		public int bossid{ get; set; }

		[ProtoMember(2)]
		public int dead{ get; set; }

		[ProtoMember(3)]
		public int nextapprtime{ get; set; }

		[ProtoMember(4)]
		public string lastkiller{ get; set; }


		internal BossInfo()
		{
			this.bossid = 0;
			this.dead = 0;
			this.nextapprtime = 0;
			this.lastkiller ="";
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BossStats
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public List<BossInfo> infos{ get; set; }


		internal BossStats()
		{
			this.unused = 0;
			this.infos = new List<BossInfo>();
		}

	}

}

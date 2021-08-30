using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BossRushCard
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int skeletonNum{ get; set; }

		[ProtoMember(3)]
		public int state{ get; set; }

		[ProtoMember(4)]
		public int bossId{ get; set; }


		internal BossRushCard()
		{
			this.id = 0;
			this.skeletonNum = 0;
			this.state = 0;
			this.bossId = 0;
		}

	}

}

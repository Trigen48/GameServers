using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DragonSoul
	{

		[ProtoMember(1)]
		public int soulNum{ get; set; }

		[ProtoMember(2)]
		public int maxLevel{ get; set; }

		[ProtoMember(3)]
		public List<DragonSoulInfo> infos{ get; set; }


		internal DragonSoul()
		{
			this.soulNum = 0;
			this.maxLevel = 0;
			this.infos = new List<DragonSoulInfo>();
		}

	}

}

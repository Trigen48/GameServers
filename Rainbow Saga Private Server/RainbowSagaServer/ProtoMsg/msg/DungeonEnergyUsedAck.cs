using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DungeonEnergyUsedAck
	{

		[ProtoMember(1)]
		public int dungeonid{ get; set; }

		[ProtoMember(2)]
		public int times{ get; set; }

		[ProtoMember(3)]
		public int energyneed{ get; set; }

		[ProtoMember(4)]
		public int energyleft{ get; set; }

		[ProtoMember(5)]
		public int eliteEnergyneed{ get; set; }


		internal DungeonEnergyUsedAck()
		{
			this.dungeonid = 0;
			this.times = 0;
			this.energyneed = 0;
			this.energyleft = 0;
			this.eliteEnergyneed = 0;
		}

	}

}

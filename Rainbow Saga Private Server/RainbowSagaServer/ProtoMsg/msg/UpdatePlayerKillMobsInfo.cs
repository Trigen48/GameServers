using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdatePlayerKillMobsInfo
	{

		[ProtoMember(1)]
		public uint remainMobs{ get; set; }

		[ProtoMember(2)]
		public uint expRewardFactor{ get; set; }

		[ProtoMember(3)]
		public uint moneyRewardFactor{ get; set; }

		[ProtoMember(4)]
		public uint showColor{ get; set; }


		internal UpdatePlayerKillMobsInfo()
		{
			this.remainMobs = 0;
			this.expRewardFactor = 0;
			this.moneyRewardFactor = 0;
			this.showColor = 0;
		}

	}

}

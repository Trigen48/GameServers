using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class FightBossRushCard
	{

		[ProtoMember(1)]
		public int cardId{ get; set; }

		[ProtoMember(2)]
		public int ret{ get; set; }


		internal FightBossRushCard()
		{
			this.cardId = 0;
			this.ret = 0;
		}

	}

}

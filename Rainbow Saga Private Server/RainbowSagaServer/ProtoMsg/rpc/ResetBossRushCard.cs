using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ResetBossRushCard
	{

		[ProtoMember(1)]
		public int cardId{ get; set; }

		[ProtoMember(2)]
		public int ret{ get; set; }

		[ProtoMember(3)]
		public BossRushCard card{ get; set; }


		internal ResetBossRushCard()
		{
			this.cardId = 0;
			this.ret = 0;
			this.card = new BossRushCard();
		}

	}

}

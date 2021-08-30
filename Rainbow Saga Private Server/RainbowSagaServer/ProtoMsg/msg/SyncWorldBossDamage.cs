using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncWorldBossDamage
	{

		[ProtoMember(1)]
		public int mobid{ get; set; }

		[ProtoMember(2)]
		public int amount{ get; set; }

		[ProtoMember(3)]
		public int maxHp{ get; set; }

		[ProtoMember(4)]
		public int curHp{ get; set; }


		internal SyncWorldBossDamage()
		{
			this.mobid = 0;
			this.amount = 0;
			this.maxHp = 0;
			this.curHp = 0;
		}

	}

}

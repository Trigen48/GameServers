using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncMaxHpMp
	{

		[ProtoMember(1)]
		public int unitType{ get; set; }

		[ProtoMember(2)]
		public int unitId{ get; set; }

		[ProtoMember(3)]
		public int maxHp{ get; set; }

		[ProtoMember(4)]
		public int maxMp{ get; set; }


		internal SyncMaxHpMp()
		{
			this.unitType = 0;
			this.unitId = 0;
			this.maxHp = 0;
			this.maxMp = 0;
		}

	}

}

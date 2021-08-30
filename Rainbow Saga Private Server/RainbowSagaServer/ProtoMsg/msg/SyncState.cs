using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncState
	{

		[ProtoMember(1)]
		public int unitType{ get; set; }

		[ProtoMember(2)]
		public int unitId{ get; set; }

		[ProtoMember(3)]
		public int hp{ get; set; }

		[ProtoMember(4)]
		public int mp{ get; set; }

		[ProtoMember(5)]
		public int tweenFlag{ get; set; }


		internal SyncState()
		{
			this.unitType = 0;
			this.unitId = 0;
			this.hp = 0;
			this.mp = 0;
			this.tweenFlag = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OnlineAFKState
	{

		[ProtoMember(1)]
		public int unitType{ get; set; }

		[ProtoMember(2)]
		public int unitId{ get; set; }

		[ProtoMember(3)]
		public int op{ get; set; }

		[ProtoMember(4)]
		public int avatarId{ get; set; }


		internal OnlineAFKState()
		{
			this.unitType = 0;
			this.unitId = 0;
			this.op = 0;
			this.avatarId = 0;
		}

	}

}

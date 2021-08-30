using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OnlineAFKResponse
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int leftTime{ get; set; }

		[ProtoMember(4)]
		public int gainedExp{ get; set; }

		[ProtoMember(5)]
		public int gainedEnergy{ get; set; }

		[ProtoMember(6)]
		public int avatarId{ get; set; }


		internal OnlineAFKResponse()
		{
			this.op = 0;
			this.result = 0;
			this.leftTime = 0;
			this.gainedExp = 0;
			this.gainedEnergy = 0;
			this.avatarId = 0;
		}

	}

}

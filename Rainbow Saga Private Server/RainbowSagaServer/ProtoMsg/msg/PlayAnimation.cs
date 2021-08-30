using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PlayAnimation
	{

		[ProtoMember(1)]
		public int unitType{ get; set; }

		[ProtoMember(2)]
		public int unitId{ get; set; }

		[ProtoMember(3)]
		public string animation{ get; set; }

		[ProtoMember(4)]
		public string stateWalk{ get; set; }

		[ProtoMember(5)]
		public string stateStand{ get; set; }

		[ProtoMember(6)]
		public int times{ get; set; }

		[ProtoMember(7)]
		public int type{ get; set; }

		[ProtoMember(8)]
		public int totalTime{ get; set; }


		internal PlayAnimation()
		{
			this.unitType = 0;
			this.unitId = 0;
			this.animation ="";
			this.stateWalk ="";
			this.stateStand ="";
			this.times = 0;
			this.type = 0;
			this.totalTime = 0;
		}

	}

}

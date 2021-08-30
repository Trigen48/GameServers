using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ThreeDiabetesInfo
	{

		[ProtoMember(1)]
		public ThreeDiabetesMap minfo{ get; set; }

		[ProtoMember(2)]
		public int lastTime{ get; set; }

		[ProtoMember(3)]
		public int leftStep{ get; set; }

		[ProtoMember(4)]
		public int addScore{ get; set; }

		[ProtoMember(5)]
		public int score{ get; set; }

		[ProtoMember(6)]
		public int tscore{ get; set; }


		internal ThreeDiabetesInfo()
		{
			this.minfo = new ThreeDiabetesMap();
			this.lastTime = 0;
			this.leftStep = 0;
			this.addScore = 0;
			this.score = 0;
			this.tscore = 0;
		}

	}

}

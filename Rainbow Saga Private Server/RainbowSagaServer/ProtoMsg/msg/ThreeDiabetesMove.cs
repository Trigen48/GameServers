using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ThreeDiabetesMove
	{

		[ProtoMember(1)]
		public int flag{ get; set; }

		[ProtoMember(2)]
		public List<ThreeDiabetesMoveStep> steps{ get; set; }

		[ProtoMember(3)]
		public int score{ get; set; }


		internal ThreeDiabetesMove()
		{
			this.flag = 0;
			this.steps = new List<ThreeDiabetesMoveStep>();
			this.score = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ThreeDiabetesMoveStep
	{

		[ProtoMember(1)]
		public List<ThreeDiabetesMapData> data{ get; set; }

		[ProtoMember(2)]
		public int remove{ get; set; }

		[ProtoMember(3)]
		public int score{ get; set; }


		internal ThreeDiabetesMoveStep()
		{
			this.data = new List<ThreeDiabetesMapData>();
			this.remove = 0;
			this.score = 0;
		}

	}

}

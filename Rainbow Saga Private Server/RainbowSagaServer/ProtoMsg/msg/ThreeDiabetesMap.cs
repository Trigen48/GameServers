using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ThreeDiabetesMap
	{

		[ProtoMember(1)]
		public List<ThreeDiabetesMapData> data{ get; set; }

		[ProtoMember(2)]
		public int score{ get; set; }


		internal ThreeDiabetesMap()
		{
			this.data = new List<ThreeDiabetesMapData>();
			this.score = 0;
		}

	}

}

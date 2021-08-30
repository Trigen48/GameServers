using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ThreeDiabetesMapData
	{

		[ProtoMember(1)]
		public int index{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int state{ get; set; }


		internal ThreeDiabetesMapData()
		{
			this.index = 0;
			this.type = 0;
			this.state = 0;
		}

	}

}

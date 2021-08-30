using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CatGarden
	{

		[ProtoMember(1)]
		public int seedDay{ get; set; }

		[ProtoMember(2)]
		public int seedType{ get; set; }

		[ProtoMember(3)]
		public int plantStates{ get; set; }


		internal CatGarden()
		{
			this.seedDay = 0;
			this.seedType = 0;
			this.plantStates = 0;
		}

	}

}

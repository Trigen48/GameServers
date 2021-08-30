using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class CatGardenOp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int seedType{ get; set; }

		[ProtoMember(3)]
		public int plantIndex{ get; set; }

		[ProtoMember(4)]
		public int plantStates{ get; set; }

		[ProtoMember(5)]
		public int seedDate{ get; set; }

		[ProtoMember(6)]
		public int startDate{ get; set; }

		[ProtoMember(7)]
		public int endDate{ get; set; }

		[ProtoMember(8)]
		public int state{ get; set; }


		internal CatGardenOp()
		{
			this.op = 0;
			this.seedType = 0;
			this.plantIndex = 0;
			this.plantStates = 0;
			this.seedDate = 0;
			this.startDate = 0;
			this.endDate = 0;
			this.state = 0;
		}

	}

}

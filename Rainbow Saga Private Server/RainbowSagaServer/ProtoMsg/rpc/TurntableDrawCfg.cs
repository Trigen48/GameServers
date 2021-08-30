using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class TurntableDrawCfg
	{

		[ProtoMember(1)]
		public int drawType{ get; set; }

		[ProtoMember(2)]
		public int drawList{ get; set; }

		[ProtoMember(3)]
		public int ticketId{ get; set; }

		[ProtoMember(4)]
		public int ticketNum{ get; set; }

		[ProtoMember(5)]
		public int randomMin{ get; set; }

		[ProtoMember(6)]
		public int randomMax{ get; set; }

		[ProtoMember(7)]
		public int xchgNeed{ get; set; }

		[ProtoMember(8)]
		public int xchgItem{ get; set; }


		internal TurntableDrawCfg()
		{
			this.drawType = 0;
			this.drawList = 0;
			this.ticketId = 0;
			this.ticketNum = 0;
			this.randomMin = 0;
			this.randomMax = 0;
			this.xchgNeed = 0;
			this.xchgItem = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class Transport
	{

		[ProtoMember(1)]
		public int transportType{ get; set; }

		[ProtoMember(2)]
		public int sourceMapId{ get; set; }

		[ProtoMember(3)]
		public int destMapId{ get; set; }

		[ProtoMember(4)]
		public int unitType{ get; set; }

		[ProtoMember(5)]
		public int unitId{ get; set; }


		internal Transport()
		{
			this.transportType = 0;
			this.sourceMapId = 0;
			this.destMapId = 0;
			this.unitType = 0;
			this.unitId = 0;
		}

	}

}

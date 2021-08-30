using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class VechileSyncAction
	{

		[ProtoMember(1)]
		public int unitType{ get; set; }

		[ProtoMember(2)]
		public int unitId{ get; set; }

		[ProtoMember(3)]
		public int opcode{ get; set; }

		[ProtoMember(4)]
		public int vechileId{ get; set; }


		internal VechileSyncAction()
		{
			this.unitType = 0;
			this.unitId = 0;
			this.opcode = 0;
			this.vechileId = 0;
		}

	}

}

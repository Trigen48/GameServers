using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RingLevelupReq
	{

		[ProtoMember(1)]
		public int currentLevel{ get; set; }

		[ProtoMember(2)]
		public int slotId{ get; set; }


		internal RingLevelupReq()
		{
			this.currentLevel = 0;
			this.slotId = 0;
		}

	}

}

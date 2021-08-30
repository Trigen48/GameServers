using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DungeonAreaAwardStatus
	{

		[ProtoMember(1)]
		public int areaid{ get; set; }

		[ProtoMember(2)]
		public int awarded{ get; set; }


		internal DungeonAreaAwardStatus()
		{
			this.areaid = 0;
			this.awarded = 0;
		}

	}

}

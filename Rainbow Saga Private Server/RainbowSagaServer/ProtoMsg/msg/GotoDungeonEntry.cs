using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GotoDungeonEntry
	{

		[ProtoMember(1)]
		public int dungeonid{ get; set; }


		internal GotoDungeonEntry()
		{
			this.dungeonid = 0;
		}

	}

}

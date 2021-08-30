using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GroupDungeonQueue
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int waitingnum{ get; set; }


		internal GroupDungeonQueue()
		{
			this.dgnid = 0;
			this.waitingnum = 0;
		}

	}

}

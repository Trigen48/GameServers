using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LeaveArenaHall
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }


		internal LeaveArenaHall()
		{
			this.charid = 0;
			this.type = 0;
		}

	}

}

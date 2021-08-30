using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyArenaMatchState
	{

		[ProtoMember(1)]
		public int state{ get; set; }

		[ProtoMember(2)]
		public ArenaDgnInfo dgnInfo{ get; set; }


		internal NotifyArenaMatchState()
		{
			this.state = 0;
			this.dgnInfo = new ArenaDgnInfo();
		}

	}

}

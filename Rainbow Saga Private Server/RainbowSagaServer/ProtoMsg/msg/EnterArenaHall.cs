using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterArenaHall
	{

		[ProtoMember(1)]
		public int charid{ get; set; }

		[ProtoMember(2)]
		public PlayerArenaInfo arenaInfo{ get; set; }


		internal EnterArenaHall()
		{
			this.charid = 0;
			this.arenaInfo = new PlayerArenaInfo();
		}

	}

}

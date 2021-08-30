using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterDungeon
	{

		[ProtoMember(1)]
		public int dungeonid{ get; set; }

		[ProtoMember(2)]
		public int difficulty{ get; set; }

		[ProtoMember(3)]
		public int justcheck{ get; set; }


		internal EnterDungeon()
		{
			this.dungeonid = 0;
			this.difficulty = 0;
			this.justcheck = 0;
		}

	}

}

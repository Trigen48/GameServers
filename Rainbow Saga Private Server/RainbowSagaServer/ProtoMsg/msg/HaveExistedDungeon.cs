using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class HaveExistedDungeon
	{

		[ProtoMember(1)]
		public int dungeonid{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public int single{ get; set; }


		internal HaveExistedDungeon()
		{
			this.dungeonid = 0;
			this.type = 0;
			this.single = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class TurntableDrawData
	{

		[ProtoMember(1)]
		public LuckTurntableDraw luckdraw{ get; set; }

		[ProtoMember(2)]
		public LuckTurntableDraw luckdraw1{ get; set; }

		[ProtoMember(3)]
		public LuckTurntableDraw creditsdraw{ get; set; }


		internal TurntableDrawData()
		{
			this.luckdraw = new LuckTurntableDraw();
			this.luckdraw1 = new LuckTurntableDraw();
			this.creditsdraw = new LuckTurntableDraw();
		}

	}

}

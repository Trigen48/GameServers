using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DoTurntableDraw
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int luck{ get; set; }

		[ProtoMember(3)]
		public DrawItem drawItem{ get; set; }


		internal DoTurntableDraw()
		{
			this.type = 0;
			this.luck = 0;
			this.drawItem = new DrawItem();
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class LuckTurntableDraw
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int luck{ get; set; }

		[ProtoMember(3)]
		public List<DrawItem> history{ get; set; }


		internal LuckTurntableDraw()
		{
			this.id = 0;
			this.luck = 0;
			this.history = new List<DrawItem>();
		}

	}

}

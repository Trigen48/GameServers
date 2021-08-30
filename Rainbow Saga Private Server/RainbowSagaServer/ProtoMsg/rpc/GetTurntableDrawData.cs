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
	internal class GetTurntableDrawData
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public LuckTurntableDraw data{ get; set; }

		[ProtoMember(3)]
		public TurntableDrawCfg cfg{ get; set; }

		[ProtoMember(4)]
		public List<DrawItem> itemList{ get; set; }


		internal GetTurntableDrawData()
		{
			this.type = 0;
			this.data = new LuckTurntableDraw();
			this.cfg = new TurntableDrawCfg();
			this.itemList = new List<DrawItem>();
		}

	}

}

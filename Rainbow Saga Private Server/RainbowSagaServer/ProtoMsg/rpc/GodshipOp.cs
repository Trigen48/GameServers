using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GodshipOp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int godshipType{ get; set; }

		[ProtoMember(3)]
		public GodshipInfo godshipInfoBefore{ get; set; }

		[ProtoMember(4)]
		public GodshipInfo godshipInfoNow{ get; set; }

		[ProtoMember(5)]
		public int levelUpNum{ get; set; }

		[ProtoMember(6)]
		public int critNum{ get; set; }


		internal GodshipOp()
		{
			this.op = 0;
			this.godshipType = 0;
			this.godshipInfoBefore = new GodshipInfo();
			this.godshipInfoNow = new GodshipInfo();
			this.levelUpNum = 0;
			this.critNum = 0;
		}

	}

}

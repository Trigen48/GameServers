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
	internal class VipExtraResp
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public VipExtraInfo info{ get; set; }

		[ProtoMember(3)]
		public int wheelState{ get; set; }

		[ProtoMember(4)]
		public int wheelLeftTime{ get; set; }

		[ProtoMember(5)]
		public ItemCell currItem{ get; set; }


		internal VipExtraResp()
		{
			this.op = 0;
			this.info = new VipExtraInfo();
			this.wheelState = 0;
			this.wheelLeftTime = 0;
			this.currItem = new ItemCell();
		}

	}

}

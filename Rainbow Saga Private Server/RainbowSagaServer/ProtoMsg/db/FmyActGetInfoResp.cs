using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmyActGetInfoResp
	{

		[ProtoMember(1)]
		public int heatvalue{ get; set; }

		[ProtoMember(2)]
		public string whobuy{ get; set; }

		[ProtoMember(3)]
		public int dinnertime{ get; set; }

		[ProtoMember(4)]
		public int bought{ get; set; }

		[ProtoMember(5)]
		public int buycount{ get; set; }

		[ProtoMember(6)]
		public int actremaintime{ get; set; }

		[ProtoMember(7)]
		public uint stoneexp{ get; set; }

		[ProtoMember(8)]
		public uint maxstoneexp{ get; set; }

		[ProtoMember(9)]
		public int stonelv{ get; set; }

		[ProtoMember(10)]
		public int state{ get; set; }


		internal FmyActGetInfoResp()
		{
			this.heatvalue = 0;
			this.whobuy ="";
			this.dinnertime = 0;
			this.bought = 0;
			this.buycount = 0;
			this.actremaintime = 0;
			this.stoneexp = 0;
			this.maxstoneexp = 0;
			this.stonelv = 0;
			this.state = 0;
		}

	}

}

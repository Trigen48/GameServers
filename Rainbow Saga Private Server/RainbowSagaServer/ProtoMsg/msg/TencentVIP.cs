using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TencentVIP
	{

		[ProtoMember(1)]
		public int normalDay{ get; set; }

		[ProtoMember(2)]
		public int yearDay{ get; set; }

		[ProtoMember(3)]
		public int type{ get; set; }

		[ProtoMember(4)]
		public List<TencentLvGift> lvStates{ get; set; }

		[ProtoMember(5)]
		public int freshman{ get; set; }

		[ProtoMember(6)]
		public int luxuryDay{ get; set; }


		internal TencentVIP()
		{
			this.normalDay = 0;
			this.yearDay = 0;
			this.type = 0;
			this.lvStates = new List<TencentLvGift>();
			this.freshman = 0;
			this.luxuryDay = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetChargeDragonAck
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int ret{ get; set; }

		[ProtoMember(3)]
		public int startTime{ get; set; }

		[ProtoMember(4)]
		public int endTime{ get; set; }

		[ProtoMember(5)]
		public int crystal{ get; set; }

		[ProtoMember(6)]
		public List<ChargeDragonInfo> infos{ get; set; }


		internal GetChargeDragonAck()
		{
			this.op = 0;
			this.ret = 0;
			this.startTime = 0;
			this.endTime = 0;
			this.crystal = 0;
			this.infos = new List<ChargeDragonInfo>();
		}

	}

}

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
	internal class UpdateDailyPayData
	{

		[ProtoMember(1)]
		public DailyPayData data{ get; set; }

		[ProtoMember(2)]
		public int remaintime{ get; set; }

		[ProtoMember(3)]
		public int maxnum{ get; set; }


		internal UpdateDailyPayData()
		{
			this.data = new DailyPayData();
			this.remaintime = 0;
			this.maxnum = 0;
		}

	}

}

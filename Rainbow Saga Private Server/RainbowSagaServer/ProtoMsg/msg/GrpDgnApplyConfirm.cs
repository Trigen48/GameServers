using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GrpDgnApplyConfirm
	{

		[ProtoMember(1)]
		public int dgnid{ get; set; }

		[ProtoMember(2)]
		public int enterType{ get; set; }


		internal GrpDgnApplyConfirm()
		{
			this.dgnid = 0;
			this.enterType = 0;
		}

	}

}

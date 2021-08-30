using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TriggerMobInfo
	{

		[ProtoMember(1)]
		public int mobid{ get; set; }

		[ProtoMember(2)]
		public int mobnum{ get; set; }


		internal TriggerMobInfo()
		{
			this.mobid = 0;
			this.mobnum = 0;
		}

	}

}

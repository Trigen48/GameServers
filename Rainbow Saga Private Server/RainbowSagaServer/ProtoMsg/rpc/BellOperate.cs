using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class BellOperate
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public int result{ get; set; }

		[ProtoMember(4)]
		public int cooldown{ get; set; }


		internal BellOperate()
		{
			this.op = 0;
			this.id = 0;
			this.result = 0;
			this.cooldown = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BellInfo
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int ringCount{ get; set; }

		[ProtoMember(3)]
		public int ringTime{ get; set; }


		internal BellInfo()
		{
			this.id = 0;
			this.ringCount = 0;
			this.ringTime = 0;
		}

	}

}

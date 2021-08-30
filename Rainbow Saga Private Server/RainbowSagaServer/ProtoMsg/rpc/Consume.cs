using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class Consume
	{

		[ProtoMember(1)]
		public string slotId{ get; set; }

		[ProtoMember(2)]
		public int id{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }

		[ProtoMember(4)]
		public int index{ get; set; }


		internal Consume()
		{
			this.slotId ="";
			this.id = 0;
			this.num = 0;
			this.index = 0;
		}

	}

}

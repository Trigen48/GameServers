using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateQuestObjNum
	{

		[ProtoMember(1)]
		public int n{ get; set; }

		[ProtoMember(2)]
		public int t{ get; set; }

		[ProtoMember(3)]
		public int i{ get; set; }

		[ProtoMember(4)]
		public int id{ get; set; }


		internal UpdateQuestObjNum()
		{
			this.n = 0;
			this.t = 0;
			this.i = 0;
			this.id = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class SetNpcStatus
	{

		[ProtoMember(1)]
		public int npcid{ get; set; }

		[ProtoMember(2)]
		public int op{ get; set; }

		[ProtoMember(3)]
		public int posX{ get; set; }

		[ProtoMember(4)]
		public int posY{ get; set; }


		internal SetNpcStatus()
		{
			this.npcid = 0;
			this.op = 0;
			this.posX = 0;
			this.posY = 0;
		}

	}

}

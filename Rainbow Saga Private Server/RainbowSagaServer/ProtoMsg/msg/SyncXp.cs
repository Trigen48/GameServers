using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncXp
	{

		[ProtoMember(1)]
		public int objType{ get; set; }

		[ProtoMember(2)]
		public int objId{ get; set; }

		[ProtoMember(3)]
		public int amount{ get; set; }

		[ProtoMember(4)]
		public int refresh{ get; set; }

		[ProtoMember(5)]
		public int opcode{ get; set; }

		[ProtoMember(6)]
		public float recoverRate{ get; set; }


		internal SyncXp()
		{
			this.objType = 0;
			this.objId = 0;
			this.amount = 0;
			this.refresh = 0;
			this.opcode = 0;
			this.recoverRate = 0.0f;
		}

	}

}

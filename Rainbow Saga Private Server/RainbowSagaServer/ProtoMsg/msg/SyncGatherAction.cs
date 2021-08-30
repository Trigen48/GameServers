using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncGatherAction
	{

		[ProtoMember(1)]
		public int charId{ get; set; }

		[ProtoMember(2)]
		public int objId{ get; set; }

		[ProtoMember(3)]
		public int opType{ get; set; }


		internal SyncGatherAction()
		{
			this.charId = 0;
			this.objId = 0;
			this.opType = 0;
		}

	}

}

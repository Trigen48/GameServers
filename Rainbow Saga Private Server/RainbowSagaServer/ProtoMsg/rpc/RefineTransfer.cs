using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class RefineTransfer
	{

		[ProtoMember(1)]
		public string sourceSlotId{ get; set; }

		[ProtoMember(2)]
		public string targetSlotId{ get; set; }


		internal RefineTransfer()
		{
			this.sourceSlotId ="";
			this.targetSlotId ="";
		}

	}

}

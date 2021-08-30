using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class Unlock
	{

		[ProtoMember(1)]
		public int packageId{ get; set; }

		[ProtoMember(2)]
		public int slotSum{ get; set; }


		internal Unlock()
		{
			this.packageId = 0;
			this.slotSum = 0;
		}

	}

}

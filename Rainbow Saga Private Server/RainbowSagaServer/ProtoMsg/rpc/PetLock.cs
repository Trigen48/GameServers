using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PetLock
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int locked{ get; set; }


		internal PetLock()
		{
			this.uuid = 0;
			this.locked = 0;
		}

	}

}

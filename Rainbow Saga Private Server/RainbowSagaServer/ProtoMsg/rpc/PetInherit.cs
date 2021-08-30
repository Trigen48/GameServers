using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PetInherit
	{

		[ProtoMember(1)]
		public ulong sourceUuid{ get; set; }

		[ProtoMember(2)]
		public ulong destUuid{ get; set; }


		internal PetInherit()
		{
			this.sourceUuid = 0;
			this.destUuid = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class FreePet
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }


		internal FreePet()
		{
			this.uuid = 0;
		}

	}

}

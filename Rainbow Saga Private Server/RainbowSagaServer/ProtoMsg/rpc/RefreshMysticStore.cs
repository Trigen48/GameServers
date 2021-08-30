using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class RefreshMysticStore
	{

		[ProtoMember(1)]
		public int unused{ get; set; }


		internal RefreshMysticStore()
		{
			this.unused = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetFixedPayActInfo
	{

		[ProtoMember(1)]
		public uint unused{ get; set; }


		internal GetFixedPayActInfo()
		{
			this.unused = 0;
		}

	}

}

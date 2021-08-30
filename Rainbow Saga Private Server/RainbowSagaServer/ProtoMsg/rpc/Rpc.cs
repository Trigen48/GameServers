using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class Rpc
	{

		[ProtoMember(1)]
		public string name{ get; set; }

		[ProtoMember(20)]
		public byte[]  message{ get; set; }


		internal Rpc()
		{
			this.name ="";
			this.message = null;
		}

	}

}

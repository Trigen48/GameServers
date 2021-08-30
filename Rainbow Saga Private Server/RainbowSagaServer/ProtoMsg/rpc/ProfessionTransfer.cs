using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ProfessionTransfer
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }


		internal ProfessionTransfer()
		{
			this.id = 0;
			this.result = 0;
		}

	}

}

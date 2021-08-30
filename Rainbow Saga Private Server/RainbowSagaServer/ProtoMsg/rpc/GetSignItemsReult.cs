using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetSignItemsReult
	{

		[ProtoMember(1)]
		public uint ret{ get; set; }

		[ProtoMember(2)]
		public uint days{ get; set; }

		[ProtoMember(3)]
		public uint type{ get; set; }


		internal GetSignItemsReult()
		{
			this.ret = 0;
			this.days = 0;
			this.type = 0;
		}

	}

}

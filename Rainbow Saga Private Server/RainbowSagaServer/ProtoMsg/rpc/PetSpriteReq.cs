using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PetSpriteReq
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int result{ get; set; }

		[ProtoMember(3)]
		public int stonelevel{ get; set; }

		[ProtoMember(4)]
		public int posid{ get; set; }

		[ProtoMember(5)]
		public int stoneid{ get; set; }


		internal PetSpriteReq()
		{
			this.op = 0;
			this.result = 0;
			this.stonelevel = 0;
			this.posid = 0;
			this.stoneid = 0;
		}

	}

}

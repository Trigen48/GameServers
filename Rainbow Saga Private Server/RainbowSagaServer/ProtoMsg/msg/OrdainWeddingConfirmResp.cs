using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OrdainWeddingConfirmResp
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int ordainTime{ get; set; }

		[ProtoMember(3)]
		public int grade{ get; set; }

		[ProtoMember(4)]
		public int index{ get; set; }


		internal OrdainWeddingConfirmResp()
		{
			this.result = 0;
			this.ordainTime = 0;
			this.grade = 0;
			this.index = 0;
		}

	}

}

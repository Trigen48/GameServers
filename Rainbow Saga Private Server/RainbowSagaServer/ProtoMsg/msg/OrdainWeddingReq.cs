using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OrdainWeddingReq
	{

		[ProtoMember(1)]
		public int index{ get; set; }

		[ProtoMember(2)]
		public int grade{ get; set; }


		internal OrdainWeddingReq()
		{
			this.index = 0;
			this.grade = 0;
		}

	}

}

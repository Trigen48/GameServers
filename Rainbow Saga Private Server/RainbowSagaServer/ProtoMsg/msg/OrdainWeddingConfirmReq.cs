using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OrdainWeddingConfirmReq
	{

		[ProtoMember(1)]
		public string cpName{ get; set; }

		[ProtoMember(2)]
		public int index{ get; set; }

		[ProtoMember(3)]
		public int grade{ get; set; }


		internal OrdainWeddingConfirmReq()
		{
			this.cpName ="";
			this.index = 0;
			this.grade = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetMyOrdainInfoResp
	{

		[ProtoMember(1)]
		public string charNames{ get; set; }

		[ProtoMember(2)]
		public int date{ get; set; }

		[ProtoMember(3)]
		public int result{ get; set; }


		internal GetMyOrdainInfoResp()
		{
			this.charNames ="";
			this.date = 0;
			this.result = 0;
		}

	}

}

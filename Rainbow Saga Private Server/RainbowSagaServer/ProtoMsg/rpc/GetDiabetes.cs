using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class GetDiabetes
	{

		[ProtoMember(1)]
		public ThreeDiabetesInfo info{ get; set; }

		[ProtoMember(2)]
		public ThreeDiabetesMap minfo{ get; set; }


		internal GetDiabetes()
		{
			this.info = new ThreeDiabetesInfo();
			this.minfo = new ThreeDiabetesMap();
		}

	}

}

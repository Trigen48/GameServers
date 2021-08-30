using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetMarriageResp
	{

		[ProtoMember(1)]
		public MarriageInfo info{ get; set; }


		internal GetMarriageResp()
		{
			this.info = new MarriageInfo();
		}

	}

}

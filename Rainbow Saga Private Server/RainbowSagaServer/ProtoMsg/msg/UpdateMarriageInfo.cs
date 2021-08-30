using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdateMarriageInfo
	{

		[ProtoMember(1)]
		public int updateType{ get; set; }

		[ProtoMember(2)]
		public MarriageInfo info{ get; set; }


		internal UpdateMarriageInfo()
		{
			this.updateType = 0;
			this.info = new MarriageInfo();
		}

	}

}

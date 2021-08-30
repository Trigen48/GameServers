using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetDngAreaPassAwardReq
	{

		[ProtoMember(1)]
		public int areaid{ get; set; }

		[ProtoMember(2)]
		public int awardType{ get; set; }


		internal GetDngAreaPassAwardReq()
		{
			this.areaid = 0;
			this.awardType = 0;
		}

	}

}

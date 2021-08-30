using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class GetLimitItemRemainRsp
	{

		[ProtoMember(1)]
		public int remain{ get; set; }


		internal GetLimitItemRemainRsp()
		{
			this.remain = 0;
		}

	}

}

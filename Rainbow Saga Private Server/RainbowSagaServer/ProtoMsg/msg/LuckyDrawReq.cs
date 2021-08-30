using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LuckyDrawReq
	{

		[ProtoMember(1)]
		public int index{ get; set; }


		internal LuckyDrawReq()
		{
			this.index = 0;
		}

	}

}

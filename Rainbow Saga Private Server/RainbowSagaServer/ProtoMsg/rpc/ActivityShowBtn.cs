using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ActivityShowBtn
	{

		[ProtoMember(1)]
		public int i{ get; set; }

		[ProtoMember(2)]
		public int show{ get; set; }


		internal ActivityShowBtn()
		{
			this.i = 0;
			this.show = 0;
		}

	}

}

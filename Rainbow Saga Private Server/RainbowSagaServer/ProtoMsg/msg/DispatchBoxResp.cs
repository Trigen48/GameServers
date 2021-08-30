using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DispatchBoxResp
	{

		[ProtoMember(1)]
		public int currNum{ get; set; }


		internal DispatchBoxResp()
		{
			this.currNum = 0;
		}

	}

}

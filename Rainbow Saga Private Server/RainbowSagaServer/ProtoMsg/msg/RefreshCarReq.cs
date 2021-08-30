using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RefreshCarReq
	{

		[ProtoMember(1)]
		public int type{ get; set; }


		internal RefreshCarReq()
		{
			this.type = 0;
		}

	}

}

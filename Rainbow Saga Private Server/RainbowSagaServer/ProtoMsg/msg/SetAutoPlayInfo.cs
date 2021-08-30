using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SetAutoPlayInfo
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int param{ get; set; }


		internal SetAutoPlayInfo()
		{
			this.type = 0;
			this.param = 0;
		}

	}

}

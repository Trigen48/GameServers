using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RobCarResp
	{

		[ProtoMember(1)]
		public string robbedname{ get; set; }

		[ProtoMember(2)]
		public string robname{ get; set; }

		[ProtoMember(3)]
		public int ret{ get; set; }


		internal RobCarResp()
		{
			this.robbedname ="";
			this.robname ="";
			this.ret = 0;
		}

	}

}

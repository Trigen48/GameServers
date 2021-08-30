using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class L2pwdData
	{

		[ProtoMember(1)]
		public int state{ get; set; }

		[ProtoMember(2)]
		public int pwd{ get; set; }

		[ProtoMember(3)]
		public int resettime{ get; set; }


		internal L2pwdData()
		{
			this.state = 0;
			this.pwd = 0;
			this.resettime = 0;
		}

	}

}

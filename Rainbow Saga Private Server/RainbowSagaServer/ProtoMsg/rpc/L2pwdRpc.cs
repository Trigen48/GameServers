using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class L2pwdRpc
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int pwd{ get; set; }

		[ProtoMember(3)]
		public int oldpwd{ get; set; }


		internal L2pwdRpc()
		{
			this.op = 0;
			this.pwd = 0;
			this.oldpwd = 0;
		}

	}

}

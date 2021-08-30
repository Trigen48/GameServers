using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class L2pwdUpdate
	{

		[ProtoMember(1)]
		public L2pwdData data{ get; set; }

		[ProtoMember(2)]
		public int srvtime{ get; set; }

		[ProtoMember(3)]
		public int authed{ get; set; }


		internal L2pwdUpdate()
		{
			this.data = new L2pwdData();
			this.srvtime = 0;
			this.authed = 0;
		}

	}

}

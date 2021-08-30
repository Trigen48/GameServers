using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LogoutNotify
	{

		[ProtoMember(1)]
		public string username{ get; set; }

		[ProtoMember(2)]
		public int logoutType{ get; set; }


		internal LogoutNotify()
		{
			this.username ="";
			this.logoutType = 0;
		}

	}

}

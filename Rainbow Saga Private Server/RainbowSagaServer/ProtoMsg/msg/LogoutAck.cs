using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LogoutAck
	{

		[ProtoMember(1)]
		public string username{ get; set; }


		internal LogoutAck()
		{
			this.username ="";
		}

	}

}

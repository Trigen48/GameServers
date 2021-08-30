using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class RobCarReq
	{

		[ProtoMember(1)]
		public string robbedname{ get; set; }


		internal RobCarReq()
		{
			this.robbedname ="";
		}

	}

}

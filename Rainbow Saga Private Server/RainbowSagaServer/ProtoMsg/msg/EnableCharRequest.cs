using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnableCharRequest
	{

		[ProtoMember(1)]
		public string uin{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int charid{ get; set; }


		internal EnableCharRequest()
		{
			this.uin ="";
			this.charname ="";
			this.charid = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterZoneRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public string username{ get; set; }

		[ProtoMember(3)]
		public int charid{ get; set; }

		[ProtoMember(4)]
		public int zoneid{ get; set; }


		internal EnterZoneRequest()
		{
			this.type = 0;
			this.username ="";
			this.charid = 0;
			this.zoneid = 0;
		}

	}

}

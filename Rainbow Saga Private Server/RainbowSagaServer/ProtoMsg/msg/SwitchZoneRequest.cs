using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SwitchZoneRequest
	{

		[ProtoMember(1, IsRequired=true)]
		public string username{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int zoneidTo{ get; set; }


		internal SwitchZoneRequest()
		{
			this.username ="";
			this.zoneidTo = 0;
		}

	}

}

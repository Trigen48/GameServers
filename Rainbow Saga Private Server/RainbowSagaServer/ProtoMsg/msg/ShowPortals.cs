using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ShowPortals
	{

		[ProtoMember(1)]
		public int unused{ get; set; }

		[ProtoMember(2)]
		public string portalnames{ get; set; }


		internal ShowPortals()
		{
			this.unused = 0;
			this.portalnames ="";
		}

	}

}

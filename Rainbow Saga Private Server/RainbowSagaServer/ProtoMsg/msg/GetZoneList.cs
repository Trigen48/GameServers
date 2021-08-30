using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetZoneList
	{

		[ProtoMember(1)]
		public int enterZoneType{ get; set; }


		internal GetZoneList()
		{
			this.enterZoneType = 0;
		}

	}

}

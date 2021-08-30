using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetActivateMapsAck
	{

		[ProtoMember(1)]
		public WorldMapInfo infos{ get; set; }


		internal GetActivateMapsAck()
		{
			this.infos = new WorldMapInfo();
		}

	}

}

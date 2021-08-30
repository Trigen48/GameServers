using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class WorldMapInfo
	{

		[ProtoMember(1)]
		public int mapids{ get; set; }


		internal WorldMapInfo()
		{
			this.mapids = 0;
		}

	}

}

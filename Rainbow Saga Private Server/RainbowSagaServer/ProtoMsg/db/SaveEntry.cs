using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class SaveEntry
	{

		[ProtoMember(1)]
		public int mapid{ get; set; }

		[ProtoMember(2)]
		public int x{ get; set; }

		[ProtoMember(3)]
		public int y{ get; set; }


		internal SaveEntry()
		{
			this.mapid = 0;
			this.x = 0;
			this.y = 0;
		}

	}

}

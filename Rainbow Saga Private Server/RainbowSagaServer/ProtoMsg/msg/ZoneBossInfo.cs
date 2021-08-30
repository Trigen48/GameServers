using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ZoneBossInfo
	{

		[ProtoMember(1)]
		public int zoneid{ get; set; }

		[ProtoMember(2)]
		public int bossmark{ get; set; }

		[ProtoMember(3)]
		public int bossid{ get; set; }

		[ProtoMember(4)]
		public int state{ get; set; }

		[ProtoMember(5)]
		public int batch{ get; set; }

		[ProtoMember(6)]
		public string killer{ get; set; }


		internal ZoneBossInfo()
		{
			this.zoneid = 0;
			this.bossmark = 0;
			this.bossid = 0;
			this.state = 0;
			this.batch = 0;
			this.killer ="";
		}

	}

}

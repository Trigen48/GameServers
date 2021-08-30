using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetDgnInfoOfAreaMapAck
	{

		[ProtoMember(1)]
		public List<DgnDisplayInfo> infos{ get; set; }

		[ProtoMember(2)]
		public int awarded{ get; set; }

		[ProtoMember(3)]
		public int greenAwarded{ get; set; }

		[ProtoMember(4)]
		public int blueAwarded{ get; set; }

		[ProtoMember(5)]
		public int purpleAwarded{ get; set; }


		internal GetDgnInfoOfAreaMapAck()
		{
			this.infos = new List<DgnDisplayInfo>();
			this.awarded = 0;
			this.greenAwarded = 0;
			this.blueAwarded = 0;
			this.purpleAwarded = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class BroadcastMarriageInfo
	{

		[ProtoMember(1)]
		public int updateType{ get; set; }

		[ProtoMember(2)]
		public int cpId{ get; set; }

		[ProtoMember(3)]
		public int charId{ get; set; }

		[ProtoMember(4)]
		public int marriageLevel{ get; set; }


		internal BroadcastMarriageInfo()
		{
			this.updateType = 0;
			this.cpId = 0;
			this.charId = 0;
			this.marriageLevel = 0;
		}

	}

}

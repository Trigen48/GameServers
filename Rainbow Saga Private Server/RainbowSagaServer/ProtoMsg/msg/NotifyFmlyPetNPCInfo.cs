using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyFmlyPetNPCInfo
	{

		[ProtoMember(1)]
		public int show{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }


		internal NotifyFmlyPetNPCInfo()
		{
			this.show = 0;
			this.level = 0;
		}

	}

}

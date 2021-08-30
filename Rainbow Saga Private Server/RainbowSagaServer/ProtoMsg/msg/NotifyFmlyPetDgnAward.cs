using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyFmlyPetDgnAward
	{

		[ProtoMember(1)]
		public int exp{ get; set; }

		[ProtoMember(2)]
		public int rate{ get; set; }


		internal NotifyFmlyPetDgnAward()
		{
			this.exp = 0;
			this.rate = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyStoneGiftId
	{

		[ProtoMember(1)]
		public int gifts{ get; set; }


		internal FmlyStoneGiftId()
		{
			this.gifts = 0;
		}

	}

}

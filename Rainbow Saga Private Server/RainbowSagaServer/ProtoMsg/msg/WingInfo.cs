using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class WingInfo
	{

		[ProtoMember(1)]
		public int level{ get; set; }

		[ProtoMember(2)]
		public int exp{ get; set; }

		[ProtoMember(3)]
		public int num{ get; set; }

		[ProtoMember(4)]
		public int lastTime{ get; set; }

		[ProtoMember(5)]
		public int cardList{ get; set; }

		[ProtoMember(7)]
		public int equiponId{ get; set; }


		internal WingInfo()
		{
			this.level = 0;
			this.exp = 0;
			this.num = 0;
			this.lastTime = 0;
			this.cardList = 0;
			this.equiponId = 0;
		}

	}

}

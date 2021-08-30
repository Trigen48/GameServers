using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GiftCell
	{

		[ProtoMember(1)]
		public int index{ get; set; }

		[ProtoMember(2)]
		public int state{ get; set; }

		[ProtoMember(3)]
		public int timeStamp{ get; set; }


		internal GiftCell()
		{
			this.index = 0;
			this.state = 0;
			this.timeStamp = 0;
		}

	}

}

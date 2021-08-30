using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class WingCardGetList
	{

		[ProtoMember(1)]
		public int equipon{ get; set; }

		[ProtoMember(2)]
		public int activated{ get; set; }


		internal WingCardGetList()
		{
			this.equipon = 0;
			this.activated = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class NotifyFmlyStoneUpgrade
	{

		[ProtoMember(1)]
		public int lv{ get; set; }


		internal NotifyFmlyStoneUpgrade()
		{
			this.lv = 0;
		}

	}

}

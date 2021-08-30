using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class LevelupSendItem
	{

		[ProtoMember(1)]
		public int leadId{ get; set; }

		[ProtoMember(2)]
		public int level{ get; set; }


		internal LevelupSendItem()
		{
			this.leadId = 0;
			this.level = 0;
		}

	}

}

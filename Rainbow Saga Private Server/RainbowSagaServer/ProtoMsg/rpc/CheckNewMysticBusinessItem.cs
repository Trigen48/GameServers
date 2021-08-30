using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class CheckNewMysticBusinessItem
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int starttime{ get; set; }


		internal CheckNewMysticBusinessItem()
		{
			this.type = 0;
			this.starttime = 0;
		}

	}

}

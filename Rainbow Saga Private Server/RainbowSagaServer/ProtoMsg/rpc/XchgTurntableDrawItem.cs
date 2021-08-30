using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class XchgTurntableDrawItem
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int luck{ get; set; }


		internal XchgTurntableDrawItem()
		{
			this.type = 0;
			this.luck = 0;
		}

	}

}

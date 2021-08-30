using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MysticStoreInfo
	{

		[ProtoMember(2)]
		public int nextreftime{ get; set; }

		[ProtoMember(1)]
		public List<MysticStoreItem> items{ get; set; }

		[ProtoMember(3)]
		public int lasttime{ get; set; }


		internal MysticStoreInfo()
		{
			this.nextreftime = 0;
			this.items = new List<MysticStoreItem>();
			this.lasttime = 0;
		}

	}

}

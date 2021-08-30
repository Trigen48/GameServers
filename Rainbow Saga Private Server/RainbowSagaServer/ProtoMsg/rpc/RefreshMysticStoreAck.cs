using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class RefreshMysticStoreAck
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int nextreftime{ get; set; }

		[ProtoMember(3)]
		public List<MysticStoreItem> items{ get; set; }


		internal RefreshMysticStoreAck()
		{
			this.result = 0;
			this.nextreftime = 0;
			this.items = new List<MysticStoreItem>();
		}

	}

}

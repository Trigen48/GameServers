using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class CheckNewMysticBusinessItemAck
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }

		[ProtoMember(3)]
		public List<CheckNewMysticBusinessItemInfo> items{ get; set; }


		internal CheckNewMysticBusinessItemAck()
		{
			this.result = 0;
			this.type = 0;
			this.items = new List<CheckNewMysticBusinessItemInfo>();
		}

	}

}

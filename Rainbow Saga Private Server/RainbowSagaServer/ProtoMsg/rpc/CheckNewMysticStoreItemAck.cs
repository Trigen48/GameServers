using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class CheckNewMysticStoreItemAck
	{

		[ProtoMember(1)]
		public int tabnumber{ get; set; }

		[ProtoMember(2)]
		public List<NewMysticStoreCheckItemInfo> items{ get; set; }


		internal CheckNewMysticStoreItemAck()
		{
			this.tabnumber = 0;
			this.items = new List<NewMysticStoreCheckItemInfo>();
		}

	}

}

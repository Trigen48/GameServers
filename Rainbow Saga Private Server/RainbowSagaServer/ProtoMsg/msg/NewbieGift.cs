using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NewbieGift
	{

		[ProtoMember(1)]
		public List<Gift> gift{ get; set; }


		internal NewbieGift()
		{
			this.gift = new List<Gift>();
		}

	}

}

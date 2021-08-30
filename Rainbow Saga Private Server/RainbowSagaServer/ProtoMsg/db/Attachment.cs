using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class Attachment
	{

		[ProtoMember(1)]
		public int num{ get; set; }

		[ProtoMember(2)]
		public Item item{ get; set; }

		[ProtoMember(4)]
		public int deadline{ get; set; }


		internal Attachment()
		{
			this.num = 0;
			this.item = new Item();
			this.deadline = 0;
		}

	}

}

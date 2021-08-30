using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class OffLineItem
	{

		[ProtoMember(1)]
		public string id{ get; set; }

		[ProtoMember(2)]
		public int num{ get; set; }


		internal OffLineItem()
		{
			this.id ="";
			this.num = 0;
		}

	}

}

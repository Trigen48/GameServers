using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FestivalItem
	{

		[ProtoMember(1)]
		public int items{ get; set; }


		internal FestivalItem()
		{
			this.items = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ThrowableItemList
	{

		[ProtoMember(1)]
		public List<ThrowableItem> infos{ get; set; }


		internal ThrowableItemList()
		{
			this.infos = new List<ThrowableItem>();
		}

	}

}

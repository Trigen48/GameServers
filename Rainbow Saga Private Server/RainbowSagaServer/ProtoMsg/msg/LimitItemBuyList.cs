using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class LimitItemBuyList
	{

		[ProtoMember(1)]
		public List<LimitItem> limitItems{ get; set; }


		internal LimitItemBuyList()
		{
			this.limitItems = new List<LimitItem>();
		}

	}

}

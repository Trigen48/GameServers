using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class VipPrivilegeItem
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int usedCount{ get; set; }


		internal VipPrivilegeItem()
		{
			this.type = 0;
			this.usedCount = 0;
		}

	}

}

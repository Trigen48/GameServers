using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class VipPrivilege
	{

		[ProtoMember(1)]
		public int privilegeType{ get; set; }

		[ProtoMember(2)]
		public int usedCount{ get; set; }


		internal VipPrivilege()
		{
			this.privilegeType = 0;
			this.usedCount = 0;
		}

	}

}

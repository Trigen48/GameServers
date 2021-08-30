using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncVipUsedInfo
	{

		[ProtoMember(1)]
		public List<VipPrivilegeItem> items{ get; set; }

		[ProtoMember(2)]
		public int vipExp{ get; set; }

		[ProtoMember(3)]
		public int vipLevel{ get; set; }


		internal SyncVipUsedInfo()
		{
			this.items = new List<VipPrivilegeItem>();
			this.vipExp = 0;
			this.vipLevel = 0;
		}

	}

}

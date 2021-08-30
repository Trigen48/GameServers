using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class VIPInfo
	{

		[ProtoMember(1)]
		public TencentVIP yellow{ get; set; }

		[ProtoMember(2)]
		public List<VipPrivilege> vipItems{ get; set; }

		[ProtoMember(3)]
		public VipAward vipAward{ get; set; }

		[ProtoMember(4)]
		public int chatBubbleType{ get; set; }

		[ProtoMember(5)]
		public int privilegeUpTime{ get; set; }


		internal VIPInfo()
		{
			this.yellow = new TencentVIP();
			this.vipItems = new List<VipPrivilege>();
			this.vipAward = new VipAward();
			this.chatBubbleType = 0;
			this.privilegeUpTime = 0;
		}

	}

}

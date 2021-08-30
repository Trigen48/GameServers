using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GroupBrief
	{

		[ProtoMember(1, IsRequired=true)]
		public int groupid{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public string leadername{ get; set; }

		[ProtoMember(3, IsRequired=true)]
		public int level{ get; set; }

		[ProtoMember(4, IsRequired=true)]
		public int membercount{ get; set; }


		internal GroupBrief()
		{
			this.groupid = 0;
			this.leadername ="";
			this.level = 0;
			this.membercount = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyApplyListAck
	{

		[ProtoMember(1)]
		public int totalpage{ get; set; }

		[ProtoMember(2)]
		public List<FmlyBrief> applist{ get; set; }


		internal GetFamilyApplyListAck()
		{
			this.totalpage = 0;
			this.applist = new List<FmlyBrief>();
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class GetFamilyManorInfoResp
	{

		[ProtoMember(1)]
		public int inBattle{ get; set; }

		[ProtoMember(2)]
		public List<FamilyManorInfo> manorInfos{ get; set; }


		internal GetFamilyManorInfoResp()
		{
			this.inBattle = 0;
			this.manorInfos = new List<FamilyManorInfo>();
		}

	}

}

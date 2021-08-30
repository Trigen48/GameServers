using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class XoRank
	{

		[ProtoMember(1)]
		public List<XoRankItem> ranks{ get; set; }

		[ProtoMember(2)]
		public XoRankItem self{ get; set; }


		internal XoRank()
		{
			this.ranks = new List<XoRankItem>();
			this.self = new XoRankItem();
		}

	}

}

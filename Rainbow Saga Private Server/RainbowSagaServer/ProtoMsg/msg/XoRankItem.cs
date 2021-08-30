using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class XoRankItem
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int rank{ get; set; }

		[ProtoMember(3)]
		public int money{ get; set; }


		internal XoRankItem()
		{
			this.charname ="";
			this.rank = 0;
			this.money = 0;
		}

	}

}

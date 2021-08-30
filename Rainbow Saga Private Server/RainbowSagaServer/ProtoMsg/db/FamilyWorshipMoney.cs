using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FamilyWorshipMoney
	{

		[ProtoMember(1)]
		public int added{ get; set; }

		[ProtoMember(2)]
		public int remain{ get; set; }


		internal FamilyWorshipMoney()
		{
			this.added = 0;
			this.remain = 0;
		}

	}

}

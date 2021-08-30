using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class PiggyBankRequest
	{

		[ProtoMember(1)]
		public int op{ get; set; }

		[ProtoMember(2)]
		public int hammerLv{ get; set; }

		[ProtoMember(3)]
		public int gold{ get; set; }


		internal PiggyBankRequest()
		{
			this.op = 0;
			this.hammerLv = 0;
			this.gold = 0;
		}

	}

}

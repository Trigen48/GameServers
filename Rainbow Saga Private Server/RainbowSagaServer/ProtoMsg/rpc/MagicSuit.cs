using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class MagicSuit
	{

		[ProtoMember(1)]
		public List<MagicSuitInfo> suits{ get; set; }


		internal MagicSuit()
		{
			this.suits = new List<MagicSuitInfo>();
		}

	}

}

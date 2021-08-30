using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdatePriesthoodBonus
	{

		[ProtoMember(1)]
		public int priesthoodBonus{ get; set; }


		internal UpdatePriesthoodBonus()
		{
			this.priesthoodBonus = 0;
		}

	}

}

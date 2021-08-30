using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateSeabedBonus
	{

		[ProtoMember(1)]
		public int seabedBonus{ get; set; }


		internal UpdateSeabedBonus()
		{
			this.seabedBonus = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class WingCardAdd
	{

		[ProtoMember(1)]
		public int id{ get; set; }


		internal WingCardAdd()
		{
			this.id = 0;
		}

	}

}

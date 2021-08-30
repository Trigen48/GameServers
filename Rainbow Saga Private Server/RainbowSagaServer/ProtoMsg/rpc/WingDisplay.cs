using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class WingDisplay
	{

		[ProtoMember(1)]
		public int display{ get; set; }


		internal WingDisplay()
		{
			this.display = 0;
		}

	}

}

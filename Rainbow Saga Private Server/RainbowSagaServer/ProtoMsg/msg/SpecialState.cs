using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SpecialState
	{

		[ProtoMember(1)]
		public int state{ get; set; }


		internal SpecialState()
		{
			this.state = 0;
		}

	}

}

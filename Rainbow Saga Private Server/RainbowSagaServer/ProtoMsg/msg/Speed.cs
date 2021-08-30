using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Speed
	{

		[ProtoMember(1)]
		public int walk{ get; set; }

		[ProtoMember(2)]
		public int fly{ get; set; }


		internal Speed()
		{
			this.walk = 0;
			this.fly = 0;
		}

	}

}

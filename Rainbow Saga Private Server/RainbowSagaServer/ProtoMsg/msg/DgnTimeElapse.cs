using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DgnTimeElapse
	{

		[ProtoMember(1)]
		public int elapse{ get; set; }


		internal DgnTimeElapse()
		{
			this.elapse = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MobTalk
	{

		[ProtoMember(1)]
		public int msgtextid{ get; set; }


		internal MobTalk()
		{
			this.msgtextid = 0;
		}

	}

}

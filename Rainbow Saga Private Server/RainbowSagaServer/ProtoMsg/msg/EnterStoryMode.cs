using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class EnterStoryMode
	{

		[ProtoMember(1)]
		public int script{ get; set; }


		internal EnterStoryMode()
		{
			this.script = 0;
		}

	}

}

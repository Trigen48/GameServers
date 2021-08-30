using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DgnMode
	{

		[ProtoMember(1)]
		public int mode{ get; set; }


		internal DgnMode()
		{
			this.mode = 0;
		}

	}

}

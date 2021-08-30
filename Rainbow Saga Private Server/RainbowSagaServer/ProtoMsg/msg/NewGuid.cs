using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NewGuid
	{

		[ProtoMember(1)]
		public int newguidMark{ get; set; }


		internal NewGuid()
		{
			this.newguidMark = 0;
		}

	}

}

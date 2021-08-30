using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class XOMovePosition
	{

		[ProtoMember(1)]
		public int select{ get; set; }


		internal XOMovePosition()
		{
			this.select = 0;
		}

	}

}

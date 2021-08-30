using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SetRebornOption
	{

		[ProtoMember(1)]
		public int type{ get; set; }


		internal SetRebornOption()
		{
			this.type = 0;
		}

	}

}

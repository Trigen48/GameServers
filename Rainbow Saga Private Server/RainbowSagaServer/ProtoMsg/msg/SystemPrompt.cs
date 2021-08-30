using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SystemPrompt
	{

		[ProtoMember(1)]
		public int type{ get; set; }

		[ProtoMember(2)]
		public int msgTextId{ get; set; }

		[ProtoMember(3)]
		public string Params{ get; set; }


		internal SystemPrompt()
		{
			this.type = 0;
			this.msgTextId = 0;
			this.Params ="";
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PromptRecord
	{

		[ProtoMember(1)]
		public int id{ get; set; }


		internal PromptRecord()
		{
			this.id = 0;
		}

	}

}

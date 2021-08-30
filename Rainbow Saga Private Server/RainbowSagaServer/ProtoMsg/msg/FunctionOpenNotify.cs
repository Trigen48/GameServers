using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FunctionOpenNotify
	{

		[ProtoMember(1)]
		public int funid{ get; set; }


		internal FunctionOpenNotify()
		{
			this.funid = 0;
		}

	}

}

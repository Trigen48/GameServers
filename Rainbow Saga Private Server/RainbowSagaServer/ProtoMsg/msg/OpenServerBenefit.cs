using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OpenServerBenefit
	{

		[ProtoMember(1)]
		public int received{ get; set; }


		internal OpenServerBenefit()
		{
			this.received = 0;
		}

	}

}

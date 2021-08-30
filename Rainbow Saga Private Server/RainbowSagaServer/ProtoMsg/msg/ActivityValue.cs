using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ActivityValue
	{

		[ProtoMember(1)]
		public int value{ get; set; }

		[ProtoMember(2)]
		public int getedvalues{ get; set; }

		[ProtoMember(3)]
		public uint lastactivtime{ get; set; }


		internal ActivityValue()
		{
			this.value = 0;
			this.getedvalues = 0;
			this.lastactivtime = 0;
		}

	}

}

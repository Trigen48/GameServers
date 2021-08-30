using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class DoFamilyWorship
	{

		[ProtoMember(1)]
		public int charid{ get; set; }


		internal DoFamilyWorship()
		{
			this.charid = 0;
		}

	}

}

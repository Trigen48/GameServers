using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MultiGroupClash
	{

		[ProtoMember(1)]
		public uint leaveTime{ get; set; }


		internal MultiGroupClash()
		{
			this.leaveTime = 0;
		}

	}

}

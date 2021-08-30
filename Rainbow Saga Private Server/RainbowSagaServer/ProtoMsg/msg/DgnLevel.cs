using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class DgnLevel
	{

		[ProtoMember(1)]
		public int level{ get; set; }


		internal DgnLevel()
		{
			this.level = 0;
		}

	}

}

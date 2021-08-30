using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SetMpHealThreshold
	{

		[ProtoMember(1)]
		public int mpHealThreshold{ get; set; }


		internal SetMpHealThreshold()
		{
			this.mpHealThreshold = 0;
		}

	}

}

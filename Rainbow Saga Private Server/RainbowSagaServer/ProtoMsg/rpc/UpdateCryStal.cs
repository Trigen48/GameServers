using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateCryStal
	{

		[ProtoMember(1)]
		public int crystal{ get; set; }


		internal UpdateCryStal()
		{
			this.crystal = 0;
		}

	}

}

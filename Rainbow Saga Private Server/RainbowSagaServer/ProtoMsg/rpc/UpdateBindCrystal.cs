using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateBindCrystal
	{

		[ProtoMember(1)]
		public int bindCrystal{ get; set; }


		internal UpdateBindCrystal()
		{
			this.bindCrystal = 0;
		}

	}

}

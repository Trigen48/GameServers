using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ChargeLifeCrystalResp
	{

		[ProtoMember(1)]
		public int result{ get; set; }


		internal ChargeLifeCrystalResp()
		{
			this.result = 0;
		}

	}

}

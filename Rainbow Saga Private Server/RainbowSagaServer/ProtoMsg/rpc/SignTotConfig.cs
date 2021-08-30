using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SignTotConfig
	{

		[ProtoMember(1)]
		public List<SignUnit> units{ get; set; }


		internal SignTotConfig()
		{
			this.units = new List<SignUnit>();
		}

	}

}

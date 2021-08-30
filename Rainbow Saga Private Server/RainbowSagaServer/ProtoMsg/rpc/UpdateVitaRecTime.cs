using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateVitaRecTime
	{

		[ProtoMember(1)]
		public int vitaRecTime{ get; set; }


		internal UpdateVitaRecTime()
		{
			this.vitaRecTime = 0;
		}

	}

}

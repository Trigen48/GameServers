using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateHonorPoints
	{

		[ProtoMember(1)]
		public int honorPoints{ get; set; }


		internal UpdateHonorPoints()
		{
			this.honorPoints = 0;
		}

	}

}

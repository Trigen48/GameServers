using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class FamilyCrystalDonate
	{

		[ProtoMember(1)]
		public int time{ get; set; }


		internal FamilyCrystalDonate()
		{
			this.time = 0;
		}

	}

}

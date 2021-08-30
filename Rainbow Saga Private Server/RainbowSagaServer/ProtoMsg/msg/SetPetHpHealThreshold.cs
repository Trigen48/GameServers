using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SetPetHpHealThreshold
	{

		[ProtoMember(1)]
		public int threshold{ get; set; }


		internal SetPetHpHealThreshold()
		{
			this.threshold = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdatePetHpBank
	{

		[ProtoMember(1)]
		public int hpBank{ get; set; }


		internal UpdatePetHpBank()
		{
			this.hpBank = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SetPetFullHeal
	{

		[ProtoMember(1)]
		public int reserverd{ get; set; }


		internal SetPetFullHeal()
		{
			this.reserverd = 0;
		}

	}

}

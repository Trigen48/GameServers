using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class AddPet
	{

		[ProtoMember(1)]
		public Pet pet{ get; set; }


		internal AddPet()
		{
			this.pet = new Pet();
		}

	}

}

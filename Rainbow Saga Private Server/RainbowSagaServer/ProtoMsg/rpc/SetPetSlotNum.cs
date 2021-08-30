using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SetPetSlotNum
	{

		[ProtoMember(1)]
		public int slotNum{ get; set; }


		internal SetPetSlotNum()
		{
			this.slotNum = 0;
		}

	}

}

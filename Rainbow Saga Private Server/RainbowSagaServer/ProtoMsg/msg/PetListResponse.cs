using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetListResponse
	{

		[ProtoMember(1)]
		public int result{ get; set; }

		[ProtoMember(2)]
		public uint petSlotNum{ get; set; }

		[ProtoMember(3)]
		public List<Pet> pets{ get; set; }

		[ProtoMember(4)]
		public int caressNum{ get; set; }

		[ProtoMember(5)]
		public int lastCaressTime{ get; set; }

		[ProtoMember(6)]
		public ulong activePetUuid{ get; set; }

		[ProtoMember(7)]
		public ulong attachSprite1{ get; set; }

		[ProtoMember(8)]
		public ulong attachSprite2{ get; set; }

		[ProtoMember(9)]
		public ulong attachSprite3{ get; set; }

		[ProtoMember(10)]
		public ulong attachSprite4{ get; set; }

		[ProtoMember(11)]
		public ulong attachSprite5{ get; set; }

		[ProtoMember(12)]
		public int attachStone1{ get; set; }

		[ProtoMember(13)]
		public int attachStone2{ get; set; }

		[ProtoMember(14)]
		public int attachStone3{ get; set; }

		[ProtoMember(15)]
		public int attachStone4{ get; set; }

		[ProtoMember(16)]
		public int attachStone5{ get; set; }


		internal PetListResponse()
		{
			this.result = 0;
			this.petSlotNum = 0;
			this.pets = new List<Pet>();
			this.caressNum = 0;
			this.lastCaressTime = 0;
			this.activePetUuid = 0;
			this.attachSprite1 = 0;
			this.attachSprite2 = 0;
			this.attachSprite3 = 0;
			this.attachSprite4 = 0;
			this.attachSprite5 = 0;
			this.attachStone1 = 0;
			this.attachStone2 = 0;
			this.attachStone3 = 0;
			this.attachStone4 = 0;
			this.attachStone5 = 0;
		}

	}

}

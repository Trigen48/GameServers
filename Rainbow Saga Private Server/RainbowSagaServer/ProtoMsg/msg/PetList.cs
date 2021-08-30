using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetList
	{

		[ProtoMember(1)]
		public List<Pet> pets{ get; set; }

		[ProtoMember(2)]
		public int petBook{ get; set; }

		[ProtoMember(3)]
		public ulong activePetUuid{ get; set; }

		[ProtoMember(4)]
		public uint petSlotNum{ get; set; }

		[ProtoMember(7)]
		public int caressNum{ get; set; }

		[ProtoMember(11)]
		public int lastCaressTime{ get; set; }

		[ProtoMember(5)]
		public int hpBank{ get; set; }

		[ProtoMember(6)]
		public int hpHealThreshold{ get; set; }

		[ProtoMember(12)]
		public ulong attachSprite1{ get; set; }

		[ProtoMember(13)]
		public ulong attachSprite2{ get; set; }

		[ProtoMember(14)]
		public ulong attachSprite3{ get; set; }

		[ProtoMember(15)]
		public ulong attachSprite4{ get; set; }

		[ProtoMember(16)]
		public ulong attachSprite5{ get; set; }

		[ProtoMember(17)]
		public int attachStone1{ get; set; }

		[ProtoMember(18)]
		public int attachStone2{ get; set; }

		[ProtoMember(19)]
		public int attachStone3{ get; set; }

		[ProtoMember(20)]
		public int attachStone4{ get; set; }

		[ProtoMember(21)]
		public int attachStone5{ get; set; }


		internal PetList()
		{
			this.pets = new List<Pet>();
			this.petBook = 0;
			this.activePetUuid = 0;
			this.petSlotNum = 0;
			this.caressNum = 0;
			this.lastCaressTime = 0;
			this.hpBank = 0;
			this.hpHealThreshold = 0;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PetReplicaInfo
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public int unitId{ get; set; }

		[ProtoMember(3)]
		public int ownerId{ get; set; }

		[ProtoMember(4)]
		public int propId{ get; set; }

		[ProtoMember(5)]
		public string name{ get; set; }

		[ProtoMember(6)]
		public int x{ get; set; }

		[ProtoMember(7)]
		public int y{ get; set; }

		[ProtoMember(8)]
		public int direction{ get; set; }

		[ProtoMember(9)]
		public int actionId{ get; set; }

		[ProtoMember(10)]
		public int foothold{ get; set; }

		[ProtoMember(11)]
		public int deathState{ get; set; }

		[ProtoMember(12)]
		public uint specialStates{ get; set; }

		[ProtoMember(13)]
		public int grade{ get; set; }

		[ProtoMember(14)]
		public int hp{ get; set; }

		[ProtoMember(15)]
		public int maxHp{ get; set; }

		[ProtoMember(16)]
		public int destX{ get; set; }

		[ProtoMember(17)]
		public int destY{ get; set; }

		[ProtoMember(18)]
		public int walkSpeed{ get; set; }


		internal PetReplicaInfo()
		{
			this.uuid = 0;
			this.unitId = 0;
			this.ownerId = 0;
			this.propId = 0;
			this.name ="";
			this.x = 0;
			this.y = 0;
			this.direction = 0;
			this.actionId = 0;
			this.foothold = 0;
			this.deathState = 0;
			this.specialStates = 0;
			this.grade = 0;
			this.hp = 0;
			this.maxHp = 0;
			this.destX = 0;
			this.destY = 0;
			this.walkSpeed = 0;
		}

	}

}

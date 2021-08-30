using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MobReplicaInfo
	{

		[ProtoMember(1, IsRequired=true)]
		public int unitId{ get; set; }

		[ProtoMember(2, IsRequired=true)]
		public int propId{ get; set; }

		[ProtoMember(3)]
		public int difficulty{ get; set; }

		[ProtoMember(4)]
		public uint specialStates{ get; set; }

		[ProtoMember(5)]
		public int hp{ get; set; }

		[ProtoMember(6)]
		public int actionid{ get; set; }

		[ProtoMember(7)]
		public int x{ get; set; }

		[ProtoMember(8)]
		public int y{ get; set; }

		[ProtoMember(9)]
		public int direction{ get; set; }

		[ProtoMember(10)]
		public int foothold{ get; set; }

		[ProtoMember(11)]
		public int destX{ get; set; }

		[ProtoMember(12)]
		public int destY{ get; set; }

		[ProtoMember(13)]
		public int walkSpeed{ get; set; }

		[ProtoMember(14)]
		public int flySpeed{ get; set; }

		[ProtoMember(15)]
		public int spawn{ get; set; }

		[ProtoMember(16)]
		public int vx{ get; set; }

		[ProtoMember(17)]
		public int vy{ get; set; }

		[ProtoMember(18)]
		public int maxHp{ get; set; }

		[ProtoMember(19)]
		public int eliteStrategies{ get; set; }

		[ProtoMember(20)]
		public int gid{ get; set; }

		[ProtoMember(21)]
		public int specialType{ get; set; }

		[ProtoMember(22)]
		public int level{ get; set; }

		[ProtoMember(23)]
		public int bornState{ get; set; }

		[ProtoMember(24)]
		public int familyId{ get; set; }


		internal MobReplicaInfo()
		{
			this.unitId = 0;
			this.propId = 0;
			this.difficulty = 0;
			this.specialStates = 0;
			this.hp = 0;
			this.actionid = 0;
			this.x = 0;
			this.y = 0;
			this.direction = 0;
			this.foothold = 0;
			this.destX = 0;
			this.destY = 0;
			this.walkSpeed = 0;
			this.flySpeed = 0;
			this.spawn = 0;
			this.vx = 0;
			this.vy = 0;
			this.maxHp = 0;
			this.eliteStrategies = 0;
			this.gid = 0;
			this.specialType = 0;
			this.level = 0;
			this.bornState = 0;
			this.familyId = 0;
		}

	}

}

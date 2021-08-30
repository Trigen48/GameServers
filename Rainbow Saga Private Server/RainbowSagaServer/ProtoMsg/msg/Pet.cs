using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Pet
	{

		[ProtoMember(1)]
		public ulong uuid{ get; set; }

		[ProtoMember(2)]
		public string name{ get; set; }

		[ProtoMember(3)]
		public int exp{ get; set; }

		[ProtoMember(4)]
		public int hp{ get; set; }

		[ProtoMember(5)]
		public int level{ get; set; }

		[ProtoMember(6)]
		public int grade{ get; set; }

		[ProtoMember(8)]
		public int upgradeBonus{ get; set; }

		[ProtoMember(9)]
		public int propId{ get; set; }

		[ProtoMember(10)]
		public List<PetSkill> skills{ get; set; }

		[ProtoMember(11)]
		public int combatPower{ get; set; }

		[ProtoMember(12)]
		public int isFree{ get; set; }

		[ProtoMember(13)]
		public uint freeTime{ get; set; }

		[ProtoMember(14)]
		public uint combatPowerTime{ get; set; }

		[ProtoMember(15)]
		public int locked{ get; set; }


		internal Pet()
		{
			this.uuid = 0;
			this.name ="";
			this.exp = 0;
			this.hp = 0;
			this.level = 0;
			this.grade = 0;
			this.upgradeBonus = 0;
			this.propId = 0;
			this.skills = new List<PetSkill>();
			this.combatPower = 0;
			this.isFree = 0;
			this.freeTime = 0;
			this.combatPowerTime = 0;
			this.locked = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class PlayerReplicaInfo
	{

		[ProtoMember(1)]
		public int id{ get; set; }

		[ProtoMember(2)]
		public string charname{ get; set; }

		[ProtoMember(3)]
		public int profession{ get; set; }

		[ProtoMember(4)]
		public int gender{ get; set; }

		[ProtoMember(5)]
		public int level{ get; set; }

		[ProtoMember(6)]
		public int x{ get; set; }

		[ProtoMember(7)]
		public int y{ get; set; }

		[ProtoMember(8)]
		public int direction{ get; set; }

		[ProtoMember(9)]
		public int actionid{ get; set; }

		[ProtoMember(10)]
		public int foothold{ get; set; }

		[ProtoMember(11)]
		public int ladderrope{ get; set; }

		[ProtoMember(12)]
		public int speed{ get; set; }

		[ProtoMember(13)]
		public string familyname{ get; set; }

		[ProtoMember(14)]
		public EquipmentInventory euipon{ get; set; }

		[ProtoMember(15)]
		public int status{ get; set; }

		[ProtoMember(17)]
		public int face{ get; set; }

		[ProtoMember(18)]
		public int hair{ get; set; }

		[ProtoMember(19)]
		public int skinType{ get; set; }

		[ProtoMember(20)]
		public int fashionEquiponPreDisplay{ get; set; }

		[ProtoMember(21)]
		public int deathState{ get; set; }

		[ProtoMember(22)]
		public uint specialStates{ get; set; }

		[ProtoMember(23)]
		public int afkState{ get; set; }

		[ProtoMember(24)]
		public int afkAvatarId{ get; set; }

		[ProtoMember(25)]
		public int maxHp{ get; set; }

		[ProtoMember(26)]
		public int maxMp{ get; set; }

		[ProtoMember(27)]
		public int hp{ get; set; }

		[ProtoMember(28)]
		public int mp{ get; set; }

		[ProtoMember(29)]
		public int vip{ get; set; }

		[ProtoMember(30)]
		public int wingDisplay{ get; set; }

		[ProtoMember(31)]
		public int vechileId{ get; set; }

		[ProtoMember(32)]
		public int vechileState{ get; set; }

		[ProtoMember(33)]
		public int designations{ get; set; }

		[ProtoMember(34)]
		public int killerMode{ get; set; }

		[ProtoMember(35)]
		public int tencentBlue{ get; set; }

		[ProtoMember(36)]
		public int familyId{ get; set; }

		[ProtoMember(37)]
		public int coupleId{ get; set; }

		[ProtoMember(38)]
		public int marriageLevel{ get; set; }


		internal PlayerReplicaInfo()
		{
			this.id = 0;
			this.charname ="";
			this.profession = 0;
			this.gender = 0;
			this.level = 0;
			this.x = 0;
			this.y = 0;
			this.direction = 0;
			this.actionid = 0;
			this.foothold = 0;
			this.ladderrope = 0;
			this.speed = 0;
			this.familyname ="";
			this.euipon = new EquipmentInventory();
			this.status = 0;
			this.face = 0;
			this.hair = 0;
			this.skinType = 0;
			this.fashionEquiponPreDisplay = 0;
			this.deathState = 0;
			this.specialStates = 0;
			this.afkState = 0;
			this.afkAvatarId = 0;
			this.maxHp = 0;
			this.maxMp = 0;
			this.hp = 0;
			this.mp = 0;
			this.vip = 0;
			this.wingDisplay = 0;
			this.vechileId = 0;
			this.vechileState = 0;
			this.designations = 0;
			this.killerMode = 0;
			this.tencentBlue = 0;
			this.familyId = 0;
			this.coupleId = 0;
			this.marriageLevel = 0;
		}

	}

}

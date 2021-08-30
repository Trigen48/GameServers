using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class CharInfo
	{

		[ProtoMember(1)]
		public string charname{ get; set; }

		[ProtoMember(2)]
		public int charid{ get; set; }

		[ProtoMember(3)]
		public ulong aid{ get; set; }

		[ProtoMember(4)]
		public string accname{ get; set; }

		[ProtoMember(5)]
		public int status{ get; set; }

		[ProtoMember(6)]
		public int scene{ get; set; }

		[ProtoMember(7)]
		public int xpos{ get; set; }

		[ProtoMember(8)]
		public int ypos{ get; set; }

		[ProtoMember(9)]
		public int lastzoneid{ get; set; }

		[ProtoMember(10)]
		public int lastdietime{ get; set; }

		[ProtoMember(11)]
		public int hp{ get; set; }

		[ProtoMember(12)]
		public int mp{ get; set; }

		[ProtoMember(13)]
		public int xp{ get; set; }

		[ProtoMember(14)]
		public int exp{ get; set; }

		[ProtoMember(15)]
		public int str{ get; set; }

		[ProtoMember(16)]
		public int dex{ get; set; }

		[ProtoMember(17)]
		public int intl{ get; set; }

		[ProtoMember(18)]
		public int con{ get; set; }

		[ProtoMember(19)]
		public int skillPoint{ get; set; }

		[ProtoMember(20)]
		public int propPoint{ get; set; }

		[ProtoMember(21)]
		public int money{ get; set; }

		[ProtoMember(22)]
		public int crystal{ get; set; }

		[ProtoMember(59)]
		public int bindCrystal{ get; set; }

		[ProtoMember(62)]
		public int quartz{ get; set; }

		[ProtoMember(23)]
		public int storeMoney{ get; set; }

		[ProtoMember(24)]
		public int numTrumpet{ get; set; }

		[ProtoMember(25)]
		public int hpPool{ get; set; }

		[ProtoMember(26)]
		public int mpPool{ get; set; }

		[ProtoMember(60)]
		public int hpHealThreshold{ get; set; }

		[ProtoMember(61)]
		public int mpHealThreshold{ get; set; }

		[ProtoMember(27)]
		public int vitality{ get; set; }

		[ProtoMember(28)]
		public int vitarectime{ get; set; }

		[ProtoMember(29)]
		public long familyid{ get; set; }

		[ProtoMember(30)]
		public int energy{ get; set; }

		[ProtoMember(31)]
		public int energyrectime{ get; set; }

		[ProtoMember(32)]
		public int fashionEquiponPreDisplay{ get; set; }

		[ProtoMember(33)]
		public int skinType{ get; set; }

		[ProtoMember(34)]
		public int face{ get; set; }

		[ProtoMember(35)]
		public int hair{ get; set; }

		[ProtoMember(36)]
		public int relivehpfactor{ get; set; }

		[ProtoMember(37)]
		public int reliveexpfactor{ get; set; }

		[ProtoMember(38)]
		public int dailyrefreshtime{ get; set; }

		[ProtoMember(39)]
		public int level{ get; set; }

		[ProtoMember(40)]
		public int gender{ get; set; }

		[ProtoMember(41)]
		public int profession{ get; set; }

		[ProtoMember(42)]
		public string epi{ get; set; }

		[ProtoMember(43)]
		public int createtime{ get; set; }

		[ProtoMember(44)]
		public int logouttime{ get; set; }

		[ProtoMember(45)]
		public int logintime{ get; set; }

		[ProtoMember(46)]
		public int onlinetime{ get; set; }

		[ProtoMember(47)]
		public int deletetime{ get; set; }

		[ProtoMember(48)]
		public int ban{ get; set; }

		[ProtoMember(49)]
		public int banExpires{ get; set; }

		[ProtoMember(50)]
		public int afkOfflinetime{ get; set; }

		[ProtoMember(54)]
		public int familyContri{ get; set; }

		[ProtoMember(63)]
		public int familyTotalContri{ get; set; }

		[ProtoMember(64)]
		public int crystalhistory{ get; set; }

		[ProtoMember(56)]
		public uint newbieLoginNum{ get; set; }

		[ProtoMember(57)]
		public int newbieLastLoginTime{ get; set; }

		[ProtoMember(58)]
		public int levelTime{ get; set; }

		[ProtoMember(65)]
		public int createdWorldId{ get; set; }

		[ProtoMember(66)]
		public string source{ get; set; }

		[ProtoMember(67)]
		public int wingDisplay{ get; set; }

		[ProtoMember(51)]
		public EquipmentInventory bEquipon{ get; set; }

		[ProtoMember(52)]
		public CharExtraInfo bInfo{ get; set; }


		internal CharInfo()
		{
			this.charname ="";
			this.charid = 0;
			this.aid = 0;
			this.accname ="";
			this.status = 0;
			this.scene = 0;
			this.xpos = 0;
			this.ypos = 0;
			this.lastzoneid = 0;
			this.lastdietime = 0;
			this.hp = 0;
			this.mp = 0;
			this.xp = 0;
			this.exp = 0;
			this.str = 0;
			this.dex = 0;
			this.intl = 0;
			this.con = 0;
			this.skillPoint = 0;
			this.propPoint = 0;
			this.money = 0;
			this.crystal = 0;
			this.bindCrystal = 0;
			this.quartz = 0;
			this.storeMoney = 0;
			this.numTrumpet = 0;
			this.hpPool = 0;
			this.mpPool = 0;
			this.hpHealThreshold = 0;
			this.mpHealThreshold = 0;
			this.vitality = 0;
			this.vitarectime = 0;
			this.familyid = 0;
			this.energy = 0;
			this.energyrectime = 0;
			this.fashionEquiponPreDisplay = 0;
			this.skinType = 0;
			this.face = 0;
			this.hair = 0;
			this.relivehpfactor = 0;
			this.reliveexpfactor = 0;
			this.dailyrefreshtime = 0;
			this.level = 0;
			this.gender = 0;
			this.profession = 0;
			this.epi ="";
			this.createtime = 0;
			this.logouttime = 0;
			this.logintime = 0;
			this.onlinetime = 0;
			this.deletetime = 0;
			this.ban = 0;
			this.banExpires = 0;
			this.afkOfflinetime = 0;
			this.familyContri = 0;
			this.familyTotalContri = 0;
			this.crystalhistory = 0;
			this.newbieLoginNum = 0;
			this.newbieLastLoginTime = 0;
			this.levelTime = 0;
			this.createdWorldId = 0;
			this.source ="";
			this.wingDisplay = 0;
			this.bEquipon = new EquipmentInventory();
			this.bInfo = new CharExtraInfo();
		}

	}

}

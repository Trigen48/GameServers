using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class OffLineProp
	{

		[ProtoMember(1)]
		public uint mastery{ get; set; }

		[ProtoMember(2)]
		public uint crtRate{ get; set; }

		[ProtoMember(3)]
		public uint phyAtk{ get; set; }

		[ProtoMember(4)]
		public uint phyDef{ get; set; }

		[ProtoMember(5)]
		public uint macAtk{ get; set; }

		[ProtoMember(6)]
		public uint macDef{ get; set; }

		[ProtoMember(7)]
		public uint phyAccRate{ get; set; }

		[ProtoMember(8)]
		public int macAccRate{ get; set; }

		[ProtoMember(9)]
		public uint phyDodgeRate{ get; set; }

		[ProtoMember(10)]
		public uint macDodgeRate{ get; set; }

		[ProtoMember(11)]
		public uint poir{ get; set; }

		[ProtoMember(12)]
		public uint thunder{ get; set; }

		[ProtoMember(13)]
		public uint icer{ get; set; }

		[ProtoMember(14)]
		public uint firer{ get; set; }

		[ProtoMember(15)]
		public uint darkr{ get; set; }

		[ProtoMember(16)]
		public uint holyr{ get; set; }

		[ProtoMember(17)]
		public uint seal{ get; set; }

		[ProtoMember(18)]
		public uint root{ get; set; }

		[ProtoMember(19)]
		public uint curse{ get; set; }

		[ProtoMember(20)]
		public uint deceleration{ get; set; }

		[ProtoMember(21)]
		public uint frozen{ get; set; }

		[ProtoMember(22)]
		public uint stun{ get; set; }

		[ProtoMember(23)]
		public uint proppoint{ get; set; }

		[ProtoMember(24)]
		public uint maxHp{ get; set; }

		[ProtoMember(25)]
		public uint maxMp{ get; set; }

		[ProtoMember(26)]
		public uint crtMaxRate{ get; set; }

		[ProtoMember(27)]
		public uint crtMinRate{ get; set; }

		[ProtoMember(28)]
		public uint combatPowerTotal{ get; set; }

		[ProtoMember(29)]
		public uint combatPowerPlayer{ get; set; }

		[ProtoMember(30)]
		public uint pvpDmgDec{ get; set; }

		[ProtoMember(31)]
		public uint pvpDmgInc{ get; set; }

		[ProtoMember(32)]
		public uint phyDefDecay{ get; set; }

		[ProtoMember(33)]
		public uint macDefDecay{ get; set; }

		[ProtoMember(34)]
		public uint crtRateDecay{ get; set; }

		[ProtoMember(35)]
		public uint crtDecay{ get; set; }

		[ProtoMember(36)]
		public uint wingCombat{ get; set; }

		[ProtoMember(37)]
		public uint mountCombat{ get; set; }

		[ProtoMember(38)]
		public uint equipGemCombat{ get; set; }

		[ProtoMember(39)]
		public uint equipStrengthenCombat{ get; set; }

		[ProtoMember(40)]
		public uint starAddCombat{ get; set; }

		[ProtoMember(41)]
		public uint equipStrengthenLvl{ get; set; }

		[ProtoMember(42)]
		public uint wingCombatTime{ get; set; }

		[ProtoMember(43)]
		public uint mountCombatTime{ get; set; }

		[ProtoMember(44)]
		public uint equipGemCombatTime{ get; set; }

		[ProtoMember(45)]
		public uint starAddCombatTime{ get; set; }

		[ProtoMember(46)]
		public uint equipStrengthenLvlTime{ get; set; }

		[ProtoMember(47)]
		public uint wingLevel{ get; set; }

		[ProtoMember(48)]
		public uint mountLevel{ get; set; }

		[ProtoMember(49)]
		public uint combatPowerPlayerTime{ get; set; }

		[ProtoMember(50)]
		public int tencentBlue{ get; set; }

		[ProtoMember(51)]
		public uint vipLevel{ get; set; }

		[ProtoMember(52)]
		public uint pveDmgDec{ get; set; }

		[ProtoMember(53)]
		public uint pveDmgInc{ get; set; }

		[ProtoMember(54)]
		public uint dragonsoulCombat{ get; set; }

		[ProtoMember(55)]
		public uint dragonsoulCombatTime{ get; set; }

		[ProtoMember(56)]
		public uint priesthoodCombat{ get; set; }

		[ProtoMember(57)]
		public uint priesthoodCombatTime{ get; set; }

		[ProtoMember(58)]
		public uint godshipCombat{ get; set; }

		[ProtoMember(59)]
		public uint godshipCombatTime{ get; set; }

		[ProtoMember(60)]
		public int maxCombatpower{ get; set; }


		internal OffLineProp()
		{
			this.mastery = 0;
			this.crtRate = 0;
			this.phyAtk = 0;
			this.phyDef = 0;
			this.macAtk = 0;
			this.macDef = 0;
			this.phyAccRate = 0;
			this.macAccRate = 0;
			this.phyDodgeRate = 0;
			this.macDodgeRate = 0;
			this.poir = 0;
			this.thunder = 0;
			this.icer = 0;
			this.firer = 0;
			this.darkr = 0;
			this.holyr = 0;
			this.seal = 0;
			this.root = 0;
			this.curse = 0;
			this.deceleration = 0;
			this.frozen = 0;
			this.stun = 0;
			this.proppoint = 0;
			this.maxHp = 0;
			this.maxMp = 0;
			this.crtMaxRate = 0;
			this.crtMinRate = 0;
			this.combatPowerTotal = 0;
			this.combatPowerPlayer = 0;
			this.pvpDmgDec = 0;
			this.pvpDmgInc = 0;
			this.phyDefDecay = 0;
			this.macDefDecay = 0;
			this.crtRateDecay = 0;
			this.crtDecay = 0;
			this.wingCombat = 0;
			this.mountCombat = 0;
			this.equipGemCombat = 0;
			this.equipStrengthenCombat = 0;
			this.starAddCombat = 0;
			this.equipStrengthenLvl = 0;
			this.wingCombatTime = 0;
			this.mountCombatTime = 0;
			this.equipGemCombatTime = 0;
			this.starAddCombatTime = 0;
			this.equipStrengthenLvlTime = 0;
			this.wingLevel = 0;
			this.mountLevel = 0;
			this.combatPowerPlayerTime = 0;
			this.tencentBlue = 0;
			this.vipLevel = 0;
			this.pveDmgDec = 0;
			this.pveDmgInc = 0;
			this.dragonsoulCombat = 0;
			this.dragonsoulCombatTime = 0;
			this.priesthoodCombat = 0;
			this.priesthoodCombatTime = 0;
			this.godshipCombat = 0;
			this.godshipCombatTime = 0;
			this.maxCombatpower = 0;
		}

	}

}

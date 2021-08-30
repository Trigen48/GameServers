using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.game
{

	[ProtoContract]
	internal class UnitProperties
	{

		[ProtoMember(1)]
		public int str{ get; set; }

		[ProtoMember(2)]
		public int dex{ get; set; }

		[ProtoMember(3)]
		public int intl{ get; set; }

		[ProtoMember(4)]
		public int con{ get; set; }

		[ProtoMember(5)]
		public int propPoint{ get; set; }

		[ProtoMember(6)]
		public int jump{ get; set; }

		[ProtoMember(7)]
		public int walkSpeed{ get; set; }

		[ProtoMember(8)]
		public int mastery{ get; set; }

		[ProtoMember(9)]
		public int maxHp{ get; set; }

		[ProtoMember(10)]
		public int maxMp{ get; set; }

		[ProtoMember(11)]
		public int phyDef{ get; set; }

		[ProtoMember(12)]
		public int macDef{ get; set; }

		[ProtoMember(13)]
		public int phyAccRate{ get; set; }

		[ProtoMember(14)]
		public int macAccRate{ get; set; }

		[ProtoMember(15)]
		public int phyDodgeRate{ get; set; }

		[ProtoMember(16)]
		public int macDodgeRate{ get; set; }

		[ProtoMember(17)]
		public int poir{ get; set; }

		[ProtoMember(18)]
		public int firer{ get; set; }

		[ProtoMember(19)]
		public int icer{ get; set; }

		[ProtoMember(20)]
		public int thunder{ get; set; }

		[ProtoMember(21)]
		public int holyr{ get; set; }

		[ProtoMember(22)]
		public int darkr{ get; set; }

		[ProtoMember(24)]
		public int seal{ get; set; }

		[ProtoMember(25)]
		public int curse{ get; set; }

		[ProtoMember(26)]
		public int deceleration{ get; set; }

		[ProtoMember(51)]
		public int frozen{ get; set; }

		[ProtoMember(52)]
		public int stun{ get; set; }

		[ProtoMember(28)]
		public int root{ get; set; }

		[ProtoMember(31)]
		public int crtRate{ get; set; }

		[ProtoMember(32)]
		public int crtMinRate{ get; set; }

		[ProtoMember(33)]
		public int crtMaxRate{ get; set; }

		[ProtoMember(34)]
		public int itemRate{ get; set; }

		[ProtoMember(35)]
		public int moneyRate{ get; set; }

		[ProtoMember(36)]
		public int expRate{ get; set; }

		[ProtoMember(37)]
		public int healRate{ get; set; }

		[ProtoMember(38)]
		public int hateRate{ get; set; }

		[ProtoMember(39)]
		public int phyAtk{ get; set; }

		[ProtoMember(40)]
		public int macAtk{ get; set; }

		[ProtoMember(41)]
		public int maxHpRate{ get; set; }

		[ProtoMember(42)]
		public int maxMpRate{ get; set; }

		[ProtoMember(43)]
		public int phyDefRate{ get; set; }

		[ProtoMember(44)]
		public int macDefRate{ get; set; }

		[ProtoMember(45)]
		public int phyAtkRate{ get; set; }

		[ProtoMember(46)]
		public int macAtkRate{ get; set; }

		[ProtoMember(47)]
		public int hpIncrRate{ get; set; }

		[ProtoMember(48)]
		public int mpIncrRate{ get; set; }

		[ProtoMember(49)]
		public int hpIncrease{ get; set; }

		[ProtoMember(50)]
		public int mpIncrease{ get; set; }

		[ProtoMember(54)]
		public int pvpDmgInc{ get; set; }

		[ProtoMember(55)]
		public int pvpDmgDec{ get; set; }

		[ProtoMember(53)]
		public int combatPower{ get; set; }

		[ProtoMember(56)]
		public int phyDefDecay{ get; set; }

		[ProtoMember(57)]
		public int macDefDecay{ get; set; }

		[ProtoMember(58)]
		public int crtRateDecay{ get; set; }

		[ProtoMember(59)]
		public int crtDecay{ get; set; }

		[ProtoMember(60)]
		public int pveDmgInc{ get; set; }

		[ProtoMember(61)]
		public int pveDmgDec{ get; set; }


		internal UnitProperties()
		{
			this.str = 0;
			this.dex = 0;
			this.intl = 0;
			this.con = 0;
			this.propPoint = 0;
			this.jump = 0;
			this.walkSpeed = 0;
			this.mastery = 0;
			this.maxHp = 0;
			this.maxMp = 0;
			this.phyDef = 0;
			this.macDef = 0;
			this.phyAccRate = 0;
			this.macAccRate = 0;
			this.phyDodgeRate = 0;
			this.macDodgeRate = 0;
			this.poir = 0;
			this.firer = 0;
			this.icer = 0;
			this.thunder = 0;
			this.holyr = 0;
			this.darkr = 0;
			this.seal = 0;
			this.curse = 0;
			this.deceleration = 0;
			this.frozen = 0;
			this.stun = 0;
			this.root = 0;
			this.crtRate = 0;
			this.crtMinRate = 0;
			this.crtMaxRate = 0;
			this.itemRate = 0;
			this.moneyRate = 0;
			this.expRate = 0;
			this.healRate = 0;
			this.hateRate = 0;
			this.phyAtk = 0;
			this.macAtk = 0;
			this.maxHpRate = 0;
			this.maxMpRate = 0;
			this.phyDefRate = 0;
			this.macDefRate = 0;
			this.phyAtkRate = 0;
			this.macAtkRate = 0;
			this.hpIncrRate = 0;
			this.mpIncrRate = 0;
			this.hpIncrease = 0;
			this.mpIncrease = 0;
			this.pvpDmgInc = 0;
			this.pvpDmgDec = 0;
			this.combatPower = 0;
			this.phyDefDecay = 0;
			this.macDefDecay = 0;
			this.crtRateDecay = 0;
			this.crtDecay = 0;
			this.pveDmgInc = 0;
			this.pveDmgDec = 0;
		}

	}

}

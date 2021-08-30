using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ItemProp
	{

		[ProtoMember(1)]
		public int phyAtk{ get; set; }

		[ProtoMember(2)]
		public int macAtk{ get; set; }

		[ProtoMember(3)]
		public int phyDef{ get; set; }

		[ProtoMember(4)]
		public int macDef{ get; set; }

		[ProtoMember(5)]
		public int con{ get; set; }

		[ProtoMember(6)]
		public int str{ get; set; }

		[ProtoMember(7)]
		public int dex{ get; set; }

		[ProtoMember(8)]
		public int intl{ get; set; }

		[ProtoMember(9)]
		public int maxHp{ get; set; }

		[ProtoMember(10)]
		public int maxMp{ get; set; }

		[ProtoMember(11)]
		public int phyAccRate{ get; set; }

		[ProtoMember(12)]
		public int macAccRate{ get; set; }

		[ProtoMember(13)]
		public int phyDodgeRate{ get; set; }

		[ProtoMember(14)]
		public int macDodgeRate{ get; set; }

		[ProtoMember(15)]
		public int crtRate{ get; set; }

		[ProtoMember(16)]
		public int crtMinRate{ get; set; }

		[ProtoMember(17)]
		public int crtMaxRate{ get; set; }

		[ProtoMember(18)]
		public int speed{ get; set; }

		[ProtoMember(19)]
		public int moneyRate{ get; set; }

		[ProtoMember(20)]
		public int expRate{ get; set; }

		[ProtoMember(21)]
		public int itemRate{ get; set; }

		[ProtoMember(22)]
		public int refineLv{ get; set; }

		[ProtoMember(23)]
		public int rewardRate{ get; set; }

		[ProtoMember(24)]
		public int hpIncrRate{ get; set; }

		[ProtoMember(25)]
		public int mpIncrRate{ get; set; }

		[ProtoMember(26)]
		public int hpIncrease{ get; set; }

		[ProtoMember(27)]
		public int mpIncrease{ get; set; }

		[ProtoMember(28)]
		public int breaks{ get; set; }

		[ProtoMember(29)]
		public int poir{ get; set; }

		[ProtoMember(30)]
		public int thunder{ get; set; }

		[ProtoMember(31)]
		public int icer{ get; set; }

		[ProtoMember(32)]
		public int firer{ get; set; }

		[ProtoMember(33)]
		public int darkr{ get; set; }

		[ProtoMember(34)]
		public int holyr{ get; set; }

		[ProtoMember(35)]
		public int refineExp{ get; set; }


		internal ItemProp()
		{
			this.phyAtk = 0;
			this.macAtk = 0;
			this.phyDef = 0;
			this.macDef = 0;
			this.con = 0;
			this.str = 0;
			this.dex = 0;
			this.intl = 0;
			this.maxHp = 0;
			this.maxMp = 0;
			this.phyAccRate = 0;
			this.macAccRate = 0;
			this.phyDodgeRate = 0;
			this.macDodgeRate = 0;
			this.crtRate = 0;
			this.crtMinRate = 0;
			this.crtMaxRate = 0;
			this.speed = 0;
			this.moneyRate = 0;
			this.expRate = 0;
			this.itemRate = 0;
			this.refineLv = 0;
			this.rewardRate = 0;
			this.hpIncrRate = 0;
			this.mpIncrRate = 0;
			this.hpIncrease = 0;
			this.mpIncrease = 0;
			this.breaks = 0;
			this.poir = 0;
			this.thunder = 0;
			this.icer = 0;
			this.firer = 0;
			this.darkr = 0;
			this.holyr = 0;
			this.refineExp = 0;
		}

	}

}

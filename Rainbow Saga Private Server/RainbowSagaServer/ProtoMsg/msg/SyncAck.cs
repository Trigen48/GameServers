using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncAck
	{

		[ProtoMember(2)]
		public int unitType{ get; set; }

		[ProtoMember(3)]
		public int unitId{ get; set; }

		[ProtoMember(4)]
		public int eventType{ get; set; }

		[ProtoMember(11)]
		public Hurt hurt{ get; set; }

		[ProtoMember(12)]
		public Dead dead{ get; set; }

		[ProtoMember(13)]
		public Reborn reborn{ get; set; }

		[ProtoMember(14)]
		public Exp exp{ get; set; }

		[ProtoMember(15)]
		public LevelUp levelUp{ get; set; }

		[ProtoMember(18)]
		public MoveToward moveToward{ get; set; }

		[ProtoMember(19)]
		public SpecialState specialState{ get; set; }

		[ProtoMember(20)]
		public ThrowItem throwItem{ get; set; }

		[ProtoMember(24)]
		public Teleport teleport{ get; set; }

		[ProtoMember(26)]
		public Root root{ get; set; }

		[ProtoMember(28)]
		public Speed speed{ get; set; }

		[ProtoMember(30)]
		public ReliveFactor reliveFactor{ get; set; }

		[ProtoMember(31)]
		public PlayEffect playEffect{ get; set; }

		[ProtoMember(33)]
		public EnemySpotted enemySpotted{ get; set; }

		[ProtoMember(34)]
		public MobTalk mobTalk{ get; set; }

		[ProtoMember(35)]
		public Direction direction{ get; set; }


		internal SyncAck()
		{
			this.unitType = 0;
			this.unitId = 0;
			this.eventType = 0;
			this.hurt = new Hurt();
			this.dead = new Dead();
			this.reborn = new Reborn();
			this.exp = new Exp();
			this.levelUp = new LevelUp();
			this.moveToward = new MoveToward();
			this.specialState = new SpecialState();
			this.throwItem = new ThrowItem();
			this.teleport = new Teleport();
			this.root = new Root();
			this.speed = new Speed();
			this.reliveFactor = new ReliveFactor();
			this.playEffect = new PlayEffect();
			this.enemySpotted = new EnemySpotted();
			this.mobTalk = new MobTalk();
			this.direction = new Direction();
		}

	}

}

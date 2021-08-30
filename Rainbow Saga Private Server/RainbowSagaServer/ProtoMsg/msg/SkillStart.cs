using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SkillStart
	{

		[ProtoMember(1)]
		public int objType{ get; set; }

		[ProtoMember(2)]
		public int objId{ get; set; }

		[ProtoMember(3)]
		public int skillId{ get; set; }

		[ProtoMember(4)]
		public string action{ get; set; }

		[ProtoMember(5)]
		public int seqId{ get; set; }

		[ProtoMember(6)]
		public int flags{ get; set; }

		[ProtoMember(7)]
		public List<SyncEntity> targetEntities{ get; set; }

		[ProtoMember(9)]
		public int skillLv{ get; set; }

		[ProtoMember(10)]
		public int direction{ get; set; }

		[ProtoMember(11)]
		public int startX{ get; set; }

		[ProtoMember(12)]
		public int startY{ get; set; }

		[ProtoMember(13)]
		public int foothold{ get; set; }

		[ProtoMember(14)]
		public int stance{ get; set; }


		internal SkillStart()
		{
			this.objType = 0;
			this.objId = 0;
			this.skillId = 0;
			this.action ="";
			this.seqId = 0;
			this.flags = 0;
			this.targetEntities = new List<SyncEntity>();
			this.skillLv = 0;
			this.direction = 0;
			this.startX = 0;
			this.startY = 0;
			this.foothold = 0;
			this.stance = 0;
		}

	}

}

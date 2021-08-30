using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class NotifyDugeonScore
	{

		[ProtoMember(1)]
		public int dgninstanceid{ get; set; }

		[ProtoMember(2)]
		public int evaluation{ get; set; }

		[ProtoMember(3)]
		public int score{ get; set; }

		[ProtoMember(4)]
		public int killmobnumScore{ get; set; }

		[ProtoMember(5)]
		public int diecountScore{ get; set; }

		[ProtoMember(6)]
		public int checkpointuseScore{ get; set; }

		[ProtoMember(7)]
		public int totaltimeScore{ get; set; }

		[ProtoMember(8)]
		public int killbosstime{ get; set; }

		[ProtoMember(9)]
		public int killmobnum{ get; set; }

		[ProtoMember(10)]
		public int diecount{ get; set; }

		[ProtoMember(11)]
		public int checkpointuse{ get; set; }

		[ProtoMember(12)]
		public int totaltime{ get; set; }

		[ProtoMember(13)]
		public int success{ get; set; }

		[ProtoMember(14)]
		public int fixeditems{ get; set; }

		[ProtoMember(15)]
		public int exp{ get; set; }

		[ProtoMember(16)]
		public int havecard{ get; set; }

		[ProtoMember(17)]
		public int killmobnumWeight{ get; set; }

		[ProtoMember(18)]
		public int diecountWeight{ get; set; }

		[ProtoMember(19)]
		public int totaltimeWeight{ get; set; }

		[ProtoMember(20)]
		public int dgnclass{ get; set; }

		[ProtoMember(21)]
		public int notifytype{ get; set; }

		[ProtoMember(22)]
		public int failReason{ get; set; }


		internal NotifyDugeonScore()
		{
			this.dgninstanceid = 0;
			this.evaluation = 0;
			this.score = 0;
			this.killmobnumScore = 0;
			this.diecountScore = 0;
			this.checkpointuseScore = 0;
			this.totaltimeScore = 0;
			this.killbosstime = 0;
			this.killmobnum = 0;
			this.diecount = 0;
			this.checkpointuse = 0;
			this.totaltime = 0;
			this.success = 0;
			this.fixeditems = 0;
			this.exp = 0;
			this.havecard = 0;
			this.killmobnumWeight = 0;
			this.diecountWeight = 0;
			this.totaltimeWeight = 0;
			this.dgnclass = 0;
			this.notifytype = 0;
			this.failReason = 0;
		}

	}

}

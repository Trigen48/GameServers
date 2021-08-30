using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class DgnData
	{

		[ProtoMember(1)]
		public DgnInfo dgninfo{ get; set; }

		[ProtoMember(2)]
		public int tutorialDone{ get; set; }

		[ProtoMember(3)]
		public List<ProgressInfo> pginfos{ get; set; }

		[ProtoMember(4)]
		public List<DgnHistory> history{ get; set; }

		[ProtoMember(5)]
		public SaveEntry saveentry{ get; set; }

		[ProtoMember(6)]
		public List<DgnTicket> tickets{ get; set; }

		[ProtoMember(7)]
		public MultiDgnTimes multidgntimes{ get; set; }

		[ProtoMember(8)]
		public MopupInfo mopupinfo{ get; set; }

		[ProtoMember(9)]
		public int freeAccUsed{ get; set; }

		[ProtoMember(10)]
		public TowerProgressInfo towerinfo{ get; set; }

		[ProtoMember(11)]
		public int deadindgn{ get; set; }

		[ProtoMember(12)]
		public List<TimeLimitDgnInDB> timelimitDgn{ get; set; }

		[ProtoMember(13)]
		public List<DungeonAreaAwardStatus> areaAwardsStatus{ get; set; }

		[ProtoMember(14)]
		public List<DgnTowerPassAward> towerPassAward{ get; set; }

		[ProtoMember(15)]
		public MultiDgnTimes activitydgntimes{ get; set; }

		[ProtoMember(16)]
		public MultiGroupClash multiGroupClash{ get; set; }

		[ProtoMember(17)]
		public int manorBonusTotal{ get; set; }

		[ProtoMember(18)]
		public int manorBonusDaily{ get; set; }

		[ProtoMember(19)]
		public int manorBonusTime{ get; set; }

		[ProtoMember(20)]
		public List<DungeonAreaAwardStatus> areaGreenAwardsStatus{ get; set; }

		[ProtoMember(21)]
		public List<DungeonAreaAwardStatus> areaBlueAwardsStatus{ get; set; }

		[ProtoMember(22)]
		public List<DungeonAreaAwardStatus> areaPurpleAwardsStatus{ get; set; }

		[ProtoMember(23)]
		public MultiDgnTimes machinariumDgnTimes{ get; set; }


		internal DgnData()
		{
			this.dgninfo = new DgnInfo();
			this.tutorialDone = 0;
			this.pginfos = new List<ProgressInfo>();
			this.history = new List<DgnHistory>();
			this.saveentry = new SaveEntry();
			this.tickets = new List<DgnTicket>();
			this.multidgntimes = new MultiDgnTimes();
			this.mopupinfo = new MopupInfo();
			this.freeAccUsed = 0;
			this.towerinfo = new TowerProgressInfo();
			this.deadindgn = 0;
			this.timelimitDgn = new List<TimeLimitDgnInDB>();
			this.areaAwardsStatus = new List<DungeonAreaAwardStatus>();
			this.towerPassAward = new List<DgnTowerPassAward>();
			this.activitydgntimes = new MultiDgnTimes();
			this.multiGroupClash = new MultiGroupClash();
			this.manorBonusTotal = 0;
			this.manorBonusDaily = 0;
			this.manorBonusTime = 0;
			this.areaGreenAwardsStatus = new List<DungeonAreaAwardStatus>();
			this.areaBlueAwardsStatus = new List<DungeonAreaAwardStatus>();
			this.areaPurpleAwardsStatus = new List<DungeonAreaAwardStatus>();
			this.machinariumDgnTimes = new MultiDgnTimes();
		}

	}

}

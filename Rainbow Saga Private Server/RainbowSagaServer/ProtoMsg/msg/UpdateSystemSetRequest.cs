using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class UpdateSystemSetRequest
	{

		[ProtoMember(1)]
		public int mute{ get; set; }

		[ProtoMember(2)]
		public int display{ get; set; }

		[ProtoMember(5)]
		public VolumeSet volumeSet{ get; set; }

		[ProtoMember(6)]
		public PickUpSet pickUpSet{ get; set; }

		[ProtoMember(7)]
		public int displaySet{ get; set; }

		[ProtoMember(8)]
		public int skillEffect{ get; set; }

		[ProtoMember(9)]
		public int cameraShake{ get; set; }

		[ProtoMember(10)]
		public int remoteChallenge{ get; set; }

		[ProtoMember(11)]
		public int vechileDisplay{ get; set; }

		[ProtoMember(12)]
		public int autoRevive{ get; set; }

		[ProtoMember(13)]
		public int autoRetreat{ get; set; }

		[ProtoMember(14)]
		public int damageEffect{ get; set; }


		internal UpdateSystemSetRequest()
		{
			this.mute = 0;
			this.display = 0;
			this.volumeSet = new VolumeSet();
			this.pickUpSet = new PickUpSet();
			this.displaySet = 0;
			this.skillEffect = 0;
			this.cameraShake = 0;
			this.remoteChallenge = 0;
			this.vechileDisplay = 0;
			this.autoRevive = 0;
			this.autoRetreat = 0;
			this.damageEffect = 0;
		}

	}

}

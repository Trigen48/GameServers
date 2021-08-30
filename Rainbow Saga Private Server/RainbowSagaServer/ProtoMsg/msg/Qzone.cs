using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Qzone
	{

		[ProtoMember(2)]
		public int giftCount{ get; set; }

		[ProtoMember(3)]
		public List<Invitee> invitees{ get; set; }

		[ProtoMember(5)]
		public int shareIds{ get; set; }

		[ProtoMember(6)]
		public int dailyInvite{ get; set; }

		[ProtoMember(7)]
		public int clearFlag{ get; set; }


		internal Qzone()
		{
			this.giftCount = 0;
			this.invitees = new List<Invitee>();
			this.shareIds = 0;
			this.dailyInvite = 0;
			this.clearFlag = 0;
		}

	}

}

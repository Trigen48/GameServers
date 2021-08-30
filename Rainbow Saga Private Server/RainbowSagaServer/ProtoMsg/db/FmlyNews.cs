using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.msg;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class FmlyNews
	{

		[ProtoMember(1)]
		public SystemPrompt leaderRelated{ get; set; }

		[ProtoMember(2)]
		public SystemPrompt recommRelated{ get; set; }

		[ProtoMember(3)]
		public SystemPrompt upgradeRelated{ get; set; }

		[ProtoMember(4)]
		public SystemPrompt petRelated{ get; set; }

		[ProtoMember(5)]
		public SystemPrompt activityRelated{ get; set; }


		internal FmlyNews()
		{
			this.leaderRelated = new SystemPrompt();
			this.recommRelated = new SystemPrompt();
			this.upgradeRelated = new SystemPrompt();
			this.petRelated = new SystemPrompt();
			this.activityRelated = new SystemPrompt();
		}

	}

}

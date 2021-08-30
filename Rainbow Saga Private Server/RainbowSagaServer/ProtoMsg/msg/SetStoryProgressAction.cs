using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SetStoryProgressAction
	{

		[ProtoMember(1)]
		public int storyid{ get; set; }

		[ProtoMember(2)]
		public int actionid{ get; set; }

		[ProtoMember(3)]
		public int seqid{ get; set; }

		[ProtoMember(6)]
		public int remarkid1{ get; set; }

		[ProtoMember(7)]
		public int remarkid2{ get; set; }


		internal SetStoryProgressAction()
		{
			this.storyid = 0;
			this.actionid = 0;
			this.seqid = 0;
			this.remarkid1 = 0;
			this.remarkid2 = 0;
		}

	}

}

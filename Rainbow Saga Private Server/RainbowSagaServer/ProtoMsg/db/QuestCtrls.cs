using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class QuestCtrls
	{

		[ProtoMember(1)]
		public int wantedturnedintimes{ get; set; }

		[ProtoMember(2)]
		public int wantedfreerefreshtimes{ get; set; }

		[ProtoMember(3)]
		public int wantedlastrefreshtime{ get; set; }


		internal QuestCtrls()
		{
			this.wantedturnedintimes = 0;
			this.wantedfreerefreshtimes = 0;
			this.wantedlastrefreshtime = 0;
		}

	}

}

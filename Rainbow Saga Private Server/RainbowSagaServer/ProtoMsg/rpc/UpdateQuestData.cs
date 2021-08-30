using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
using  RainbowServer.proto.db;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class UpdateQuestData
	{

		[ProtoMember(1)]
		public QuestRecord q{ get; set; }

		[ProtoMember(2)]
		public int t{ get; set; }

		[ProtoMember(3)]
		public int i{ get; set; }

		[ProtoMember(4)]
		public int id{ get; set; }


		internal UpdateQuestData()
		{
			this.q = new QuestRecord();
			this.t = 0;
			this.i = 0;
			this.id = 0;
		}

	}

}

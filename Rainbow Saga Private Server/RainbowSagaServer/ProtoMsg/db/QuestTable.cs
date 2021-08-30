using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class QuestTable
	{

		[ProtoMember(1)]
		public List<QuestRecord> records{ get; set; }


		internal QuestTable()
		{
			this.records = new List<QuestRecord>();
		}

	}

}

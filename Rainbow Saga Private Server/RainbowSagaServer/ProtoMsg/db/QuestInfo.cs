using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class QuestInfo
	{

		[ProtoMember(1)]
		public QuestCtrls ctrls{ get; set; }

		[ProtoMember(2)]
		public List<QuestTable> tables{ get; set; }


		internal QuestInfo()
		{
			this.ctrls = new QuestCtrls();
			this.tables = new List<QuestTable>();
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class QuestList
	{

		[ProtoMember(1)]
		public List<Quest> quests{ get; set; }


		internal QuestList()
		{
			this.quests = new List<Quest>();
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorModifyTextReq
	{

		[ProtoMember(1)]
		public string text{ get; set; }

		[ProtoMember(2)]
		public int type{ get; set; }


		internal MentorModifyTextReq()
		{
			this.text ="";
			this.type = 0;
		}

	}

}

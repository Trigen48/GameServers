using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class MentorMainInfoSync
	{

		[ProtoMember(1)]
		public MentorMainInfo info{ get; set; }


		internal MentorMainInfoSync()
		{
			this.info = new MentorMainInfo();
		}

	}

}

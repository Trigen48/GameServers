using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SetStoryProgress
	{

		[ProtoMember(1)]
		public int storyid{ get; set; }


		internal SetStoryProgress()
		{
			this.storyid = 0;
		}

	}

}

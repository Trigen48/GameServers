using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class ShareStory
	{

		[ProtoMember(1, IsRequired=true)]
		public int storyId{ get; set; }


		internal ShareStory()
		{
			this.storyId = 0;
		}

	}

}

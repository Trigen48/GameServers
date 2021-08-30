using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class HideStoryObject
	{

		[ProtoMember(1)]
		public string key{ get; set; }


		internal HideStoryObject()
		{
			this.key ="";
		}

	}

}

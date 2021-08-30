using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ChangeSceneRequest
	{

		[ProtoMember(3)]
		public string portal{ get; set; }


		internal ChangeSceneRequest()
		{
			this.portal ="";
		}

	}

}

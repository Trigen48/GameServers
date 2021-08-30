using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class ReplicaInform
	{

		[ProtoMember(1)]
		public int sceneId{ get; set; }

		[ProtoMember(2)]
		public ReplicaSet appear{ get; set; }

		[ProtoMember(3)]
		public ReplicaSet disappear{ get; set; }


		internal ReplicaInform()
		{
			this.sceneId = 0;
			this.appear = new ReplicaSet();
			this.disappear = new ReplicaSet();
		}

	}

}

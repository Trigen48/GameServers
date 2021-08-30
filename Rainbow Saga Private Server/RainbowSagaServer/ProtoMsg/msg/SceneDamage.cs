using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SceneDamage
	{

		[ProtoMember(3)]
		public int objType{ get; set; }

		[ProtoMember(4)]
		public int objId{ get; set; }

		[ProtoMember(6)]
		public int type{ get; set; }

		[ProtoMember(7)]
		public int amount{ get; set; }


		internal SceneDamage()
		{
			this.objType = 0;
			this.objId = 0;
			this.type = 0;
			this.amount = 0;
		}

	}

}

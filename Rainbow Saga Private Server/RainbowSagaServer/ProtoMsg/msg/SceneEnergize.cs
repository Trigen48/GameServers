using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SceneEnergize
	{

		[ProtoMember(1)]
		public int objType{ get; set; }

		[ProtoMember(2)]
		public int objId{ get; set; }

		[ProtoMember(3)]
		public int addHp{ get; set; }

		[ProtoMember(4)]
		public int addMp{ get; set; }


		internal SceneEnergize()
		{
			this.objType = 0;
			this.objId = 0;
			this.addHp = 0;
			this.addMp = 0;
		}

	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class MountDgnInfo
	{

		[ProtoMember(1)]
		public List<MountDgnData> mountDgnData{ get; set; }


		internal MountDgnInfo()
		{
			this.mountDgnData = new List<MountDgnData>();
		}

	}

}

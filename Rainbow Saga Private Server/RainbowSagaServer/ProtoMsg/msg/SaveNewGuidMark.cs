using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SaveNewGuidMark
	{

		[ProtoMember(1)]
		public int markId{ get; set; }


		internal SaveNewGuidMark()
		{
			this.markId = 0;
		}

	}

}

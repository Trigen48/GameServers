using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class ActivityInfo
	{

		[ProtoMember(1)]
		public List<ActivityData> activities{ get; set; }


		internal ActivityInfo()
		{
			this.activities = new List<ActivityData>();
		}

	}

}

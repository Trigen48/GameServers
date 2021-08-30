using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class AstrologyBagData
	{

		[ProtoMember(1)]
		public int starList{ get; set; }


		internal AstrologyBagData()
		{
			this.starList = 0;
		}

	}

}

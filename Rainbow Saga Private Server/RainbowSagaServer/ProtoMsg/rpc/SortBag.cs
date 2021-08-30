using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class SortBag
	{

		[ProtoMember(1)]
		public int packageId{ get; set; }


		internal SortBag()
		{
			this.packageId = 0;
		}

	}

}

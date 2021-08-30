using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.rpc
{

	[ProtoContract]
	internal class IsNewMysticStoreFreeRefresh
	{

		[ProtoMember(1)]
		public int tabnumber{ get; set; }


		internal IsNewMysticStoreFreeRefresh()
		{
			this.tabnumber = 0;
		}

	}

}

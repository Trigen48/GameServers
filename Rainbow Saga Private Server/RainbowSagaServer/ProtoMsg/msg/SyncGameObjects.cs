using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class SyncGameObjects
	{

		[ProtoMember(1)]
		public List<GameObject> objects{ get; set; }


		internal SyncGameObjects()
		{
			this.objects = new List<GameObject>();
		}

	}

}

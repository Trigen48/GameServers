using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.db
{

	[ProtoContract]
	internal class Attachments
	{

		[ProtoMember(1)]
		public List<Attachment> infos{ get; set; }


		internal Attachments()
		{
			this.infos = new List<Attachment>();
		}

	}

}

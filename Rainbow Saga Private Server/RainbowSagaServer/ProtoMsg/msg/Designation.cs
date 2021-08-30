using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class Designation
	{

		[ProtoMember(1)]
		public List<DesignationInfo> infos{ get; set; }


		internal Designation()
		{
			this.infos = new List<DesignationInfo>();
		}

	}

}

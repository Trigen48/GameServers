using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace RainbowServer.proto.msg
{

	[ProtoContract]
	internal class TencentVipInfo
	{

		[ProtoMember(1)]
		public List<TencentVIP> vips{ get; set; }


		internal TencentVipInfo()
		{
			this.vips = new List<TencentVIP>();
		}

	}

}

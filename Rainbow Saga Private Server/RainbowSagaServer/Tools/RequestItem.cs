using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainbowServer
{
    public struct RequestItem
    {
        public uint MsgType;
        public uint MsgID;
        public uint Length;
        public uint SessionID;

        public byte[] data;

        public RequestItem(uint msgid,byte[] d)
        {
            MsgType = 0;
            MsgID = msgid;
            SessionID = 0;
            data = d;
            Length = (uint)d.Length;
        }
    }
}

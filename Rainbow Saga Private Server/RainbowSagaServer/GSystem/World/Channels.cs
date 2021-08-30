using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainbowServer.proto.msg;
namespace RainbowServer
{
    internal struct ChannelItem
    {
    }

    internal static class Zones
    {
        internal static List<ZoneInfo> zones;
        internal const string ZoneFile = "system\\zones.info";
        internal static void Init()
        {
            zones = new List<ZoneInfo>();
            config.ConfigLoader ld = new config.ConfigLoader();

            if (System.IO.File.Exists(ZoneFile))
            {
                ld.Load(ZoneFile);

                int channelCount = 0;

                ld.GetInt(ref channelCount, "zone-count");
                string data = "";
                string[] sp = null;

                for (int x = 0; x < channelCount; x++)
                {
                    ld.GetString(ref data, "zone-" + x.ToString());

                    data = data.Trim();

                    if (data != "")
                    {
                        sp = data.Split(new char[] {'#'});

                        
                        ZoneInfo z = new ZoneInfo();

                        z.id = (uint)x;
                        z.maxNum = uint.Parse(sp[0]);
                        z.name = sp[1];
                        zones.Add(z);
                    }

                }


                ld.Close();
                ld = null;
            }
          
        }
    }
}

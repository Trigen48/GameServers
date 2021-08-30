using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameServer
{
    /*
    200020:{
            "id":200020,
            "state":1,
            "crownType":1,
            "crownName":Language.getLan(10000926),
            "crownContent":Language.getLan(10000927),
            "attribute":Language.getLan(10000928)
         },
    */

    public class AchievementCrown
    {
        public int id;
        public int crownType;
        public int crownName;
        public int crownContent;
        public int attribute;
    }

    public static class Achievement
    {
        public static Dictionary<int, AchievementCrown> crown;
        public static void init()
        {
            crown = JsonLib.LoadFile<Dictionary<int, AchievementCrown>>("system/achievement_crown.json");
        }

    }
}

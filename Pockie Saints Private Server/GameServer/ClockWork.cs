using System;
using System.Collections.Generic;
using System.Text;

namespace GameServer
{
    public static class ClockWork
    {

        public static int AddMinutes(int time, int value)
        {
            return time + (value * 60);
        }

        public static int AddTime(int time,int hours,int minutes,int seconds)
        {
            return time +(hours * 3600) + (minutes * 60)+seconds;
        }

        public static int AddSeconds(int time, int value)
        {
            return time + value;
        }

        public static int AddHours(int time, int value)
        {
            return time + (value * 3600);
        }


    }
}

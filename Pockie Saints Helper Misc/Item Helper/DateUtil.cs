using System;
using System.Collections.Generic;
using System.Text;

namespace Item_Helper
{
    internal static class DateUtil
    {

       // const DateTime orig = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        public static double GetDateInt(DateTime date)
        {
           // DateTime date = DateTime.Now;
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static double GetDateInt()
        {
            DateTime date = DateTime.Now;
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static double GetYearsInt(int h)
        {
            DateTime date = DateTime.Now.AddDays(h);
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static double GetHoursInt(int h)
        {
            DateTime date = DateTime.Now.AddHours(h);
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static double GetDaysInt(int h)
        {
            DateTime date = DateTime.Now.AddDays(h);
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static double GetMinutesInt(int h)
        {
            DateTime date = DateTime.Now.AddMinutes(h);
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static double GetMonthsInt(int h)
        {
            DateTime date = DateTime.Now.AddMonths(h);
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);
        }

        public static double GetTodayInt(int h, int m, int sec)
        {
            DateTime date = DateTime.Now;
            //date.TimeOfDay = new TimeSpan(h, m, sec);
            date = new DateTime(date.Year,date.Month, date.Day, h, m, sec);
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);

        }

        public static double GetTommorowInt(int h, int m, int sec)
        {
            DateTime date = DateTime.Now.AddDays(1);
            //date.TimeOfDay = new TimeSpan(h, m, sec);
            date = new DateTime(date.Year, date.Month, date.Day, h, m, sec);
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            TimeSpan diff = date.ToUniversalTime() - origin;
            return Math.Floor(diff.TotalSeconds);

        }

        public static DateTime GetDateFromInt(int value)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            long v = (long)((long)value * (long)10000000);
            TimeSpan diff = new TimeSpan(v);
            DateTime date = origin.Add(diff);
            return date;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    public static class DateUtil
    {
        public static DateTime org = new DateTime(1970, 1, 1, 0, 0, 0, 0);
        public static short Zone=2;
        public static int ZoneDeduct;

        public static void init()
        {
            ZoneDeduct = Zone * 3600;
        }

        public static double GetDateInt(DateTime date)
        {
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetDateInt()
        {
            Double secs = DateTime.UtcNow.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetYearsInt(int h)
        {
            DateTime date = DateTime.UtcNow.AddYears(h);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetHoursInt(int h)
        {
            DateTime date = DateTime.UtcNow.AddHours(h);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetDaysInt(int h)
        {
            DateTime date = DateTime.UtcNow.AddDays(h);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetMinutesInt(int h)
        {
            DateTime date = DateTime.UtcNow.AddMinutes(h);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetMonthsInt(int h)
        {
            DateTime date = DateTime.UtcNow.AddMonths(h);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetTodayInt(int h, int m, int sec)
        {
            DateTime date = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, h, m, sec);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetTommorowInt(int h, int m, int sec)
        {
            DateTime date = DateTime.UtcNow.AddDays(1);
            date = new DateTime(date.Year, date.Month, date.Day, h, m, sec);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetNextDays(int d, int h, int m, int s)
        {
            DateTime date = DateTime.UtcNow.AddDays(d);
            date = new DateTime(date.Year, date.Month, date.Day, h, m, s);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static DateTime GetDateFromInt(int value)
        {
            DateTime origin = org;
            long v = (long)((long)value * (long)10000000);
            TimeSpan diff = new TimeSpan(v);
            DateTime date = origin.Add(diff);
            return date;
        }


        public static double GetDateIntZone(DateTime date)
        {
            date = date.AddHours(Zone);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetDateIntZone()
        {
            DateTime d=DateTime.UtcNow.AddHours(Zone);

            Double secs = d.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetYearsIntZone(int h)
        {
            DateTime date = DateTime.UtcNow.AddHours(Zone).AddYears(h);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetHoursIntZone(int h)
        {
            DateTime date = DateTime.UtcNow.AddHours(Zone).AddHours(h);

            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetDaysIntZone(int h)
        {
            DateTime date = DateTime.UtcNow.AddHours(Zone).AddDays(h);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetMinutesIntZone(int h)
        {
            DateTime date = DateTime.UtcNow.AddHours(Zone).AddMinutes(h);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetMonthsIntZone(int h)
        {
            DateTime date = DateTime.UtcNow.AddHours(Zone).AddMonths(h);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetTodayIntZone(int h, int m, int sec)
        {
            DateTime date = (new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, h, m, sec)).AddHours(Zone);
             //date = date.AddHours(Zone);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetTommorowIntZone(int h, int m, int sec)
        {
            DateTime date = DateTime.UtcNow.AddHours(Zone).AddDays(1);
            date = new DateTime(date.Year, date.Month, date.Day, h, m, sec);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static double GetNextDaysZone(int d, int h, int m, int s)
        {
            DateTime date = DateTime.UtcNow.AddHours(Zone).AddDays(d);

            date = new DateTime(date.Year, date.Month, date.Day, h, m, s);
            Double secs = date.Subtract(org).TotalSeconds;
            return Math.Floor(secs);
        }

        public static DateTime GetDateFromIntZone(int value)
        {
            DateTime origin = org;
            long v = (long)((long)value * (long)10000000);
            TimeSpan diff = new TimeSpan(v);
            DateTime date = origin.Add(diff);
            return date;
        }
        public static DateTime GetDate()
        {
            return DateTime.UtcNow; 
        }
        public static DateTime GetZoneDate()
        {
            return DateTime.UtcNow.AddHours(Zone);
        }
    }
}

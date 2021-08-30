
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connector
{
    public class TypeUtil
    {
        public static string GetParam(string Name, object Value)
        {
            return GetParam(Name, Value, false);
        }
        public static string GetParam(string Name, object Value, bool ignore)
        {
            return Name + "=" + GetType(Value, ignore);
        }

        public static string GetType(object Value)
        {
            return GetType(Value, false);
        }
        public static string GetType(object Value, bool ignore)
        {

            Type t = Value.GetType();
            string pushValue = "";
            if (ignore)
            {
                pushValue = Value.ToString();
            }
            else if (t == typeof(string) || t == typeof(char))
            {
                string v = Value.ToString();

                // Make sure we replace single quotes with single inverted quotes
                if (v.Contains("'"))
                {
                    v = v.Replace("'", "`");
                }

                pushValue = "'" + v + "'";
            }
            else if (t == typeof(DateTime))
            {
                pushValue = "'" + ((DateTime)Value).ToString("yyyy/MM/dd hh:mm:ss") + "'";
            }
            else if (t == typeof(TimeSpan))
            {
                pushValue = "'" + ((TimeSpan)Value).ToString("hh:mm:ss") + "'";
            }
            else if (t == typeof(bool) || t == typeof(Boolean))
            {
                pushValue = "'" + Value.ToString() + "'";
            }
            else if (typeof(byte[]) == t)
            {
                pushValue = ByteToString((byte[])Value);
            }
            else
            {
                pushValue = Value.ToString();
            }
            return pushValue;
        }

        private static string ByteToString(byte[] value)
        {
            if (value == null)
            {
                return "NULL";
            }
            return "0x" + BitConverter.ToString(value).Replace("-", "");
        }
    }
}

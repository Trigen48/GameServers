using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Connector;
namespace GameServer
{
    [AttributeUsage(AttributeTargets.Property, Inherited=true,AllowMultiple=true)]
    public class ContentProto : Attribute
    {
        public string name { get; set; }
        public bool readOnly { get; set; }
        public ContentProto(string value)
        {
            name = value;
            readOnly = false;
        }

        public ContentProto(string value, bool readOnly)
        {
            name = value;
            this.readOnly = readOnly;
        }
    }


    public class ContentResolver
    {
        public static bool DoDeserialize<T>(object o,Connector.MySqlConnector connector)
        {
            DataReader rd = connector.ExecuteRead();
            if (rd.CanRead && rd.NextRow())
            {

                PropertyInfo[] properties = typeof(T).GetProperties();

                foreach (PropertyInfo prop in properties)
                {
                    object[] obs=prop.GetCustomAttributes(typeof(ContentProto),false);
               

                    if (obs != null && obs.Length > 0)
                    {
                        object val = rd.GetValue(((ContentProto)obs[0]).name);

                        if (val != DBNull.Value && val!=null)
                        {
                            prop.SetValue(o, Converted(val, prop.PropertyType), null);
                        }

                    }
                }
                rd.Close();
                return true;

            }
            rd.Close();
            return false;
        }
        public static bool DoDeserializeCollection<T>(ICollection<T> o, MySqlConnector connector)
        {
            DataReader rd = connector.ExecuteRead();
            if (rd.CanRead)
            {

                while (rd.NextRow())
                {

                    T vl = ((T)Activator.CreateInstance(typeof(T)));
                    PropertyInfo[] properties = vl.GetType().GetProperties();

                    foreach (PropertyInfo prop in properties)
                    {
                        object[] obs = prop.GetCustomAttributes(typeof(ContentProto), false);

                        if (obs != null && obs.Length > 0)
                        {
                            object val = rd.GetValue(((ContentProto)obs[0]).name);

                            if (val != DBNull.Value && val != null)
                            {
                                prop.SetValue(o, Converted(val, prop.PropertyType), null);
                            }

                        }
                    }

                    o.Add(vl);
                }
                rd.Close();
                return true;

            }
            rd.Close();
            return false;
        }

        public static bool DoDeserializeLoop<T>(object o, DataReader rd)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                object[] obs = prop.GetCustomAttributes(typeof(ContentProto), false);


                if (obs != null && obs.Length > 0)
                {
                    object val = rd.GetValue(((ContentProto)obs[0]).name);

                    if (val != DBNull.Value && val != null)
                    {
                        prop.SetValue(o, Converted(val, prop.PropertyType), null);
                    }

                }
            }

            return true;
        }

        public static string DoSerializeUpdate<T>(object o)
        {

            string value = "";
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                object[] obs = prop.GetCustomAttributes(typeof(ContentProto), false);


                if (obs != null && obs.Length > 0 && !((ContentProto)obs[0]).readOnly)
                {
                    string name = ((ContentProto)obs[0]).name;
                    value += Connector.TypeUtil.GetParam(name, prop.GetValue(o, null))+",";
                }
            }

            //System.IO.File.AppendAllText("sql.log", value + "\n\n");

            return value.Length!=0 ? value.Remove(value.Length-1):value;
        }

        public static string[] DoSerializeInsert<T>(object o)
        {

            string[] value = new string[2];
            PropertyInfo[] properties = typeof(T).GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                object[] obs = prop.GetCustomAttributes(typeof(ContentProto), false);


                if (obs != null && obs.Length > 0)
                {
                    string name = ((ContentProto)obs[0]).name;
                    value[0] += name + ",";

                    value[1] += Connector.TypeUtil.GetType(prop.GetValue(o, null)) + ",";
                }
            }

            //System.IO.File.AppendAllText("sql.log", value + "\n\n");
            value[0] = value[0].Length != 0 ? value[0].Remove(value[0].Length - 1) : value[0];

            value[1] = value[1].Length != 0 ? value[1].Remove(value[1].Length - 1) : value[1]; 
            return value;
        }

        private static object Converted(object o, Type t)
        {
           if(t == typeof(int))
           {
               return Convert.ToInt32(o);
           }
           else if(t== typeof(uint))
           {
      
               return Convert.ToUInt32(o);
           }
           else if (t == typeof(sbyte))
           {
               return Convert.ToSByte(o);
           }
           else if (t == typeof(byte))
           {
               return Convert.ToByte(o);
           }
           else if (t == typeof(long))
           {
               return Convert.ToInt64(o);
           }
           else if (t == typeof(ulong))
           {
               return Convert.ToUInt64(o);
           }
           else if (t == typeof(short))
           {

               return Convert.ToInt16(o);
           }
           else if (t == typeof(ushort))
           {

               return Convert.ToUInt16(o);
           }
           else if (t == typeof(bool))
           {
               return Convert.ToBoolean(o);
           }

            return o;
        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace config
{
    public class HeaderConfig
    {

        Dictionary<string, Dictionary<string, string>> ConfigData;

        public HeaderConfig()
        {
            ConfigData = new Dictionary<string, Dictionary<string, string>>();
        }

        public HeaderConfig(string File)
        {
            ConfigData = new Dictionary<string, Dictionary<string, string>>();
            _Load(File);
        }

        public HeaderConfig(string[] Props)
        {
            ConfigData = new Dictionary<string, Dictionary<string, string>>();
            _Load(Props);
        }

        public void Load(string File)
        {
            _Load(File);
        }

        public void Load(string[] Props)
        {
            _Load(Props);
        }

        private void _Load(string file)
        {
            ConfigData.Clear();

            if (System.IO.File.Exists(file))
            {
                try
                {
                    string[] ops = System.IO.File.ReadAllLines(file);
                    Parse(ops);
                }
                catch
                {

                }
            }
        }

        private void _Load(string[] data)
        {
            Parse(data);
        }

        private void Parse(string[] data)
        {
            try
            {
                string key, value;
                string propp;
                string DefaultName = "";

                ConfigData.Add("", new Dictionary<string, string>());

                foreach (string prop in data)
                {

                    propp = prop.Trim();

                    if (propp.StartsWith("/") || propp.Replace(" ", "") == "")
                    {
                        continue;
                    }

                    if (propp.StartsWith("[") && propp.EndsWith("]"))
                    {
                        DefaultName = ((propp.Remove(0, 1).Remove(prop.Length - 2)).ToLower()).Trim();

                        if (!ConfigData.ContainsKey(DefaultName))
                        {
                            ConfigData.Add(DefaultName, new Dictionary<string, string>());
                        }
                        continue;
                    }

                    int index = propp.IndexOf(':');

                    if (index < 1 || index + 1 >= propp.Length) continue;

                    key = propp.Substring(0, index);
                    value = propp.Substring(index + 1);

                    ConfigData[DefaultName].Add(key.Trim().ToLower(), value.Trim());
                }
            }
            catch
            {
            }
        }

        public void GetInt(ref int value, string property)
        {
            GetInt(ref value, property, "");
        }

        public void GetString(ref string value, string property)
        {
            GetString(ref value, property, "");
        }

        public void GetTime(ref byte[] value, string property)
        {
            GetTime(ref value, property, "");
        }

        public void GetBool(ref bool value, string property)
        {
            GetBool(ref value, property, "");
        }

        public void GetTimes(ref byte[][] value, string property)
        {
            GetTimes(ref value, property, "");
        }

        public void GetShort(ref short value, string property)
        {
            GetShort(ref value, property, "");
        }

        public void GetByte(ref byte value, string property)
        {
            GetByte(ref value, property, "");

        }

        public void GetDate(ref DateTime value, string property)
        {
            GetDate(ref value, property, "");
        }

        public void GetDateTime(ref DateTime value, string property)
        {
            GetDateTime(ref value, property, "");

        }

        public void GetFloat(ref float value, string property)
        {
            GetFloat(ref value, property, "");

        }

        public void GetDouble(ref double value, string property)
        {
            GetDouble(ref value, property, "");

        }

        public bool PropertyExists(string property)
        {
            return PropertyExists("",property);
        }

        public Dictionary<string, int> ToIntDictionary()
        {
            return ToIntDictionary("");
        }

        public Dictionary<string, byte> ToByteDictionary()
        {

            return ToByteDictionary("");
        }

        public Dictionary<string, short> ToShortDictionary()
        {
            return ToShortDictionary("");
        }

        public Dictionary<string, string> ToStringDictionary()
        {
            return ToStringDictionary("");
        }

        public Dictionary<string, bool> ToBoolDictionary()
        {
            return ToBoolDictionary("");
        }

        public Dictionary<string, float> ToFloatDictionary()
        {
            return ToFloatDictionary("");
        }

        public Dictionary<string, double> ToDoubleDictionary()
        {
            return ToDoubleDictionary("");
        }

        // Namespace
        public void GetInt(ref int value, string property, String DefaultName)
        {
            try
            {
               
                if (!PropertyExists(property, DefaultName)) return;

                value = int.Parse(ConfigData[DefaultName][property]);
            }
            catch
            {

            }
        }

        public void GetString(ref string value, string property, String DefaultName)
        {
            try
            {
                if (!PropertyExists(property, DefaultName)) return;

                value = ConfigData[DefaultName][property];
            }
            catch
            {

            }
        }

        public void GetTime(ref byte[] value, string property, String DefaultName)
        {

            try
            {
                if (!PropertyExists(property, DefaultName)) return;
                string[] time = ConfigData[DefaultName][property].Replace(" ", "").Split("-".ToCharArray());
                byte[] ex = new byte[3];
                ex[0] = byte.Parse(time[0]);
                ex[1] = byte.Parse(time[1]);
                ex[2] = byte.Parse(time[2]);
                value = (byte[])ex.Clone();
                ex = null;
            }
            catch
            {

            }
        }

        public void GetBool(ref bool value, string property, String DefaultName)
        {
            try
            {

                if (!PropertyExists(property, DefaultName)) return;

                string tmp = ConfigData[DefaultName][property].Trim().ToLower();

                switch (tmp)
                {
                    case "on":
                        value = true;
                        return;

                    case "off":
                        value = false;
                        return;

                    case "true":
                        value = true;
                        return;

                    case "false":
                        value = false;
                        return;

                }
            }
            catch
            {
            }
        }



        public void GetTimes(ref byte[][] value, string property, String DefaultName)
        {
            try
            {
                if (!PropertyExists(property, DefaultName)) return;
                string[] timez = ConfigData[DefaultName][property].Replace(" ", "").Split(",".ToCharArray());


                string[] time;
                byte[][] clones = new byte[timez.Length][];
                int inx = 0;
                byte[] ex = new byte[3];

                foreach (string t in timez)
                {
                    time = t.Split("-".ToCharArray());

                    ex[0] = byte.Parse(time[0]);
                    ex[1] = byte.Parse(time[1]);
                    ex[2] = byte.Parse(time[2]);

                    clones[inx] = (byte[])ex.Clone();
                    inx++;
                }

                value = (byte[][])clones.Clone();

                clones = null;
                ex = null;
            }
            catch
            {

            }
        }

        public void GetShort(ref short value, string property, String DefaultName)
        {
            try
            {
                if (!PropertyExists(property, DefaultName)) return;

                value = short.Parse(ConfigData[DefaultName][property]);
            }
            catch
            {
            }

        }

        public void GetByte(ref byte value, string property, String DefaultName)
        {
            try
            {
                if (!PropertyExists(property, DefaultName)) return;

                value = byte.Parse(ConfigData[DefaultName][property]);
            }
            catch
            {
            }
        }

        public void GetDate(ref DateTime value, string property, String DefaultName)
        {
            try
            {
                if (!PropertyExists(property, DefaultName)) return;
                string[] timez = ConfigData[DefaultName][property].Replace(" ", "").Split("-&".ToCharArray());

                int[] ex = new int[6];

                ex[0] = int.Parse(timez[0]);
                ex[1] = int.Parse(timez[1]);
                ex[2] = int.Parse(timez[2]);

                if (ex.Length == 6)
                {

                }
                value = new DateTime(ex[0], ex[1], ex[2], ex[3], ex[4], ex[5]);

            }
            catch
            {

            }
        }

        public void GetDateTime(ref DateTime value, string property, String DefaultName)
        {
            try
            {
                if (!PropertyExists(property, DefaultName)) return;
                string[] timez = ConfigData[DefaultName][property].Replace(" ", "").Split(",".ToCharArray());

                int[] ex = new int[3];

                ex[0] = int.Parse(timez[0]);
                ex[1] = int.Parse(timez[1]);
                ex[2] = int.Parse(timez[2]);

                ex[3] = int.Parse(timez[3]);
                ex[4] = int.Parse(timez[4]);
                ex[5] = int.Parse(timez[5]);

                value = new DateTime(ex[2], ex[1], ex[0], ex[3], ex[4], ex[5]);

            }
            catch
            {

            }
        }

        public void GetFloat(ref float value, string property, String DefaultName)
        {
            try
            {
                if (!PropertyExists(property, DefaultName)) return;

                value = float.Parse(ConfigData[DefaultName][property]);
            }
            catch
            {

            }
        }

        public void GetDouble(ref double value, string property, String DefaultName)
        {
            try
            {
                if (!PropertyExists(property, DefaultName)) return;

                value = double.Parse(ConfigData[DefaultName][property]);
            }
            catch
            {

            }
        }

        public bool PropertyExists(string property, String DefaultName)
        {
            return ConfigData.ContainsKey(DefaultName) && ConfigData[DefaultName].ContainsKey(property);
        }

        public Dictionary<string, int> ToIntDictionary(String DefaultName)
        {

            Dictionary<string, int> tmp = new Dictionary<string, int>();


            foreach (string key in ConfigData.Keys)
            {
                int val = 0;

                try
                {
                    val = int.Parse(ConfigData[DefaultName][key].Replace(" ", ""));
                }
                catch
                {
                }

                tmp.Add(key, val);
            }


            return tmp;
        }

        public Dictionary<string, byte> ToByteDictionary(String DefaultName)
        {

            Dictionary<string, byte> tmp = new Dictionary<string, byte>();


            foreach (string key in ConfigData.Keys)
            {
                byte val = 0;

                try
                {
                    val = byte.Parse(ConfigData[DefaultName][key].Replace(" ", ""));
                }
                catch
                {
                }

                tmp.Add(key, val);
            }


            return tmp;
        }

        public Dictionary<string, short> ToShortDictionary(String DefaultName)
        {

            Dictionary<string, short> tmp = new Dictionary<string, short>();


            foreach (string key in ConfigData.Keys)
            {
                short val = 0;

                try
                {
                    val = short.Parse(ConfigData[DefaultName][key].Replace(" ", ""));
                }
                catch
                {
                }

                tmp.Add(key, val);
            }


            return tmp;
        }

        public Dictionary<string, string> ToStringDictionary(String DefaultName)
        {
            Dictionary<string, string> tmp = new Dictionary<string, string>();
            foreach (string key in ConfigData.Keys)
            {
                tmp.Add(key, ConfigData[DefaultName][key].Trim());//.Replace(" ", "");
            }


            return tmp;
        }

        public Dictionary<string, bool> ToBoolDictionary(String DefaultName)
        {

            Dictionary<string, bool> tmp = new Dictionary<string, bool>();

            foreach (string key in ConfigData.Keys)
            {
                bool val = false;

                string tmpt = ConfigData[DefaultName][key].Trim().ToLower();

                switch (tmpt)
                {
                    case "on":
                        val = true;
                        break;

                    case "off":
                        val = false;
                        break;

                    case "true":
                        val = true;
                        break;

                    case "false":
                        val = false;
                        break;

                }


                tmp.Add(key, val);
            }


            return tmp;
        }

        public Dictionary<string, float> ToFloatDictionary(String DefaultName)
        {

            Dictionary<string, float> tmp = new Dictionary<string, float>();


            foreach (string key in ConfigData.Keys)
            {
                float val = 0;

                try
                {
                    val = float.Parse(ConfigData[DefaultName][key].Replace(" ", ""));
                }
                catch
                {
                }

                tmp.Add(key, val);
            }


            return tmp;
        }

        public Dictionary<string, double> ToDoubleDictionary(String DefaultName)
        {

            Dictionary<string, double> tmp = new Dictionary<string, double>();


            foreach (string key in ConfigData.Keys)
            {
                double val = 0;

                try
                {
                    val = double.Parse(ConfigData[DefaultName][key].Replace(" ", ""));
                }
                catch
                {
                }

                tmp.Add(key, val);
            }


            return tmp;
        }

        public void SetValue(object value, string property)
        {
            SetValue(value, property, "");
        }

        public void SetValue(object value, string property, string DefaultName)
        {
            string sv = "";

            string prop = property.ToLower().Trim();
            string def = DefaultName.ToLower().Trim();

            if (value != null)
            {
                return;
            }

            if (value is byte[])
            {
                byte[] k = (byte[])value;

                foreach (byte v in k)
                {
                    sv += v.ToString() + ",";
                }
                sv = sv.Remove(sv.Length - 1);

            }
            else if (value is byte[][])
            {
                byte[][] k = (byte[][])value;

                foreach (byte[] v in k)
                {
                    foreach (byte b in v)
                    {
                        sv += b.ToString() + ",";
                    }
                    sv = sv.Remove(sv.Length - 1);
                    sv += "|";
                }
                sv = sv.Remove(sv.Length - 1);


            }
            else if (value is DateTime)
            {
                DateTime cv = (DateTime)value;

                sv = cv.ToString("yyyy-MM-DD&hh-mm-ss");// cv.Year.ToString() + "," + cv.Month.ToString() + "," + cv.Day.ToString() + "," + cv.Hour.ToString() + "," + cv.Minute.ToString();
            }
            else
            {
                sv = value.ToString();
            }

            if (!ConfigData.ContainsKey(def))
            {
                ConfigData.Add(def, new Dictionary<string, string>());
            }

            if (!ConfigData[def].ContainsKey(prop))
            {
                ConfigData[def].Add(prop, sv);
            }
            else
            {
                ConfigData[def][prop] = sv;
            }
        }

        public string []GetProperties()
        {
            return GetProperties("");
        }

        public string[] GetProperties(String DefaultName)
        {

            if (ConfigData.ContainsKey(DefaultName))
            {
                string[] col = new string[ConfigData[DefaultName].Count];
                ConfigData[DefaultName].Keys.CopyTo(col, 0);
                return col;
            }
            else
            {
                return null;
            }

        }

        public string[] GetNames()
        {
            string[] col = new string[ConfigData.Count];
            ConfigData.Keys.CopyTo(col, 0);
            return col;


        }

        public void Clear()
        {
            ConfigData.Clear();
        }

        public void Close()
        {
            ConfigData.Clear();
            ConfigData = null;
        }

        public void Save(string File)
        {
            try
            {
                System.IO.StreamWriter fs = new System.IO.StreamWriter(File);
                fs.AutoFlush = true;
                foreach (string DefaultName in ConfigData.Keys)
                {
                    fs.WriteLine("[" + DefaultName + "]");
                    foreach (string property in ConfigData[DefaultName].Keys)
                    {
                        fs.WriteLine(property + ":" + ConfigData[DefaultName][property]);
                    }
                    fs.WriteLine();
                    //fs.Flush();
                }

                fs.Close();
                fs = null;
            }
            catch
            {
            }

        }
    }
}

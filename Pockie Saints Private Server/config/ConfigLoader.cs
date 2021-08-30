using System;
using System.Collections.Generic;
using System.Text;

namespace config
{
    public class ConfigLoader
    {
        Dictionary<string, string> ConfigData;

        public ConfigLoader()
        {
            ConfigData = new Dictionary<string, string>();
        }

        public ConfigLoader(string File)
        {
            ConfigData = new Dictionary<string, string>();
            _Load(File);
        }

        public ConfigLoader(string[] Props)
        {
            ConfigData = new Dictionary<string, string>();
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
                foreach (string prop in data)
                {

                    propp = prop.Trim();

                    if (propp.StartsWith("/") || propp.Replace(" ", "") == "") continue;

                    int index = propp.IndexOf(':');

                    if (index < 1 || index + 1 >= propp.Length) continue;

                    key = propp.Substring(0, index);
                    value = propp.Substring(index + 1);

                    ConfigData.Add(key.Trim().ToLower(), value.Trim());
                }
            }
            catch
            {
            }
        }

        public void GetInt(ref int value, string property)
        {
            try
            {
                if (!ConfigData.ContainsKey(property)) return;

                value = int.Parse(ConfigData[property]);
            }
            catch
            {

            }
        }

        public void GetString(ref string value, string property)
        {
            try
            {
                if (!ConfigData.ContainsKey(property)) return;

                value = ConfigData[property];
            }
            catch
            {

            }
        }

        public void GetTime(ref byte[] value, string property)
        {

            try
            {
                if (!ConfigData.ContainsKey(property)) return;
                string[] time = ConfigData[property].Replace(" ", "").Split("-".ToCharArray());
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

        public void GetBool(ref bool value, string property)
        {
            try
            {

                if (!ConfigData.ContainsKey(property)) return;

                string tmp = ConfigData[property].Trim().ToLower();

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

        public void GetTimes(ref byte[][] value, string property)
        {
            try
            {
                if (!ConfigData.ContainsKey(property)) return;
                string[] timez = ConfigData[property].Replace(" ", "").Split(",".ToCharArray());


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

        public void GetShort(ref short value, string property)
        {
            try
            {
                if (!ConfigData.ContainsKey(property)) return;

                value = short.Parse(ConfigData[property]);
            }
            catch
            {
            }

        }

        public void GetByte(ref byte value, string property)
        {
            try
            {
                if (!ConfigData.ContainsKey(property)) return;

                value = byte.Parse(ConfigData[property]);
            }
            catch
            {
            }
        }

        public void GetDate(ref DateTime value, string property)
        {
            try
            {
                if (!ConfigData.ContainsKey(property)) return;
                string[] timez = ConfigData[property].Replace(" ", "").Split(",".ToCharArray());

                int[] ex = new int[3];

                ex[0] = int.Parse(timez[0]);
                ex[1] = int.Parse(timez[1]);
                ex[2] = int.Parse(timez[2]);

                value = new DateTime(ex[2], ex[1], ex[0]);

            }
            catch
            {

            }
        }

        public void GetDateTime(ref DateTime value, string property)
        {
            try
            {
                if (!ConfigData.ContainsKey(property)) return;
                string[] timez = ConfigData[property].Replace(" ", "").Split(",".ToCharArray());

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

        public void GetFloat(ref float value, string property)
        {
            try
            {
                if (!ConfigData.ContainsKey(property)) return;

                value = float.Parse(ConfigData[property]);
            }
            catch
            {

            }
        }

        public void GetDouble(ref double value, string property)
        {
            try
            {
                if (!ConfigData.ContainsKey(property)) return;

                value = double.Parse(ConfigData[property]);
            }
            catch
            {

            }
        }

        public bool PropertyExists(string property)
        {
            return ConfigData.ContainsKey(property);
        }

        public Dictionary<string, int> ToIntDictionary()
        {

            Dictionary<string, int> tmp = new Dictionary<string, int>();


            foreach (string key in ConfigData.Keys)
            {
                int val = 0;

                try
                {
                    val = int.Parse(ConfigData[key].Replace(" ", ""));
                }
                catch
                {
                }

                tmp.Add(key, val);
            }


            return tmp;
        }

        public Dictionary<string, byte> ToByteDictionary()
        {

            Dictionary<string, byte> tmp = new Dictionary<string, byte>();


            foreach (string key in ConfigData.Keys)
            {
                byte val = 0;

                try
                {
                    val = byte.Parse(ConfigData[key].Replace(" ", ""));
                }
                catch
                {
                }

                tmp.Add(key, val);
            }


            return tmp;
        }

        public Dictionary<string, short> ToShortDictionary()
        {

            Dictionary<string, short> tmp = new Dictionary<string, short>();


            foreach (string key in ConfigData.Keys)
            {
                short val = 0;

                try
                {
                    val = short.Parse(ConfigData[key].Replace(" ", ""));
                }
                catch
                {
                }

                tmp.Add(key, val);
            }


            return tmp;
        }

        public Dictionary<string, string> ToStringDictionary()
        {
            Dictionary<string, string> tmp = new Dictionary<string, string>();
            foreach (string key in ConfigData.Keys)
            {
                tmp.Add(key, ConfigData[key].Trim());//.Replace(" ", "");
            }


            return tmp;
        }

        public Dictionary<string, bool> ToBoolDictionary()
        {

            Dictionary<string, bool> tmp = new Dictionary<string, bool>();

            foreach (string key in ConfigData.Keys)
            {
                bool val = false;

                string tmpt = ConfigData[key].Trim().ToLower();

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

        public Dictionary<string, float> ToFloatDictionary()
        {

            Dictionary<string, float> tmp = new Dictionary<string, float>();


            foreach (string key in ConfigData.Keys)
            {
                float val = 0;

                try
                {
                    val = float.Parse(ConfigData[key].Replace(" ", ""));
                }
                catch
                {
                }

                tmp.Add(key, val);
            }


            return tmp;
        }

        public Dictionary<string, double> ToDoubleDictionary()
        {

            Dictionary<string, double> tmp = new Dictionary<string, double>();


            foreach (string key in ConfigData.Keys)
            {
                double val = 0;

                try
                {
                    val = double.Parse(ConfigData[key].Replace(" ", ""));
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
            string sv = "";

            string prop = property.ToLower().Trim();

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

                    sv += "|";
                }
                sv = sv.Remove(sv.Length - 1);


            }
            else if (value is DateTime)
            {
                DateTime cv = (DateTime)value;

                sv = cv.Year.ToString() + "," + cv.Month.ToString() + "," + cv.Day.ToString() + "," + cv.Hour.ToString() + "," + cv.Minute.ToString();
            }
            else
            {
                sv = value.ToString();
            }


            if (!ConfigData.ContainsKey(prop))
            {
                ConfigData.Add(prop, sv);
            }
            else
            {
                ConfigData[prop] = sv;
            }
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


        public string[] GetProperties()
        {
            string[] col = new string[ConfigData.Count];
            ConfigData.Keys.CopyTo(col, 0);
            return col;


        }

        public void Save(string File)
        {
            try
            {
                System.IO.StreamWriter fs = new System.IO.StreamWriter(File);
                fs.AutoFlush = true;

                foreach (string property in ConfigData.Keys)
                {
                    fs.WriteLine(property + ":" + ConfigData[property]);
                }
                fs.WriteLine();

                fs.Close();
                fs = null;
            }
            catch
            {
            }

        }
    }
}

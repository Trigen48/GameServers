#define db
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;

namespace Connector
{

    public class MySqlConnector : IConnector
    {
        public static string server = "", database = "", username = "", password = "";
        public long LastID { get; set; }
        string cmdx = "";

        int lasti = 0;
        private MySqlConnection con;

        public string procCall { get { return "CALL "; } }

        public string StatementEnd { get { return ";"; } }

        public MySqlConnector()
        {
            string constring;
            constring = "SERVER=" + server + ";" +
            "DATABASE=" + database + ";" + "UID=" + username + ";";
            if (password != "")
            {
                constring += "PASSWORD=" + password + ";";
            }
            con = new MySqlConnection(constring);
        }

        public MySqlConnector(string Server, string Database, string Username, string Password)
        {
            string constring;
            constring = "SERVER=" + Server + ";" +
            "DATABASE=" + Database + ";" + "UID=" + Username + ";";
            if (Password != "")
            {
                constring += "PASSWORD=" + Password + ";";
            }
            con = new MySqlConnection(constring);
        }

        private bool Connect()
        {
#if db
            try
            {
#endif
                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    System.Threading.Thread.Sleep(500);
                    if (con.State == System.Data.ConnectionState.Open) Close();
                }

                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
#if db
            }
            catch (Exception ex)
            {
                clog.Save(ex);
            }
#endif
            return false;
        }

        private void Close()
        {
#if db
            try
            {
#endif

                con.Close();
#if db
            }
            catch (Exception ex)
            {
                clog.Save(ex);
            }
#endif
        }

        public DataTable ExecuteDataTable()
        {
            return ExecuteDataTable(GetCommand());
        }

        public DataTable ExecuteDataTablep()
        {
            return ExecuteDataTable(procCall + GetCommand());
        }

        public DataTable ExecuteDataTable(string command)
        {
            DataTable tb = new DataTable();
            try
            {
                if (Connect())
                {
                    
#if db
                    try
                    {
#endif
                        MySqlCommand cmd = new MySqlCommand(command + ";", con);
                        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                        adp.Fill(tb);
                        Close();
                        tb.Dispose();

#if db
                    }
                    catch (Exception ex)
                    {
                        clog.Save(ex);
                        //tb = null;
                    }
#endif

                    //return tb;

                }
            }
            catch (Exception ex)
            {
                clog.Save(ex);
                //tb = null;
            }

            return tb;
        }

        public DataTable ExecuteDataTableKey()
        {
            return ExecuteDataTableKey(GetCommand());
        }

        public DataTable ExecuteDataTableKeyp()
        {
            return ExecuteDataTableKey(procCall + GetCommand());
        }

        public DataTable ExecuteDataTableKey(string command)
        {
            DataTable tb = new DataTable();
            try
            {
                if (Connect())
                {

#if db
                    try
                    {
#endif
                        MySqlCommand cmd = new MySqlCommand(command + ";", con);
                        
                        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                        adp.MissingSchemaAction = MissingSchemaAction.AddWithKey;

                        adp.Fill(tb);
                        Close();
                        tb.Dispose();

#if db
                    }
                    catch (Exception ex)
                    {
                        clog.Save(ex);
                        //tb = null;
                    }
#endif

                    //return tb;

                }
            }
            catch (Exception ex)
            {
                clog.Save(ex);
                //tb = null;
            }

            return tb;
        }


        public DataReader ExecuteRead()
        {
            return ExecuteRead(GetCommand());
        }

        public DataReader ExecuteReadp()
        {
            return ExecuteRead(procCall + GetCommand());
        }

        public DataReader ExecuteRead(string command)
        {
#if db
            try
            {
#endif

                if (Connect())
                {

                    MySqlCommand cmd = new MySqlCommand(command + ";", con);
                    MySqlDataReader rd = cmd.ExecuteReader();

                    BindingList<object[]> o = new BindingList<object[]>();
                    Dictionary<string, int> Fields = new Dictionary<string, int>();
                    if (rd.HasRows)
                    {
#if db
                        try
                        {
#endif
                            // int rows
                            int count = rd.FieldCount;


                            for (int x = 0; x < count; x++)
                            {
                                Fields.Add(rd.GetName(x).ToLower(), x);
                            }


                            while (rd.Read())
                            {
                                object[] ob = new object[count];
                                rd.GetValues(ob);
                                o.Add(ob);


                            }

#if db
                        }
                        catch (Exception ex)
                        {
                            clog.Save(ex);
                            o = null;
                        }
#endif
                    }

                    rd.Close();
                    rd = null;

                    Close();
                    return new DataReader(Fields, o);

                }
#if db
            }
            catch (Exception ex)
            {
                clog.Save(ex);
                clog.Save(command);
            }
#endif

            return new DataReader(null, null);
        }

        public object ExecuteScalar()
        {
            return ExecuteScalar(GetCommand());
        }

        public object ExecuteScalarp()
        {
            return ExecuteScalar(procCall + GetCommand());
        }

        public object ExecuteScalar(string command)
        {
#if db
            try
            {
#endif
                if (Connect())
                {

                    MySqlCommand cmd = new MySqlCommand(command + ";", con);

                    object o = cmd.ExecuteScalar();
                    Close();
                    return o;

                }
#if db
            }
            catch (Exception ex)
            {
                clog.Save(ex);
                clog.Save(command);
            }
#endif
            return null;
        }

        public int ExecuteNoneQuery()
        {
            return ExecuteNoneQuery(GetCommand());
        }

        public int ExecuteNoneQueryp()
        {
            return ExecuteNoneQuery(procCall + GetCommand());
        }

        public int ExecuteNoneQuery(string command)
        {
#if db
            try
            {
#endif
                if (Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(command + ";", con);

                    int o = cmd.ExecuteNonQuery();
                    LastID = cmd.LastInsertedId;
                    Close();
                    return o;
                }
#if db
            }
            catch (Exception ex)
            {
                clog.Save(ex);
                clog.Save(command);
            }
#endif

            return -1;
        }

        internal List<string> _commandList = new List<string>();

        public void PushCommand()
        {
            _commandList.Add(GetCommand());
        }

        public int ExecuteMassUpdate()
        {
            int i = ExecuteMassUpdate(_commandList);
            _commandList.Clear();
            return i;
        }


        public int ExecuteMassUpdate(List<string> commands)
        {
#if db
            try
            {
#endif
                if (Connect())
                {

                    MySqlCommand cmd = con.CreateCommand();
                    MySqlTransaction trans = con.BeginTransaction();
                    cmd.Transaction = trans;


                    int l = 0;
                    try
                    {

                        foreach (string c in commands)
                        {
                            cmd.CommandText = c + ";";
                            l += cmd.ExecuteNonQuery();
                        }

                        trans.Commit();

                        trans = null;
                        cmd = null;
                        LastID = 0;
                        Close();
                        return l;
                    }
                    catch (Exception ex)
                    {
                        clog.Save(ex);
                        try
                        {
                            if (con.State == System.Data.ConnectionState.Open) trans.Rollback();
                        }
                        catch (Exception ex1)
                        {
                            clog.Save(ex1);
                        }
                    }

                    trans = null;
                    cmd = null;
                }
#if db
            }
            catch (Exception ex)
            {
                clog.Save(ex);
                //clog.Save(command);
                //throw ex;
            }
#endif

            return -1;
        }


        public void StartCommand(string command)
        {
            cmdx = command;
        }

        public void AppendCommand(string command)
        {
            cmdx += " " + command;
        }

        public void AddValue(object value)
        {
            AddValue(value, false);
        }

        public void AddValue(object value, bool ignore)
        {
            try
            {
                Type t = value.GetType();
                string pushValue = "";

                if (cmdx.Contains('?') && cmdx.IndexOf('?', lasti) != -1)
                {
                    if (ignore)
                    {
                        pushValue = value.ToString();
                    }
                    else if (t == typeof(string) || t == typeof(char))
                    {
                        string v = value.ToString();

                        // Make sure we replace single quotes with single inverted quotes
                        if (v.Contains("'"))
                        {
                            v = v.Replace("'", "`");
                        }

                        pushValue = "'" + v + "'";
                    }
                    else if (t == typeof(DateTime))
                    {
                        pushValue = "'" + ((DateTime)value).ToString("yyyy/MM/dd HH:mm:ss") + "'";
                    }
                    else if (t == typeof(TimeSpan))
                    {
                        TimeSpan tmp=(TimeSpan)value;
                        string timeFormat = string.Format("{0}:{1}:{2}",tmp.Hours,tmp.Minutes,tmp.Seconds);


                        pushValue = "'" + timeFormat /*((TimeSpan)value).ToString(@"HH\:mm\:ss")*/ + "'";
                    }
                    else if (t == typeof(bool) || t == typeof(Boolean))
                    {
                        pushValue = /*"'" +*/ value.ToString();// +"'";
                    }
                    else if (typeof(byte[]) == t)
                    {
                        pushValue = ByteToString((byte[])value);
                    }
                    else
                    {
                        pushValue = value.ToString().Replace('\'', '`');
                    }

                    int index = cmdx.IndexOf('?', lasti);
                    lasti = index + pushValue.Length;
                    cmdx = cmdx.Substring(0, index) + pushValue + cmdx.Substring(index + 1);
                }
            }
            catch(Exception ex)
            {
                clog.Save(ex);
            }

        }

        internal static string ByteToString(byte[] value)
        {
            if (value == null)
            {
                return "NULL";
            }
            return "0x" + BitConverter.ToString(value).Replace("-", "");
        }

        public string GetCommand()
        {
            string c = cmdx;
            cmdx = "";
            lasti = 0;
            return c;
        }

        public bool Test()
        {
            bool can = Connect();

            if (can)
                Close();

            return can;
        }
    }
}

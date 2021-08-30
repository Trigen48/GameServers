#define db
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
namespace Connector
{

    public class MsSqlConnector : IConnector
    {
        public static string server = "", database = "", username = "", password = "";
        string cmdx = "";
        private SqlConnection con;
        int lasti = 0;

        public string procCall { get { return "EXEC "; } }
        public string StatementEnd { get { return ";"; } }

        public MsSqlConnector()
        {
            string constring;
            constring = "Data Source=" + server + ";";

            if (database != "")
            {
                constring += "Initial Catalog=" + database + ";";
            }
            if (username != "" && password != "")
            {
                constring += "User Id=" + username + ";";
                constring += "Password=" + password + ";";
            }

            else
            {
                constring += " Integrated Security=True;Pooling=False;";
            }
            con = new SqlConnection(constring);

            //base(
        }

        public MsSqlConnector(string Server, string Database, string Username, string Password)
        {
            string constring;

            //Data Source=localhost;Initial Catalog=ICBTDB;Integrated Security=True;Pooling=False
            constring = "Data Source=" + Server + ";";

            if (Database != "")
            {
                constring += "Initial Catalog=" + Database + ";";
            }

            
            if (Username != "" && Password != "")
            {
                constring += "User Id=" + Username + ";";  
                constring += "Password=" + Password + ";";
            }
            else 
            {
                constring += " Integrated Security=True;Pooling=False;";
            }

            con = new SqlConnection(constring);
        }

        public MsSqlConnector(string connectionString)
        {
            con= new SqlConnection(connectionString);
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
            catch(Exception ex)
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
                        SqlCommand cmd = new SqlCommand(command + ";", con);
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);

                        adp.Fill(tb);
                        Close();
                        tb.Dispose();

#if db
                    }
                    catch (Exception ex)
                    {
                        clog.Save(ex);
                      //  tb = null;
                    }
#endif

                    //return tb;

                }
            }
            catch (Exception ex)
            {
                clog.Save(ex);
               // tb = null;
            }

            return tb;
        }

        public DataTable ExecuteDataTableScheme()
        {
            return ExecuteDataTableScheme(GetCommand());
        }

        public DataTable ExecuteDataTableSchemep()
        {
            return ExecuteDataTableScheme(procCall + GetCommand());
        }

        public DataTable ExecuteDataTableScheme(string command)
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
                        SqlCommand cmd = new SqlCommand(command + ";", con);

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.MissingSchemaAction = MissingSchemaAction.Add;

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
                        SqlCommand cmd = new SqlCommand(command + ";", con);

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
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
            try
            {
                if (Connect())
                {
                    SqlCommand cmd = new SqlCommand(command, con);
                    SqlDataReader rd = cmd.ExecuteReader();

                    BindingList<object[]> o = new BindingList<object[]>();
                    Dictionary<string, int> Fields = new Dictionary<string, int>();
                    if (rd.HasRows)
                    {
                        try
                        {
                            // int rows
                            int count = rd.FieldCount;

                            for(int x=0;x<count;x++)
                            {
                                Fields.Add(rd.GetName(x).ToLower(),x);
                            }

                            while (rd.Read())
                            {
                                object[] ob = new object[count];
                                rd.GetValues(ob);
                                o.Add(ob);
                            }
                        }
                        catch (Exception ex)
                        {
                            clog.Save(ex);
                            o = null;
                        }
                    }


                    Close();
                    return new DataReader(Fields,o);
                }
            }
            catch (Exception ex)
            {
                clog.Save(ex);
            }

            return new DataReader(null,null);
        }


        public void ForEachRead( Func<object[], bool> func)
        {
            ForEachRead(GetCommand(), func);
        }
        public void ForEachRead(string command,Func<object[],bool> func)
        {
            try
            {
                if (Connect())
                {
                    SqlCommand cmd = new SqlCommand(command, con);

                    SqlDataAdapter adp = new SqlDataAdapter(command, con);
                  
                    SqlDataReader rd = cmd.ExecuteReader();

           
                    if (rd.HasRows)
                    {
                        try
                        {
                            // int rows
                            int count = rd.FieldCount;

                           /* for (int x = 0; x < count; x++)
                            {
                                Fields.Add(rd.GetName(x).ToLower(), x);
                            }*/

                            while (rd.Read())
                            {
                                object[] o = new object[count];

                                rd.GetValues(o);


                          
                                if(!func.Invoke(o))
                                {
                                    break;
                                }
                            
                            }
                        }
                        catch (Exception ex)
                        {
                            clog.Save(ex);
                            //o = null;
                        }
                    }


                    Close();
                   // return new DataReader(Fields, o);
                }
            }
            catch (Exception ex)
            {
                clog.Save(ex);
            }

           // return new DataReader(null, null);
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

            try
            {
                if (Connect())
                {
                    SqlCommand cmd = new SqlCommand(command, con);
                    object o = cmd.ExecuteScalar();
                    Close();
                    return o;
                }
            }
            catch (Exception ex)
            {
                clog.Save(ex);
            }
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
          //  lasti = -1;
            try
            {
                if (Connect())
                {

         
                        SqlCommand cmd = new SqlCommand(command, con);
                        int o = cmd.ExecuteNonQuery();
                        Close();
                        return o;
                    
                }
            }
            catch (Exception ex)
            {
                clog.Save(ex);
            }

            return -1;
        }

        public int ExecuteInsert()
        {
            return ExecuteInsert(GetCommand());
        }

        public int ExecuteInsertp()
        {
            return ExecuteInsert(procCall + GetCommand());
        }

        public int ExecuteInsert(string command)
        {

            object v = ExecuteScalar(command + "; SELECT SCOPE_IDENTITY()");

            if (v != null)
            {
                try
                {
                    return Convert.ToInt32(v);
                }
                catch
                {
                }
            }
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
                    pushValue = "'" + ((TimeSpan)value).ToString(@"HH\:mm\:ss") + "'";
                }
                else if (t == typeof(bool) || t == typeof(Boolean))
                {
                    pushValue = "'" + value.ToString() + "'";
                }
                else if (typeof(byte[]) == t)
                {
                    pushValue = ByteToString((byte[])value);
                }
                else
                {
                    pushValue = value.ToString().Replace('\'','`');
                }

                int index = cmdx.IndexOf('?', lasti);
                lasti = index + pushValue.Length;
                cmdx = cmdx.Substring(0, index) + pushValue + cmdx.Substring(index + 1);
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

using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Item_Helper
{

    internal static class dbtools
    {
        private static string ts(object v)
        {

            return "'" + ti(v) + "'";
        }

        private static string ti(object v)
        {
            return v.ToString();
        }

        internal static void GetParam(ref string cmm, string parm, object v)
        {
            // string b;


            if (typeof(string) == v.GetType())
            {
                cmm = cmm.Replace(parm, ts(v));
            }
            else
            {
                cmm = cmm.Replace(parm, ti(v));
            }

        }

        internal static void ExecuteScalar(SqlConnection cn, string cmm, out object v)
        {
            SqlCommand cmd = new SqlCommand(cmm, cn);
            try
            {
                v = cmd.ExecuteScalar();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                v = null;
            }
            cmm = "";
        }

        internal static void ExecuteReader(SqlConnection cn, string cmm, out SqlDataReader v)
        {
            SqlCommand cmd = new SqlCommand(cmm, cn);
            try
            {
                v = cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                v = null;
            }
            cmm = "";
        }

        internal static int ExecuteCount(SqlConnection cn, string cmm)
        {
            SqlCommand cmd = new SqlCommand(cmm, cn);
            int i = 0;
            try
            {
                i=cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                i=-1;
            }
            cmm = "";
            return i;
        }

        internal static void dbstate(SqlConnection cn)
        {
            if (cn.State != System.Data.ConnectionState.Open) cn.Open();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Online_Shop
{
    public class ConClass
    {
        SqlConnection con;
        SqlCommand cmd;
        public ConClass()
        {
            con = new SqlConnection(@"server=DESKTOP-ACG6GH8\SQLEXPRESS;database=DBShop;integrated security=true");
        }
        public int Fun_Non_Query(string sql)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sql, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public string Fun_Scalar(string sql)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            cmd = new SqlCommand(sql, con);
            con.Open();
            string s = cmd.ExecuteScalar().ToString();
            con.Close();
            return s;
        }

        public DataSet Fun_Dataset(string sql)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
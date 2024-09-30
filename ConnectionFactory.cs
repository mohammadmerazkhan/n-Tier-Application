using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.EnterpriseServices;
namespace DAL
{
    /// <summary>
    /// Summary description for ConnectionFactory
    /// </summary>
    /// 
    public class ConnectionFactory
{
        // SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);  
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-CKSBOEVR;Initial Catalog=N_Tier;User ID=sa;Password=12345");
        public bool InsertEmpInfo(string cmdtext, SqlParameter[] p)
       
        {
        try
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = cmdtext;
            cmd.Connection = con;
            foreach (object obj in p)
            {
                cmd.Parameters.Add(obj);
            }
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            if (res != 0)
            {
                return false;
            }
            else
                return true;
        }
        catch
        {
            throw;
        }
    }
    public DataSet DisplayEmpData(string cmdtext)
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdtext, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        catch
        {
            throw;
        }
    }
    public DataSet DisplayEmpData1(string cmdtext, SqlParameter[] p)
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(cmdtext, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (object obj in p)
            {
                cmd.Parameters.Add(obj);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        catch
        {
            throw;
        }
    }
}  
}  
 
 
using System;
using System.Data;
using System.Data.SqlClient;

namespace SCHOOL_MANAGEMENT_SYSTEM
{
    internal class DataAccess
    {
        private SqlConnection Sqlcon;
        private SqlCommand Sqlcom;
        private SqlDataAdapter Sda;
        private DataSet Ds;

        //  Constructor 
        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(
                @"Data Source=WINDOWS-APJ86N6\SQLEXPRESS;
                  Initial Catalog=SchoolManagementDB;
                  Integrated Security=True");

            this.Sqlcon.Open();
        }

        //  SELECT 
        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
        }



        //  SELECT 
        public DataTable ExecuteQueryTable(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        //  INSERT / UPDATE / DELETE 
    
        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            int rows = this.Sqlcom.ExecuteNonQuery();
            return rows;
        }

        //  SELECT with Parameters
        public DataTable ExecuteQueryTable(string sql, SqlParameter[] parameters)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddRange(parameters);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }



        //  INSERT/UPDATE/DELETE with Parameters 
       
        public int ExecuteDMLQuery(string sql, SqlParameter[] parameters)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddRange(parameters);
            int rows = this.Sqlcom.ExecuteNonQuery();
            return rows;
        }
    }
}
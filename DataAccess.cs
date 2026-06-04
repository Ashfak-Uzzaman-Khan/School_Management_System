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

        // ─── Constructor — Database এর সাথে সংযোগ ───
        public DataAccess()
        {
            this.Sqlcon = new SqlConnection(
                @"Data Source=WINDOWS-APJ86N6\SQLEXPRESS;
                  Initial Catalog=SchoolManagementDB;
                  Integrated Security=True");

            this.Sqlcon.Open();
        }

        // ─── SELECT → DataSet ফেরত দেয় ───
        // ব্যবহার: DataGridView এ data দেখাতে
        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds;
        }



        // ─── SELECT → DataTable ফেরত দেয় ───
        // ব্যবহার: একটা টেবিলের data দরকার হলে
        public DataTable ExecuteQueryTable(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }

        // ─── INSERT / UPDATE / DELETE ───
        // ব্যবহার: data যোগ, পরিবর্তন, মুছতে
        // return: 1 = সফল, 0 = ব্যর্থ
        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            int rows = this.Sqlcom.ExecuteNonQuery();
            return rows;
        }

        // ─── SELECT with Parameters (SQL Injection থেকে সুরক্ষা) ───
        // ব্যবহার: Login বা Search এর মতো sensitive query তে
        public DataTable ExecuteQueryTable(string sql, SqlParameter[] parameters)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddRange(parameters);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return this.Ds.Tables[0];
        }



        // ─── INSERT/UPDATE/DELETE with Parameters ───
        // ব্যবহার: secure ভাবে data লেখার জন্য
        public int ExecuteDMLQuery(string sql, SqlParameter[] parameters)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);
            this.Sqlcom.Parameters.AddRange(parameters);
            int rows = this.Sqlcom.ExecuteNonQuery();
            return rows;
        }
    }
}
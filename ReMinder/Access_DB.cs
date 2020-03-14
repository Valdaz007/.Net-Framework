using System;
using System.Data.OleDb;

namespace ReMinder
{
    public class Access_DB
    {
        private readonly OleDbDataReader _;
        public OleDbConnection conn;

        public Access_DB ()
        {
            conn = new OleDbConnection();
            # Connection String
            conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; 
                                    Data Source = [File Path/File Name];
                                    Persist Security Info = False;";
        }

        # Checking Connection
        public string Connection()
        {
            try
            {
                conn.Open();
                conn.Close();
                return "DB Connected";
            }
            catch (Exception)
            {
                conn.Close();
                return "DB Connection Fail";
            }
        }

        # SQL INSERT COMMAND Method 
        public string INSERT(string tbl, string col, string value)
        {
            try
            {
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = $"INSERT INTO {tbl} ({col}) VALUES ({value});";
                comm.ExecuteNonQuery();
                conn.Close();
                return "Event Reminder Added!";
            }
            catch (Exception e)
            {
                conn.Close();
                return $"Error Occur:\n {e}";
            }
        }

        # SQL SELECT COMMAND Method 
        public OleDbDataReader SELECT(string col, string tbl)
        {
            try
            {
                OleDbCommand comm = new OleDbCommand();
                conn.Open();
                comm.Connection = conn;
                comm.CommandText = $"SELECT {col} FROM {tbl};";
                OleDbDataReader rd = comm.ExecuteReader();
                return rd;
            }
            catch (Exception)
            {
                conn.Close();
                return _;
            }
        }
    }
}

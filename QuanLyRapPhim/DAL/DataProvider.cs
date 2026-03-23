using System;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyRapPhim.DAL
{
    public class DataProvider
    {
        private static DataProvider _instance;
        private static readonly object _lock = new object();

        private const string CONNECTION_STRING =
            "Data Source=something\\SQLEXPRESS;Initial Catalog=QuanLyRapPhim;Integrated Security=True;";

        private DataProvider() { }


        public static DataProvider Instance
        {
            get
            {
                if (_instance == null)
                    lock (_lock) { if (_instance == null) _instance = new DataProvider(); }
                return _instance;
            }
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(CONNECTION_STRING);
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        adapter.Fill(dt);
                }
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteScalar();
                }
            }
        }
    }
}


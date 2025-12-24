using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace TTCSDL_NHOM7.DAOs
{
    internal class DataProvider
    {
        private static string connectionString =
            "Data Source=localhost,1466;Initial Catalog=QLRPhim;User ID=sa;Password=StrongPassword123!;TrustServerCertificate=True";

        private DataProvider() { }

        public static bool TestConnection()
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return true;
            }
            catch { return false; }
        }

        public static DataTable ExecuteQuery(string sql, CommandType type = CommandType.Text, params SqlParameter[] parameters)
        {
            DataTable table = new DataTable();
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn)
            {
                CommandType = type
            };

            if (parameters != null && parameters.Length > 0)
                cmd.Parameters.AddRange(parameters);

            using SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(table);

            return table;
        }

        public static int ExecuteNonQuery(string sql, CommandType type = CommandType.Text, params SqlParameter[] parameters)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn)
            {
                CommandType = type
            };

            if (parameters != null && parameters.Length > 0)
                cmd.Parameters.AddRange(parameters);

            conn.Open();
            return cmd.ExecuteNonQuery();
        }

        public static object ExecuteScalar(string sql, CommandType type = CommandType.Text, params SqlParameter[] parameters)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            using SqlCommand cmd = new SqlCommand(sql, conn)
            {
                CommandType = type
            };

            if (parameters != null && parameters.Length > 0)
                cmd.Parameters.AddRange(parameters);

            conn.Open();
            return cmd.ExecuteScalar();
        }
    }
}

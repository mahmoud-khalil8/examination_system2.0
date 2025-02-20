using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DataAccess
{
    public class DatabaseHelper
    {
        private static readonly string connectionString = GetConnectionString();

        private static string GetConnectionString()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true)
                .Build();
            var connectionString = config.GetSection("connectionString").Value;
            return connectionString;
        }


        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {

            DataTable dt = new DataTable();
            SqlConnection conn= GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand(query, conn);
            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }
        public static object ExecuteScalar(string query, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters);
                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }

        public static int ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters = null)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }


    }
}

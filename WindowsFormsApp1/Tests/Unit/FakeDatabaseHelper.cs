using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DataAccess;
namespace WindowsFormsApp1.Tests.Unit
{
    public class FakeDatabaseHelper
    {
        public string LastQuery { get; private set; }
        public SqlParameter[] LastParameters { get; private set; }
        public string LastStoredProcedure { get; private set; }
        private DataTable _mockDataTable;

        // Simulate ExecuteQuery
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            LastQuery = query;
            LastParameters = parameters ?? new SqlParameter[0];
            return _mockDataTable ?? new DataTable();
        }

        // Simulate ExecuteNonQuery
        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            LastQuery = query;
            LastParameters = parameters;
            return 1; // Default success (1 row affected)
        }

        // Simulate ExecuteStoredProcedure
        public void ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters)
        {
            LastStoredProcedure = procedureName;
            LastParameters = parameters;
        }

        // Setup mock DataTable for tests
        public void SetMockDataTable(DataTable dataTable)
        {
            _mockDataTable = dataTable;
        }
    }
}
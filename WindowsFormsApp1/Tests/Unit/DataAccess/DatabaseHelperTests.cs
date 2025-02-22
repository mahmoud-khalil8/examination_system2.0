using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Tests.Unit;

namespace WindowsFormsApp1.Tests.Unit.DataAccess
{
    public class DatabaseHelperTests
    {
        public void RunTests()
        {
            Test_GetConnectionString_NotNull();
            Test_ExecuteQuery_WithParameters();
            Test_ExecuteNonQuery_WithParameters();
            Test_ExecuteScalar_WithParameters();
            Test_ExecuteStoredProcedure_WithParameters();
            Console.WriteLine("All DatabaseHelper tests passed!");
        }

        private void Test_GetConnectionString_NotNull()
        {
            // Act
            string result = typeof(DatabaseHelper)
                .GetMethod("GetConnectionString", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static)
                .Invoke(null, null) as string;

            // Assert
            if (string.IsNullOrEmpty(result))
            {
                throw new Exception("Test_GetConnectionString_NotNull failed: Connection string should not be null or empty");
            }
        }

        private void Test_ExecuteQuery_WithParameters()
        {
            // Arrange
            string query = "SELECT * FROM TestTable WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", 1)
            };

            // Act (Cannot fully mock SqlConnection, so test parameter setup conceptually)
            // This would require integration testing for full execution
            DataTable result;
            try
            {
                result = DatabaseHelper.ExecuteQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Test_ExecuteQuery_WithParameters failed: Unexpected exception - " + ex.Message);
            }

            // Assert (Limited without mocking)
            if (result == null)
            {
                throw new Exception("Test_ExecuteQuery_WithParameters failed: Result should not be null");
            }
        }

        private void Test_ExecuteNonQuery_WithParameters()
        {
            // Arrange
            string query = "INSERT INTO TestTable (Name) VALUES (@Name)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", "Test")
            };

            // Act
            int result;
            try
            {
                result = DatabaseHelper.ExecuteNonQuery(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Test_ExecuteNonQuery_WithParameters failed: Unexpected exception - " + ex.Message);
            }

            // Assert (Limited without mocking)
            if (result < 0)
            {
                throw new Exception("Test_ExecuteNonQuery_WithParameters failed: Result should be non-negative");
            }
        }

        private void Test_ExecuteScalar_WithParameters()
        {
            // Arrange
            string query = "SELECT COUNT(*) FROM TestTable WHERE Id = @Id";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Id", 1)
            };

            // Act
            object result;
            try
            {
                result = DatabaseHelper.ExecuteScalar(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Test_ExecuteScalar_WithParameters failed: Unexpected exception - " + ex.Message);
            }

            // Assert
            if (result == null)
            {
                throw new Exception("Test_ExecuteScalar_WithParameters failed: Result should not be null");
            }
        }

        private void Test_ExecuteStoredProcedure_WithParameters()
        {
            // Arrange
            string procedureName = "TestProcedure";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Param", "Value")
            };

            // Act
            int result;
            try
            {
                result = DatabaseHelper.ExecuteStoredProcedure(procedureName, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Test_ExecuteStoredProcedure_WithParameters failed: Unexpected exception - " + ex.Message);
            }

            // Assert
            if (result < 0)
            {
                throw new Exception("Test_ExecuteStoredProcedure_WithParameters failed: Result should be non-negative");
            }
        }
    }
}
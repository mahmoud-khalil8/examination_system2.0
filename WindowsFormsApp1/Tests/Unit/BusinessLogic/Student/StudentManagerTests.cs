using System;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.BusinessLogic;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Tests.Unit;
namespace WindowsFormsApp1.Tests.Unit.BusinessLogic
{
    // Fake DatabaseHelper to mock database interactions
    

    public class StudentManagerTests
    {
        private readonly FakeDatabaseHelper _fakeDbHelper;

        public StudentManagerTests()
        {
            _fakeDbHelper = new FakeDatabaseHelper();
        }

        public void RunTests()
        {
            Test_getStudent_ValidCredentials();
            Test_getStudent_InvalidCredentials();
            Console.WriteLine("All StudentManager tests passed!");
        }

        private void Test_getStudent_ValidCredentials()
        {
            // Arrange
            string email = "student@example.com";
            string password = "pass123";
            var mockStudentData = new DataTable();
            mockStudentData.Columns.Add("UserID", typeof(int));
            mockStudentData.Columns.Add("Email", typeof(string));
            mockStudentData.Columns.Add("Password", typeof(string));
            mockStudentData.Rows.Add(1, "student@example.com", "pass123");
            _fakeDbHelper.SetMockDataTable(mockStudentData);

            // Act
            DataTable result = ExecuteWithFakeDb(() => StudentManager.getStudent(email, password));

            // Assert
            if (result.Rows.Count != 1)
            {
                throw new Exception($"Test_getStudent_ValidCredentials failed: Expected 1 row, got {result.Rows.Count}");
            }
            if ((int)result.Rows[0]["UserID"] != 1 ||
                (string)result.Rows[0]["Email"] != "student@example.com" ||
                (string)result.Rows[0]["Password"] != "pass123")
            {
                throw new Exception("Test_getStudent_ValidCredentials failed: Returned data does not match expected values");
            }
            if (!_fakeDbHelper.LastQuery.Contains("select * from users where Email=@email and password=@password"))
            {
                throw new Exception("Test_getStudent_ValidCredentials failed: Incorrect SQL query");
            }
            if (_fakeDbHelper.LastParameters.Length != 2 ||
                _fakeDbHelper.LastParameters[0].ParameterName != "@email" ||
                (string)_fakeDbHelper.LastParameters[0].Value != "student@example.com" ||
                _fakeDbHelper.LastParameters[1].ParameterName != "@password" ||
                (string)_fakeDbHelper.LastParameters[1].Value != "pass123")
            {
                throw new Exception("Test_getStudent_ValidCredentials failed: Parameters incorrect");
            }
        }

        private void Test_getStudent_InvalidCredentials()
        {
            // Arrange
            string email = "wrong@example.com";
            string password = "wrongpass";
            var mockEmptyData = new DataTable(); // Empty table for no match
            _fakeDbHelper.SetMockDataTable(mockEmptyData);

            // Act
            DataTable result = ExecuteWithFakeDb(() => StudentManager.getStudent(email, password));

            // Assert
            if (result.Rows.Count != 0)
            {
                throw new Exception($"Test_getStudent_InvalidCredentials failed: Expected 0 rows, got {result.Rows.Count}");
            }
            if (!_fakeDbHelper.LastQuery.Contains("select * from users where Email=@email and password=@password"))
            {
                throw new Exception("Test_getStudent_InvalidCredentials failed: Incorrect SQL query");
            }
            if (_fakeDbHelper.LastParameters.Length != 2 ||
                _fakeDbHelper.LastParameters[0].ParameterName != "@email" ||
                (string)_fakeDbHelper.LastParameters[0].Value != "wrong@example.com" ||
                _fakeDbHelper.LastParameters[1].ParameterName != "@password" ||
                (string)_fakeDbHelper.LastParameters[1].Value != "wrongpass")
            {
                throw new Exception("Test_getStudent_InvalidCredentials failed: Parameters incorrect");
            }
        }

        // Helper to run methods with fake DatabaseHelper
        private T ExecuteWithFakeDb<T>(Func<T> action)
        {
            // Since DatabaseHelper is static, this assumes the fake replaces it in test context
            // Refactor to an interface for true isolation in production code
            return action();
        }
    }
}
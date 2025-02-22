using System;
using System.Data.SqlClient;
using WindowsFormsApp1.BusinessLogic.Admin;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Tests.Unit;

namespace WindowsFormsApp1.Tests.Unit.BusinessLogic.Admin
{

    public class UserManagerTests
    {
        private readonly FakeDatabaseHelper _fakeDbHelper;

        public UserManagerTests()
        {
            _fakeDbHelper = new FakeDatabaseHelper();
        }

        public void RunTests()
        {
            Test_CreateUser_ValidUser();
            Test_CreateUser_NullOptionalFields();
            Test_UpdateUser_ValidUser();
            Test_DeleteUser_ValidId();
            Console.WriteLine("All UserManager tests passed!");
        }

        private void Test_CreateUser_ValidUser()
        {
            var user = new UserModel
            {
                UserName = "testuser",
                FullName = "Test User",
                Email = "test@example.com",
                Password = "password123",
                Role = "Student",
                Phone = "1234567890",
                Address = "123 Test St",
                Gender = "M",
                BirthDate = new DateTime(2000, 1, 1),
                Age = 23,
                CreatedBy = 1,
                SupervisedBy = 2
            };

            int result = ExecuteWithFakeDb(() => UserManager.CreateUser(user));

            if (result != 1)
            {
                throw new Exception($"Test_CreateUser_ValidUser failed: Expected 1 row affected, got {result}");
            }
            if (!_fakeDbHelper.LastQuery.Contains("INSERT INTO Users"))
            {
                throw new Exception("Test_CreateUser_ValidUser failed: Incorrect SQL query");
            }
            if (_fakeDbHelper.LastParameters.Length != 12 ||
                _fakeDbHelper.LastParameters[0].ParameterName != "@UserName" ||
                (string)_fakeDbHelper.LastParameters[0].Value != "testuser")
            {
                throw new Exception("Test_CreateUser_ValidUser failed: UserName parameter incorrect");
            }
        }

        private void Test_CreateUser_NullOptionalFields()
        {
            var user = new UserModel
            {
                UserName = "testuser2",
                FullName = "Test User 2",
                Email = "test2@example.com",
                Password = "password456",
                Role = "Teacher",
                Phone = "0987654321",
                Address = "456 Test Rd",
                Gender = "F",
                BirthDate = null,
                Age = null,
                CreatedBy = null,
                SupervisedBy = null
            };

            int result = ExecuteWithFakeDb(() => UserManager.CreateUser(user));

            if (result != 1)
            {
                throw new Exception($"Test_CreateUser_NullOptionalFields failed: Expected 1 row affected, got {result}");
            }
            if (_fakeDbHelper.LastParameters[9].Value != DBNull.Value) // BirthDate
            {
                throw new Exception("Test_CreateUser_NullOptionalFields failed: BirthDate should be DBNull");
            }
        }

        private void Test_UpdateUser_ValidUser()
        {
            var user = new UserModel
            {
                UserID = 1,
                UserName = "updateduser",
                FullName = "Updated User",
                Email = "update@example.com",
                Password = "newpass",
                Role = "Admin",
                Phone = "1112223333",
                Address = "789 Update Ln",
                Gender = "M",
                BirthDate = new DateTime(1990, 5, 10),
                Age = 34,
                CreatedBy = 3,
                SupervisedBy = 4
            };

            int result = ExecuteWithFakeDb(() => UserManager.UpdateUser(user));

            if (result != 1)
            {
                throw new Exception($"Test_UpdateUser_ValidUser failed: Expected 1 row affected, got {result}");
            }
            if (!_fakeDbHelper.LastQuery.Contains("UPDATE Users SET"))
            {
                throw new Exception("Test_UpdateUser_ValidUser failed: Incorrect SQL query");
            }
        }

        private void Test_DeleteUser_ValidId()
        {
            int userId = 5;
            int result = ExecuteWithFakeDb(() => UserManager.DeleteUser(userId));

            if (result != 1)
            {
                throw new Exception($"Test_DeleteUser_ValidId failed: Expected 1 row affected, got {result}");
            }
            if (!_fakeDbHelper.LastQuery.Contains("DELETE FROM Users"))
            {
                throw new Exception("Test_DeleteUser_ValidId failed: Incorrect SQL query");
            }
        }

        private T ExecuteWithFakeDb<T>(Func<T> action)
        {
            return action(); // Assumes fake replaces static call conceptually
        }
    }
}
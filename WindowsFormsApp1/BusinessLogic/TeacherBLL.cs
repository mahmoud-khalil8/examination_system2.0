using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Models;

namespace ADMIN.BusinessLogicLayer
{
    public class TeacherBLL
    {
        // View All Teachers
        public static DataTable GetAllTeachers()
        {
            string query = "SELECT UserID, UserName, FullName, Email, Password, Phone, Address, Gender, BirthDate, Age FROM Users WHERE Role='Teacher'";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // Get Teacher By ID
        public static DataTable GetTeacherById(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid User ID");

            string query = "SELECT * FROM Users WHERE UserID = @UserID AND Role='Teacher'";
            SqlParameter[] parameters = { new SqlParameter("@UserID", id) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // Add New Teacher
        public static int AddTeacher(UserModel teacher)
        {
            string checkQuery = "select count(*) from Users where Email =@Email and Role = 'Teacher'";

            SqlParameter[] sqlParameters = { new SqlParameter("@Email", teacher.Email) };
            int emailExists = (int)DatabaseHelper.ExecuteScalar(checkQuery, sqlParameters);
            if (emailExists > 0)
            {
                return -1;
            }

            if (string.IsNullOrEmpty(teacher.UserName) || string.IsNullOrEmpty(teacher.Email) || string.IsNullOrEmpty(teacher.Password))
                throw new Exception("UserName, Email, and Password are required");

            string query = @"INSERT INTO Users (UserName, FullName, Email, Password, Role, Phone, Address, Gender, BirthDate)
                             VALUES (@UserName, @FullName, @Email, @Password, 'Teacher', @Phone, @Address, @Gender, @BirthDate)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserName", teacher.UserName),
                new SqlParameter("@FullName", teacher.FullName),
                new SqlParameter("@Email", teacher.Email),
                new SqlParameter("@Password", teacher.Password),
                new SqlParameter("@Phone", teacher.Phone ?? (object)DBNull.Value),
                new SqlParameter("@Address", teacher.Address ?? (object)DBNull.Value),
                new SqlParameter("@Gender", teacher.Gender ?? (object)DBNull.Value),
                new SqlParameter("@BirthDate", teacher.BirthDate ?? (object)DBNull.Value)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // Update Teacher
        public static bool UpdateTeacher(UserModel teacher)
        {
            if (teacher.UserID <= 0)
                throw new ArgumentException("Invalid User ID");

            string query = @"UPDATE Users SET FullName = @FullName, Email = @Email, Password = @Password, UserName = @UserName,
                             Address = @Address, Gender = @Gender, BirthDate = @BirthDate, Phone = @Phone
                             WHERE UserID = @UserID AND Role = 'Teacher'";

            SqlParameter[] parameters =
            {
                new SqlParameter("@FullName", teacher.FullName),
                new SqlParameter("@Email", teacher.Email),
                new SqlParameter("@Password", teacher.Password),
                new SqlParameter("@Phone", teacher.Phone ?? (object)DBNull.Value),
                new SqlParameter("@BirthDate", teacher.BirthDate ?? (object)DBNull.Value),
                new SqlParameter("@UserName", teacher.UserName),
                new SqlParameter("@Address", teacher.Address ?? (object)DBNull.Value),
                new SqlParameter("@Gender", teacher.Gender ?? (object)DBNull.Value),
                new SqlParameter("@UserID", teacher.UserID)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete Teacher
        public static bool DeleteTeacher(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid User ID");

            string query = "DELETE FROM Users WHERE UserID = @UserID AND Role='Teacher'";
            SqlParameter[] parameters = { new SqlParameter("@UserID", id) };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}

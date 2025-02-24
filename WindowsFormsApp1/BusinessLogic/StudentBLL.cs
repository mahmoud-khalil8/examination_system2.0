using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Models;

namespace ADMIN.BusinessLogicLayer
{
    public class StudentBLL
    {
        // Get All Students
        public static DataTable GetAllStudents()
        {
            string query = @"SELECT UserID, UserName, FullName AS StudentName, Email, Password, Phone, Address, Gender, BirthDate, Age
                            FROM Users WHERE Role = 'Student'";
            return DatabaseHelper.ExecuteQuery(query);
        }

        // Get Student by ID
        public static DataTable GetStudentById(int userId)
        {
            string query = "SELECT * FROM Users WHERE UserID = @UserID AND Role = 'Student'";
            SqlParameter[] parameters = { new SqlParameter("@UserID", userId) };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        // Create New Student
        public static int CreateStudent(UserModel student)
        {
            string checkQuery = "select count(*) from Users where Email =@Email and Role = 'Student'";

            SqlParameter[] sqlParameters = { new SqlParameter("@Email", student.Email) };
            int emailExists = (int)DatabaseHelper.ExecuteScalar(checkQuery, sqlParameters);
            if (emailExists > 0)
            {
                return -1;
            }
            if (string.IsNullOrEmpty(student.UserName) || string.IsNullOrEmpty(student.Email) || string.IsNullOrEmpty(student.Password))
                throw new Exception("UserName, Email, and Password are required");

            string query = @"INSERT INTO Users (UserName, FullName, Email, Password, Role, Phone, Address, Gender, BirthDate)
                             VALUES (@UserName, @FullName, @Email, @Password, @Role, @Phone, @Address, @Gender, @BirthDate)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@UserName", student.UserName),
                new SqlParameter("@FullName", student.FullName),
                new SqlParameter("@Email", student.Email),
                new SqlParameter("@Password", student.Password),
                new SqlParameter("@Role", "Student"),
                new SqlParameter("@Phone", student.Phone),
                new SqlParameter("@Address", student.Address),
                new SqlParameter("@Gender", student.Gender),
                new SqlParameter("@BirthDate", (object)student.BirthDate ?? DBNull.Value)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        // Update Student
        public static bool UpdateStudent(UserModel student)
        {
            string query = @"UPDATE Users SET 
                                FullName = @FullName, 
                                Email = @Email, 
                                Password = @Password, 
                                UserName = @UserName, 
                                Address = @Address, 
                                Gender = @Gender, 
                                BirthDate = @BirthDate, 
                                Phone = @Phone
                             WHERE UserID = @UserID AND Role = 'Student'";

            SqlParameter[] parameters =
            {
                new SqlParameter("@FullName", student.FullName),
                new SqlParameter("@Email", student.Email),
                new SqlParameter("@Password", student.Password),
                new SqlParameter("@Phone", student.Phone),
                new SqlParameter("@BirthDate", student.BirthDate),
                new SqlParameter("@UserName", student.UserName),
                new SqlParameter("@Address", student.Address),
                new SqlParameter("@Gender", student.Gender),
                new SqlParameter("@UserID", student.UserID)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete Student
        public static bool DeleteStudent(int userId)
        {
            string query = "DELETE FROM Users WHERE UserID = @UserID AND Role = 'student'";
            SqlParameter[] parameters = { new SqlParameter("@UserID", userId) };
            return DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;
        }

    }
}

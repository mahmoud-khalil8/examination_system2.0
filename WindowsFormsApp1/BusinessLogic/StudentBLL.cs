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
            //Check if Email is repeated 
            string checkQuery = "select count(*) from Users where Email =@Email ";

            SqlParameter[] sqlParameters = { new SqlParameter("@Email", student.Email) };
            int emailExists = (int)DatabaseHelper.ExecuteScalar(checkQuery, sqlParameters);
            if (emailExists > 0)
            {
                return -1;
            }
            if (string.IsNullOrEmpty(student.UserName) || string.IsNullOrEmpty(student.Email) || string.IsNullOrEmpty(student.Password))
                throw new Exception("UserName, Email, and Password are required");

            //Insert Query
            string query = @"INSERT INTO Users (UserName, FullName, Email, Password, Role, Phone, Address, Gender, BirthDate)
                             VALUES (@UserName, @FullName, @Email, @Password, @Role, @Phone, @Address, @Gender, @BirthDate) SELECT SCOPE_IDENTITY()";

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
            int studentId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(query, parameters));

            //Insert subject and link it to student
            if (student.Subjects != null && student.Subjects.Count > 0)
            {
                foreach (string subjectName in student.Subjects)
                {
                    // Check if the subject already exists
                    string checkSubjectQuery = "SELECT Sub_ID FROM Subject WHERE Subject_Name = @Subject_Name";
                    SqlParameter[] subjectParam = { new SqlParameter("@Subject_Name", subjectName) };
                    object subjectIdObj = DatabaseHelper.ExecuteScalar(checkSubjectQuery, subjectParam);

                    int subjectId;
                    if (subjectIdObj == null || subjectIdObj == DBNull.Value) // Subject doesn't exist
                    {
                        // Insert new subject
                        string insertSubjectQuery = "INSERT INTO Subject (Subject_Name) VALUES (@Subject_Name); SELECT SCOPE_IDENTITY();";
                        subjectId = Convert.ToInt32(DatabaseHelper.ExecuteScalar(insertSubjectQuery, subjectParam));
                    }
                    else
                    {
                        subjectId = Convert.ToInt32(subjectIdObj);
                    }
                    // Link student with subject
                    string insertStudentSubjectQuery = "INSERT INTO user_subject (UserId, SubjectId) VALUES (@UserId, @SubjectId)";
                    SqlParameter[] studentSubjectParams =
                    {
                       new SqlParameter("@UserId", studentId),
                       new SqlParameter("@SubjectId", subjectId)
                    };
                    DatabaseHelper.ExecuteNonQuery(insertStudentSubjectQuery, studentSubjectParams);
                }
            }

            return studentId;
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
            bool updated = DatabaseHelper.ExecuteNonQuery(query, parameters) > 0;

            string deleteSubjectsQuery = "DELETE FROM user_subject WHERE UserID = @UserID";
            SqlParameter[] deleteParam = { new SqlParameter("@UserID", student.UserID) };
            DatabaseHelper.ExecuteNonQuery(deleteSubjectsQuery, deleteParam);
            if (student.Subjects != null)
            {
                foreach (string subjectName in student.Subjects)
                {

                    string insertSubjectQuery = @"
            IF NOT EXISTS (SELECT 1 FROM Subject WHERE Subject_Name = @Subject_Name)
            BEGIN
                INSERT INTO Subject (Subject_Name) OUTPUT INSERTED.Sub_ID VALUES (@Subject_Name)
            END
            ELSE
            BEGIN
                SELECT Sub_ID FROM Subject WHERE Subject_Name = @Subject_Name
            END";

                    SqlParameter[] subjectParam = { new SqlParameter("@Subject_Name", subjectName) };
                    object result = DatabaseHelper.ExecuteScalar(insertSubjectQuery, subjectParam);

                    if (result != null && int.TryParse(result.ToString(), out int subjectId))
                    {

                        string insertStudentSubjectQuery = "INSERT INTO user_subject (UserID, SubjectID) VALUES (@UserID, @SubjectID)";
                        SqlParameter[] studentSubjectParams =
                        {
                new SqlParameter("@UserID", student.UserID),
                new SqlParameter("@SubjectID", subjectId)
            };
                        DatabaseHelper.ExecuteNonQuery(insertStudentSubjectQuery, studentSubjectParams);
                    }
                }
            }

            return updated;
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.BusinessLogic.Admin
{
    public class UserManager
    {
        public static int CreateUser(UserModel user)
        {
            string query = @"INSERT INTO Users (UserName, FullName, Email, Password, Role, Phone, Address, Gender, BirthDate, Age, created_by, supervised_by)
                             VALUES (@UserName, @FullName, @Email, @Password, @Role, @Phone, @Address, @Gender, @BirthDate, @Age, @CreatedBy, @SupervisedBy)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@FullName", user.FullName),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Role", user.Role),
                new SqlParameter("@Phone", user.Phone),
                new SqlParameter("@Address", user.Address),
                new SqlParameter("@Gender", user.Gender),
                new SqlParameter("@BirthDate", (object)user.BirthDate ?? DBNull.Value),
                new SqlParameter("@Age", (object)user.Age ?? DBNull.Value),
                new SqlParameter("@CreatedBy", (object)user.CreatedBy ?? DBNull.Value),
                new SqlParameter("@SupervisedBy", (object)user.SupervisedBy ?? DBNull.Value)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public static int UpdateUser(UserModel user)
        {
            string query = @"UPDATE Users SET 
                                UserName = @UserName,
                                FullName = @FullName,
                                Email = @Email,
                                Password = @Password,
                                Role = @Role,
                                Phone = @Phone,
                                Address = @Address,
                                Gender = @Gender,
                                BirthDate = @BirthDate,
                                Age = @Age,
                                created_by = @CreatedBy,
                                supervised_by = @SupervisedBy
                             WHERE UserID = @UserID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", user.UserID),
                new SqlParameter("@UserName", user.UserName),
                new SqlParameter("@FullName", user.FullName),
                new SqlParameter("@Email", user.Email),
                new SqlParameter("@Password", user.Password),
                new SqlParameter("@Role", user.Role),
                new SqlParameter("@Phone", user.Phone),
                new SqlParameter("@Address", user.Address),
                new SqlParameter("@Gender", user.Gender),
                new SqlParameter("@BirthDate", (object)user.BirthDate ?? DBNull.Value),
                new SqlParameter("@Age", (object)user.Age ?? DBNull.Value),
                new SqlParameter("@CreatedBy", (object)user.CreatedBy ?? DBNull.Value),
                new SqlParameter("@SupervisedBy", (object)user.SupervisedBy ?? DBNull.Value)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public static int DeleteUser(int userId)
        {
            string query = "DELETE FROM Users WHERE UserID = @UserID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", userId)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
    }
}

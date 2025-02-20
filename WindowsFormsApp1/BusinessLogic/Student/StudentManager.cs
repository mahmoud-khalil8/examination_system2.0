using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BusinessLogic
{
    public class StudentManager
    {

        public static DataTable getStudent(string email,string password)
        {
            string query = "select * from users where Email=@email and password=@password";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@email",email),
                new SqlParameter("@password",password)

            };
            return DataAccess.DatabaseHelper.ExecuteQuery(query, param);

        }
        
    }
}

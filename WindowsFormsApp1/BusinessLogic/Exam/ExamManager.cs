using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.BusinessLogic
{
    public class ExamManager
    {
        public static DataTable GetExams()
        {
            return DataAccess.DatabaseHelper.ExecuteQuery("SELECT * FROM Exam");
        }
        public static int AddExam(string name, int marks)
        {
            string query = "INSERT INTO Exam(name,marks) VALUES(@name,@marks)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@name",name),
                new SqlParameter("@marks",marks)
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }
        public static DataTable getUserPracticeExam(int userId)
        {
            string query = "select exam.* from Users join Exam on Exam.Teacher_ID=users.supervised_by  where users.UserID=@userid  and ExamType='Practice';";

            SqlParameter[] parameters =
            {
                new SqlParameter("@userid",userId)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        public static DataTable getExamQuestions(int examId)
        {
            string query = "select * from Questions where Exam_ID=@examid";
            SqlParameter[] parameters =
            {
                new SqlParameter("@examid",examId)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);

        }
        public static DataTable getQuestionOptions(int questionId) {
            string query = "select * from ques_options where QID=@questionid";
            SqlParameter[] parameters =
            {
                new SqlParameter("@questionid",questionId)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        public static bool ValidateAnswer(int questionId, string studentAnswer)
        {
            DataTable correctAnswers = GetCorrectAnswers(questionId);
            // Check single correct answer
            if (correctAnswers.Rows.Count == 1)
            {

                return correctAnswers.Rows[0]["correctAnswer"].ToString() == studentAnswer;
            }
            else if (correctAnswers.Rows.Count > 1)
            {
                // Multi-choice question
                HashSet<string> correctSet = new HashSet<string>(
                    correctAnswers.AsEnumerable().Select(row => row["correctAnswer"].ToString().Trim())
                );

                HashSet<string> studentSet = new HashSet<string>(
                    studentAnswer.Split(',').Select(answer => answer.Trim())
                );

                return correctSet.SetEquals(studentSet);
            }

            return false;

        }

        public static DataTable getSubjects(int examId)
        {

            string query = "SELECT * FROM Subject s join Exam e on s.sub_id=e.subject_id where e.Exam_ID=@examId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@examId", examId)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        public static DataTable GetCorrectAnswers(int questionId)
        {
            string query = "SELECT options as correctAnswer FROM Question_CorrectAns qc  join Ques_Options q" +
                " on q.option_index=qc.CorrectAnswer and q.QID=qc.QID where q.QID=@questionId; ";
            SqlParameter[] parameters =
            {
                new SqlParameter("@questionId", questionId)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        public static DataTable getQuestionMarks(int questionId)
        {
            string query = "SELECT marks FROM questions where QID=@questionId; ";
            SqlParameter[] parameters =
            {
                new SqlParameter("@questionId", questionId)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public static int saveExamStudent(int studentId,int examId,int studentMarks)
        {

            string query = "INSERT INTO STUD_EXAM (Stud_ID, Exam_ID, student_marks) VALUES (@StudentID, @ExamID, @student_marks)";
            SqlParameter[] parameters =
            {
                new SqlParameter("@StudentID", studentId),
                new SqlParameter("@ExamID", examId),
                new SqlParameter("@student_marks", studentMarks),
            };
            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public static void StoreStudentAnswer(
            int studId,
            int examId,
            int quesId,
            string answer,
            bool isCorrect,
            int? studMarks)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@Stud_ID", studId),
            new SqlParameter("@Exam_ID", examId),
            new SqlParameter("@Ques_ID", quesId),
            new SqlParameter("@Answer", answer ?? (object)DBNull.Value),
            new SqlParameter("@IsCorrect", isCorrect),
            new SqlParameter("@Stud_Marks", studMarks ?? (object)DBNull.Value)
            };

            DatabaseHelper.ExecuteStoredProcedure("StoreStudentAnswer", parameters);
        }




        public static DataTable GetAvailableExams(string examType)
        {
            string query = "SELECT *  FROM Exam WHERE ExamType = @ExamType AND Mode IN ('Queued', 'Started')";
            SqlParameter[] parameters =
            {
               new SqlParameter("@ExamType", examType)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        public static DataTable checkExamTaken(int studentId, int examId)
        {
            string query = "SELECT * FROM STUD_EXAM WHERE Stud_ID = @StudentID AND Exam_ID = @ExamID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@StudentID", studentId),
                new SqlParameter("@ExamID", examId)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public static DataTable getFinalExam(int examId)
        {
            string query = "SELECT * FROM Exam WHERE Exam_ID = @ExamID";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ExamID", examId)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        public static DataTable getStudent(string email, string password)
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

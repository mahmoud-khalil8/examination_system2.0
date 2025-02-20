using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.DataAccess;

namespace WindowsFormsApp1.BusinessLogic.Teacher
{
    public class TeacherManager
    {
        public DataRow GetTeacherById(int teacherId)
        {
            string sql = "SELECT * FROM Users WHERE UserID = @TeacherID AND Role = 'Teacher'";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@TeacherID", teacherId)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(sql, parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public DataRow GetQuestionById(int questionId)
        {
            string sql = "SELECT * FROM Questions WHERE QID = @QuestionID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@QuestionID", questionId)
            };

            DataTable dt = DatabaseHelper.ExecuteQuery(sql, parameters);
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

        public bool DeleteQuestion(int questionId)
        {
            string sql = "DELETE FROM Questions WHERE QID = @QuestionID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@QuestionID", questionId)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(sql, parameters);
            return rows > 0;
        }

        public bool UpdateQuestion(QuestionModel question)
        {
            string sql = @"UPDATE Questions SET 
                            Header = @Header, 
                            Body = @Body, 
                            QType = @QType, 
                            Marks = @Marks, 
                            Teacher_ID = @TeacherID, 
                            Exam_ID = @ExamID
                           WHERE QID = @QID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Header", question.Header),
                new SqlParameter("@Body", question.Body),
                new SqlParameter("@QType", question.QType),
                new SqlParameter("@Marks", (object)question.Marks ?? DBNull.Value),
                new SqlParameter("@TeacherID", question.Teacher_ID),
                new SqlParameter("@ExamID", question.Exam_ID),
                new SqlParameter("@QID", question.QID)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(sql, parameters);
            return rows > 0;
        }

        public bool UpdateOptions(int questionId, List<OptionModel> options)
        {
            // Begin a transaction manually since DatabaseHelper doesn't provide one
            SqlConnection conn = DatabaseHelper.GetConnection();
            SqlTransaction transaction = conn.BeginTransaction();
            try
            {
                // Delete existing options
                string deleteSql = "DELETE FROM Ques_Options WHERE QID = @QuestionID";
                using (SqlCommand deleteCmd = new SqlCommand(deleteSql, conn, transaction))
                {
                    deleteCmd.Parameters.Add(new SqlParameter("@QuestionID", questionId));
                    deleteCmd.ExecuteNonQuery();
                }

                // Insert new options
                string insertSql = "INSERT INTO Ques_Options (QID, Options) VALUES (@QuestionID, @OptionText)";
                foreach (var option in options)
                {
                    using (SqlCommand insertCmd = new SqlCommand(insertSql, conn, transaction))
                    {
                        insertCmd.Parameters.Add(new SqlParameter("@QuestionID", questionId));
                        insertCmd.Parameters.Add(new SqlParameter("@OptionText", option.Options));
                        insertCmd.ExecuteNonQuery();
                    }
                }

                transaction.Commit();
                return true;
            }
            catch
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool UpdateAnswer(AnswerModel answer)
        {
            string sql = @"UPDATE Answers SET 
                            ISCorrect = @ISCorrect, 
                            Stud_Marks = @Stud_Marks, 
                            Ques_ID = @Ques_ID
                           WHERE Ans_ID = @Ans_ID";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@ISCorrect", answer.ISCorrect),
                new SqlParameter("@Stud_Marks", (object)answer.Stud_Marks ?? DBNull.Value),
                new SqlParameter("@Ques_ID", answer.Ques_ID),
                new SqlParameter("@Ans_ID", answer.Ans_ID)
            };

            int rows = DatabaseHelper.ExecuteNonQuery(sql, parameters);
            return rows > 0;
        }
    }
}
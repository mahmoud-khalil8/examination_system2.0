using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccess;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using WindowsFormsApp1.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Windows.Forms;

namespace WindowsFormsApp1.BusinessLogic
{
    public class TeacherBL
    {

        public static DataTable GetTeacherName(int TeacherId)
        {
            string query = " SELECT u.FullName From Users u Where UserID =@TeacherId AND Role = 'Teacher'";

            SqlParameter[] parameters = {
                new SqlParameter("@TeacherId", TeacherId)
                  };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        public static DataTable GetAllQuestions(int TeacherId)
        {
            string query = @"SELECT q.QID, q.Header, q.Body,q.Exam_ID, e.ExamName,
                                 (SELECT STRING_AGG(qo.Options, ', ') FROM Ques_Options qo 
	                             WHERE q.QID = qo.QID) AS Options,STRING_AGG(qo.Options, ', ') AS [Correct Answer],
                                 q.Marks
                                 FROM Questions q JOIN Question_CorrectAns qc 
                                 ON q.QID = qc.QID
                                 JOIN Ques_Options qo 
                                 ON q.QID = qo.QID AND qo.Option_Index = qc.CorrectAnswer
                                 JOIN Exam e 
                                 ON e.Exam_ID = q.Exam_ID
								 WHERE e.Teacher_ID=@TeacherId
                                 GROUP BY q.QID,q.Header, q.Body, e.ExamName, q.Marks, q.QID,q.Exam_ID
                                 ORDER BY q.QID";

            SqlParameter[] parameters = {
                new SqlParameter("@TeacherId", TeacherId)
                  };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public static int GetTotalAllowedMarksForExam(int examid)
        {
            string query = "SELECT e.Exam_Marks AS TotalAllowedMarks FROM Exam e WHERE e.Exam_ID=@examid";
            SqlParameter[] parameters = { new SqlParameter("@examid", examid) };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0 && result.Rows[0]["TotalAllowedMarks"] != DBNull.Value)
            {
                return Convert.ToInt32(result.Rows[0]["TotalAllowedMarks"]);
            }

            return 0;
        }

        public static int GetCurrentTotalMarksForExam(int examid)
        {
            string query = "SELECT SUM(q.Marks) AS CurrentTotalMarks FROM Questions q WHERE q.Exam_ID=@examid";
            SqlParameter[] parameters = { new SqlParameter("@examid", examid) };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0 && result.Rows[0]["CurrentTotalMarks"] != DBNull.Value)
            {
                return Convert.ToInt32(result.Rows[0]["CurrentTotalMarks"]);
            }

            return 0;
        }

        public static DataTable GetAllQueationsById(int examid, int TeacherId)
        {
            string query = @"SELECT q.QID,q.Header, q.Body,q.Exam_ID, e.ExamName,
                             (SELECT STRING_AGG(qo.Options, ', ') FROM Ques_Options qo 
	                         WHERE q.QID = qo.QID) AS Options,STRING_AGG(qo.Options, ', ') AS [Correct Answer],
                             q.Marks
                             FROM Questions q
                             JOIN Question_CorrectAns qc 
                             ON q.QID = qc.QID
                             JOIN Ques_Options qo 
                             ON q.QID = qo.QID AND qo.Option_Index = qc.CorrectAnswer
                             JOIN Exam e 
                             ON e.Exam_ID = q.Exam_ID
                             WHERE q.Exam_ID = @examid AND e.Teacher_ID=@TeacherId
                             GROUP BY q.QID,q.Header, q.Body, e.ExamName, q.Marks, q.QID,q.Exam_ID
                             ORDER BY q.QID";

            SqlParameter[] parameters = {
                new SqlParameter("@examid", examid),
                new SqlParameter("@TeacherId",TeacherId)
                  };
            return DatabaseHelper.ExecuteQuery(query, parameters);

        }

        public static int DeleteQuestion(int qid, int examid, int TeacherId)
        {
            string query = @"DELETE FROM Question_CorrectAns WHERE QID = @qid ;
                             DELETE FROM Ques_Options WHERE QID = @qid;
                             DELETE FROM Questions WHERE QID = @qid AND Exam_ID = @examid and Teacher_ID=@TeacherId;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@examid", examid),
                new SqlParameter("@qid",qid),
                new SqlParameter("@TeacherId",TeacherId)
            };

            return DatabaseHelper.ExecuteNonQuery(query, parameters);
        }

        public static DataTable GetQuestionsId(int examid, int TeacherId)
        {
            string query = "select distinct QID from Questions where Exam_ID = @examid And Teacher_ID=@TeacherId";
            SqlParameter[] parameters = {
                new SqlParameter("@examid", examid),
                new SqlParameter ("@TeacherId",TeacherId)
                  };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public static DataTable GetAllExamsID(int TeacherId)
        {
            string query = "select distinct q.Exam_ID from Exam e inner join Questions q on e.Exam_ID=q.Exam_ID WHERE e.Teacher_ID=@TeacherId";
            SqlParameter[] parameters = {
                new SqlParameter("@TeacherId",TeacherId)
                  };
            return DatabaseHelper.ExecuteQuery(query, parameters);

        }

        public static DataTable GetQuestionByExIdAndQId(int examid, int Qid)
        {
            string query = @"SELECT q.QID, q.Header, q.Body, q.QType, q.Marks, q.Teacher_ID, q.Exam_ID, CorrectAnswers.CorrectAnswer, Options.Options, OptionIndices.Option_Index
                             FROM Questions q
                             JOIN (
                             SELECT QID, STRING_AGG(CAST(CorrectAnswer AS VARCHAR), ',') AS CorrectAnswer
                             FROM Question_CorrectAns
                             GROUP BY QID) AS CorrectAnswers ON q.QID = CorrectAnswers.QID
                             JOIN (SELECT QID, STRING_AGG(Options, ',') AS Options
                             FROM Ques_Options
                             GROUP BY QID) AS Options ON q.QID = Options.QID
                             JOIN (SELECT QID, STRING_AGG(CAST(Option_Index AS VARCHAR), ',') AS Option_Index
                             FROM Ques_Options
                             GROUP BY QID) AS OptionIndices ON q.QID = OptionIndices.QID
                             WHERE q.Exam_ID = @examid AND q.QID = @Qid;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@examid", examid),
                new SqlParameter("@Qid",Qid)
            };

            return DataAccess.DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public static int UpdateQuestion(int qid, int examid, string header, string body, string qtype, int? marks, List<int> correctAnswers, List<string> options, List<int> optionIndexes)
        {
            string query = @"UPDATE Questions 
                             SET Header = @Header, Body = @Body, QType = @QType, Marks = @Marks
                             WHERE QID = @QID AND Exam_ID = @ExamID;";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                  new SqlParameter("@QID", qid),
                  new SqlParameter("@ExamID", examid),
                  new SqlParameter("@Header", header),
                  new SqlParameter("@Body", body),
                  new SqlParameter("@QType", qtype),
                  new SqlParameter("@Marks", marks ?? (object)DBNull.Value),
            };

            query += "DELETE FROM Question_CorrectAns WHERE QID = @QID;";

            for (int i = 0; i < correctAnswers.Count; i++)
            {
                query += "INSERT INTO Question_CorrectAns (QID, CorrectAnswer) VALUES (@QID, @CorrectAnswer" + i + "); ";
                parameters.Add(new SqlParameter("@CorrectAnswer" + i, correctAnswers[i]));
            }

            for (int i = 0; i < options.Count; i++)
            {
                query += "UPDATE Ques_Options SET Options = @Options" + i + " WHERE QID = @QID AND Option_Index = @OptionIndex" + i + "; ";
                parameters.Add(new SqlParameter("@Options" + i, options[i]));
                parameters.Add(new SqlParameter("@OptionIndex" + i, optionIndexes[i]));
            }

            return DatabaseHelper.ExecuteNonQuery(query, parameters.ToArray());
        }

        public static bool IsQuestionModified(int qid, string header, string body, string qtype, int? marks, List<string> options, List<int> correctAnswers)
        {
            string query = "SELECT Header, Body, QType, Marks FROM Questions WHERE QID = @QID";
            SqlParameter[] parameters = { new SqlParameter("@QID", qid) };

            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count == 0)
                return true;

            DataRow row = dt.Rows[0];

            bool isModified =
                row["Header"].ToString() != header ||
                row["Body"].ToString() != body ||
                row["QType"].ToString() != qtype ||
                (row["Marks"] != DBNull.Value ? Convert.ToInt32(row["Marks"]) : (int?)null) != marks ||
                AreOptionsModified(qid, options) ||
                AreCorrectAnswersModified(qid, correctAnswers);

            return isModified;
        }

        private static bool AreOptionsModified(int qid, List<string> options)
        {
            string query = "SELECT Options FROM Ques_Options WHERE QID = @QID ORDER BY Option_Index";
            SqlParameter[] parameters = { new SqlParameter("@QID", qid) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            List<string> dbOptions = dt.AsEnumerable().Select(row => row["Options"].ToString().Trim()).ToList();

            return !dbOptions.SequenceEqual(options);
        }

        private static bool AreCorrectAnswersModified(int qid, List<int> correctAnswers)
        {
            string query = "SELECT CorrectAnswer FROM Question_CorrectAns WHERE QID = @QID ORDER BY CorrectAnswer";
            SqlParameter[] parameters = { new SqlParameter("@QID", qid) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            List<int> dbCorrectAnswers = dt.AsEnumerable().Select(row => Convert.ToInt32(row["CorrectAnswer"])).ToList();

            return !dbCorrectAnswers.SequenceEqual(correctAnswers);
        }
    }
}




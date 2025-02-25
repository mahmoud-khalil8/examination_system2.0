using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace WindowsFormsApp1.BusinessLogic
{
    internal class ViewAllStudentsUS_BL
    {
        public static DataTable GetStudentData(int teacherId)
        {
            string query = @"SELECT u.UserID as [Student ID],u.FullName as [Student Name],sx.Student_Marks as [Student Marks],e.Exam_ID as [Exam ID],e.ExamName as [Exam Name],e.Exam_Marks as [Exam Mark],e.ExamType as [Exam Type],e.Ques_Num as [Numbers Of Questions]
                             From Users u INNER JOIN STUD_EXAM sx
                             ON u.UserID = sx.Stud_ID
                             INNER JOIN Exam e
                             ON e.Exam_ID=sx.Exam_ID
                             INNER JOIN Subject s
                             ON s.Sub_ID=e.Subject_ID
                             WHERE u.supervised_by=@teacherId AND u.Role='Student'"
            ;

            SqlParameter[] parameters =
            {
                new SqlParameter("@teacherId", teacherId)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public static DataTable GetStudentDataByName(int teacherId, string StudName)
        {
            string query = @"SELECT u.UserID as [Student ID],u.FullName as [Student Name],sx.Student_Marks as [Student Marks],e.Exam_ID as [Exam ID],e.ExamName as [Exam Name],e.Exam_Marks as [Exam Mark],e.ExamType as [Exam Type],e.Ques_Num as [Numbers Of Questions]
                             From Users u INNER JOIN STUD_EXAM sx
                             ON u.UserID = sx.Stud_ID
                             INNER JOIN Exam e
                             ON e.Exam_ID=sx.Exam_ID
                             INNER JOIN Subject s
                             ON s.Sub_ID=e.Subject_ID
                             WHERE u.supervised_by=@teacherId AND u.Role='Student' AND u.FullName=@StudName"
            ;

            SqlParameter[] parameters =
            {
                new SqlParameter("@teacherId", teacherId),
                new SqlParameter("@StudName", StudName)
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public static DataTable GetStudentsName(int teacherId)
        {
            string query = @"SELECT distinct u.FullName FROM Users u WHERE u.supervised_by=@teacherId AND u.Role='Student'"
            ;

            SqlParameter[] parameters =
            {
                new SqlParameter("@teacherId", teacherId),
            };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }

        public static DataTable GetTopFive(int TeacherId)
        {
            string query = @" SELECT Top(5) u.UserID as [Student ID],u.FullName as [Student Name],sx.Student_Marks as [Student Marks],e.Exam_ID as [Exam ID],e.ExamName as [Exam Name],e.Exam_Marks as [Exam Mark],e.ExamType as [Exam Type],e.Ques_Num as [Numbers Of Questions]
                              From Users u INNER JOIN STUD_EXAM sx
                              ON u.UserID = sx.Stud_ID
                              INNER JOIN Exam e
                              ON e.Exam_ID=sx.Exam_ID
                              Inner join Subject s
                              ON s.Sub_ID=e.Subject_ID
                              WHERE u.supervised_by=@TeacherId AND u.Role='Student'
                              Group By e.Exam_ID,u.UserID,u.FullName,sx.Student_Marks,e.ExamName,e.Exam_Marks,e.Ques_Num,e.ExamType
                              order by e.Exam_ID";

            SqlParameter[] parameters = {
                new SqlParameter("@TeacherId", TeacherId)
                  };
            return DatabaseHelper.ExecuteQuery(query, parameters);
        }
        //------------------------------------------------------------------------------------------------
        public static DataTable GetFullName(int examID, int studentID)
        {
            var fullName = DatabaseHelper.ExecuteQuery($"select FullName from Users where UserID = {studentID}");
            return fullName;
        }
        public static DataTable GetSubjectName(int examID, int studentID,int teacherId)
        {
            var subjectName = DatabaseHelper.ExecuteQuery($"select Subject_Name from Subject s,Exam e where e.Subject_ID = s.Sub_ID and s.Teacher_ID = {teacherId} and e.Exam_ID = {examID}");
            return subjectName;
        }
        public static DataTable GetTotalMarks(int examID, int studentID)
        {
            var totalMarks = DatabaseHelper.ExecuteQuery($"select Exam_Marks from Exam where Exam_ID = {examID}");
            return totalMarks;
        }
        public static DataTable GetStudentMarks(int examID, int studentID)
        {
            var studentMarks = DatabaseHelper.ExecuteQuery($"select Student_Marks from Stud_Exam where Exam_ID = {examID} and Stud_ID = {studentID}");
            return studentMarks;
        }
        public static DataTable GetExamName(int examID, int studentID)
        {
            var examName = DatabaseHelper.ExecuteQuery($"select ExamName from Exam where Exam_ID = {examID}");
            return examName;
        }
        public static DataTable GetExamType(int examID, int studentID)
        {
            var examType = DatabaseHelper.ExecuteQuery($"select ExamType from Exam where Exam_ID = {examID}");
            return examType;
        }
        public static DataTable GetQuestionsAndCorrectAnswer(int examID, int studentID)
        {
            var questionssAndCorrectAnswer = DatabaseHelper.ExecuteQuery($@"SELECT 
                                            q.QID, 
                                            q.Header, 
                                            q.Body, 
                                            STRING_AGG(qo.Options, ' + ') AS CorrectAnswers 
                                        FROM Questions q
                                        JOIN Exam e ON q.Exam_ID = e.Exam_ID
                                        JOIN Question_CorrectAns qca ON q.QID = qca.QID
                                        JOIN Stud_Exam se ON se.Exam_ID = e.Exam_ID
                                        JOIN Users u ON se.Stud_ID = u.UserID
                                        JOIN Ques_Options qo ON q.QID = qo.QID  
                                            AND qca.CorrectAnswer = qo.Option_Index  
                                        WHERE e.Exam_ID = {examID} 
                                        AND u.UserID = {studentID}
                                        GROUP BY q.QID, q.Header, q.Body;
                                        ");
            return questionssAndCorrectAnswer;
        }
        public static DataTable GetOptions(int examID, int studentID)
        {
            var options = DatabaseHelper.ExecuteQuery($@"SELECT 
                                q.QID, 
                                STRING_AGG(qo.Options, ' + ') AS Options
                            FROM Questions q
                            JOIN Ques_Options qo ON q.QID = qo.QID
                            JOIN Exam e ON q.Exam_ID = e.Exam_ID
                            JOIN Stud_Exam se ON se.Exam_ID = e.Exam_ID
                            JOIN Users u ON se.Stud_ID = u.UserID
                            WHERE e.Exam_ID = {examID}
                            AND u.UserID = {studentID}
                            GROUP BY q.QID;
                            ");
            return options;
        }
        public static DataTable GetStudentAnswers(int examID, int studentID)
        {
            var studentAnswers = DatabaseHelper.ExecuteQuery($@"SELECT 
                        a.Ans_ID, 
                        a.Ques_ID, 
                        STRING_AGG(sa.Answer, ' + ') AS Answer 
                    FROM Answers a
                    INNER JOIN Student_Answer sa ON a.Ans_ID = sa.Ans_ID
                    INNER JOIN Stud_Exam_Ans sea ON sea.Ans_ID = a.Ans_ID
                    INNER JOIN Exam e ON e.Exam_ID = sea.Exam_ID
                    INNER JOIN Users u ON u.UserID = sea.Stud_ID
                    WHERE sea.Exam_ID = {examID}
                    AND u.UserID = {studentID}
                    GROUP BY a.Ans_ID, a.Ques_ID;
                    ");
            return studentAnswers;
        }
    }
}

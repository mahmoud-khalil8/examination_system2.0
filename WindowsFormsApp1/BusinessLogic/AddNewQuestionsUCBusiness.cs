using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.BusinessLogic
{
    internal class AddNewQuestionsUCBusiness
    {
        public static DataTable GetExams(int id)
        {
            MessageBox.Show(id.ToString());
            var x = DatabaseHelper.ExecuteQuery($"SELECT * FROM Exam where Teacher_ID ={id}");
            return x;
        }
        public static DataTable GetCurrentExam(int id )
        {
            var x = DatabaseHelper.ExecuteQuery($"SELECT * FROM Exam where Teacher_ID ={id} and Exam_id = {TeacherDashoard.CurrentExamID}");
            return x;
        }
        public static DataTable GetExamQuestions(int id )
        {
            var x = DatabaseHelper.ExecuteQuery($"SELECT * FROM Questions where Teacher_ID ={id} and Exam_id = {TeacherDashoard.CurrentExamID}");
            return x;
        }
        public static int InsertQuestion(QuestionModel q)
        {
            var x = DatabaseHelper.ExecuteNonQuery($"insert into Questions (Header,Body,QType,Marks,Teacher_ID,Exam_ID)" +
                                                    $"values('{q.Header}','{q.Body}','{q.QType}',{q.Marks},{q.Teacher_ID},{q.Exam_ID})");
            return x;
        }
        public static int GetQID()
        {
            var x = DatabaseHelper.ExecuteQuery($"SELECT MAX(QID) FROM Questions");
            return Convert.ToInt32(x.Rows[0][0]);
        }
        public static int InsertOptions(QuestionModel q)
        {
            


            int x = 0;
            for (int i = 0; i < q.Options.Count; i++)
            {
                x = DatabaseHelper.ExecuteNonQuery($"INSERT INTO Ques_Options (QID, Options, Option_Index) " +
                                                   $"VALUES ({q.QID}, '{q.Options[i]}', {q.Option_Index[i]})");
            }
            return x;
        }

        public static int InsertCorrectAnswer(QuestionModel q)
        {
            if (q.GetType() == typeof(TrueFalseQuestion))
            {
                var x = DatabaseHelper.ExecuteNonQuery($"insert into Question_CorrectAns (QID,CorrectAnswer)" +
                                                    $"values({q.QID},{((TrueFalseQuestion)q).CorrectAnswer})");
                return x;
            }
            else if (q.GetType() == typeof(ChooseOneQuestion))
            {
                var x = DatabaseHelper.ExecuteNonQuery($"insert into Question_CorrectAns (QID,CorrectAnswer)" +
                                                    $"values({q.QID},{((ChooseOneQuestion)q).CorrectAnswer})");
                return x;
            }
            else if (q.GetType() == typeof(ChooseAllQuestion))
            {
                int x = 0;
                for (int i = 0; i < ((ChooseAllQuestion)q).CorrectAnswer.Count; i++)
                {
                    x = DatabaseHelper.ExecuteNonQuery($"insert into Question_CorrectAns (QID,CorrectAnswer)" +
                                                    $"values({q.QID},{((ChooseAllQuestion)q).CorrectAnswer[i]})");
                }
                return x;
            }
            return 0;
        }
        public static int GetNumberOfQuestionsAdded(int id )
        {
            var x = (int)DatabaseHelper.ExecuteQuery($"SELECT COUNT(QID) as count FROM Questions where Teacher_ID ={id} and Exam_id = {TeacherDashoard.CurrentExamID}").Rows[0]["count"];
            return x;
        }
        public static int GetNumberOfQuestionsInExam(int id )
        {
            var x = (int)DatabaseHelper.ExecuteQuery($"SELECT Ques_Num FROM Exam where Teacher_ID ={id} and Exam_id = {TeacherDashoard.CurrentExamID}").Rows[0]["Ques_Num"];
            return x;

        }
        public static int UpdateTotalMarks(int id )
        {
            var x = DatabaseHelper.ExecuteNonQuery($"update Exam set Exam_Marks = (select sum(Marks) from Questions where Teacher_ID ={id} and Exam_id = {TeacherDashoard.CurrentExamID}) where Teacher_ID ={id} and Exam_id = {TeacherDashoard.CurrentExamID}");
            return x;
        }
        public static int GetTotalMarks(int id)
        {
            var x = (int)DatabaseHelper.ExecuteQuery($"SELECT Exam_Marks FROM Exam where Teacher_ID ={id} and Exam_id = {TeacherDashoard.CurrentExamID}").Rows[0]["Exam_Marks"];
            return x;
        }
        public static int GetSumOfMarks(int id )
        {
           
                var result = DatabaseHelper.ExecuteQuery($"SELECT SUM(Marks) as sum FROM Questions WHERE Teacher_ID = {id} AND Exam_id = {TeacherDashoard.CurrentExamID}").Rows[0]["sum"];
                return result != DBNull.Value ? Convert.ToInt32(result) : 0;

        }
        public static int UpdateQuesNum(int id)
        {
            var x = DatabaseHelper.ExecuteNonQuery($"update Exam set Ques_Num = (select count(QID) from Questions where Teacher_ID ={id} and Exam_id = {TeacherDashoard.CurrentExamID}) where Teacher_ID ={id} and Exam_id = {TeacherDashoard.CurrentExamID}");
            return x;
        }
    }
}

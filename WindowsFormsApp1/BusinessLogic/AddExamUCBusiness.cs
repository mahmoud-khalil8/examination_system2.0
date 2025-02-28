using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataAccess;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1.BusinessLogic
{
    internal class AddExamUCBusiness
    {
        public static int InsertSubject(int id, string name)
        {
            var n = DatabaseHelper.ExecuteNonQuery($"insert into Subject(Teacher_ID, Subject_Name) values({id},'{name}')");
            return n;
        }
        public static DataTable GetSubject(string sub_name, int id)
        {
            var dt = DatabaseHelper.ExecuteQuery($"select * from Subject where subject_name = '{sub_name}' and Teacher_ID = {id}");
            return dt;
        }
        public static int InsertExam(Exam e)
        {
            var n = DatabaseHelper.ExecuteNonQuery($"insert into Exam " +
                $"values('Queued','{e.ExamType}',{e.NumberOfQuestions},{e.Marks},{e.SubjectId},{e.TeacherId},'{e.ExamName}'+' Exam','{e.Time}','{e.StartTime}')");
            return n;
        }
        public static DataTable GetExam(Exam e)
        {
            var dt = DatabaseHelper.ExecuteQuery($"select top(1) * from Exam where Teacher_ID = {e.TeacherId} order by Exam_ID desc");
            return dt;
        }
        internal static DataTable GetSubjects(int currentId)
        {
            var dt = DatabaseHelper.ExecuteQuery($"select Subject_Name from Subject where Teacher_ID = {currentId}");
            return dt;
        }
    }
}

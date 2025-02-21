using System;
using System.Collections.Generic;

namespace WindowsFormsApp1.Models
{
    public abstract class Exam
    {
        public int ExamID { get; set; }

        public TimeSpan Time { get; set; }
        public int NumberOfQuestions { get; set; }
        public string Mode { get; set; }
        public string ExamName { get; set; }
        public string ExamType { get; set; }
        public int Marks { get; set; }
        public int SubjectId { get; set; }
        public int TeacherId { get; set; }
        public DateTime StartTime { get; set; }


        public delegate void ExamStartHandler(string examName, DateTime startTime);


        public static event Action<string, DateTime> ExamStarted;

        // Method to trigger the event
        public static void NotifyExamStart(string examName, DateTime startTime)
        {
            ExamStarted?.Invoke(examName, startTime);
        }

        // Use Dictionary<int, object> to avoid object key issues (int -> QuestionID)
        public Dictionary<int, object> QuestionAnswers { get; set; }

        public Exam(TimeSpan time, int numberOfQuestions, string mode, string examName, string examType, int examID, int marks, int subjectId, int teacherId, DateTime startTime)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Mode = mode;
            ExamName = examName;
            ExamType = examType;
            ExamID = examID;
            Marks = marks;
            SubjectId = subjectId;
            TeacherId = teacherId;
            StartTime = startTime;
            QuestionAnswers = new Dictionary<int, object>(); // Prevent NullReferenceException
            NotifyExamStart(ExamName, StartTime);
        }

        public abstract void ShowExam();
    }

    public class PracticeExam : Exam
    {
        public PracticeExam(TimeSpan time, int numberOfQuestions, string mode, string examName, string examType, int examID, int marks, int subjectId, int teacherId, DateTime startTime)
            : base(time, numberOfQuestions, mode, examName, "practiceExam", examID, marks, subjectId, teacherId, startTime)
        {

        }

        public override void ShowExam()
        {
            // Display Practice Exam
        }
    }

    public class FinalExam : Exam
    {
        public FinalExam(TimeSpan time, int numberOfQuestions, string mode, string examName, string examType, int examID, int marks, int subjectId, int teacherId, DateTime startTime)
            : base(time, numberOfQuestions, mode, examName, "finalExam", examID, marks, subjectId, teacherId, startTime)
        {
        }

        public override void ShowExam()
        {
            // Display Final Exam
        }
    }
}

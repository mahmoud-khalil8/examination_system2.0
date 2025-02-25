using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp1.Models
{
    public abstract class QuestionModel
    {

        public int QID { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string QType { get; set; }
        public int? Marks { get; set; }
        public int Teacher_ID { get; set; }
        public int Exam_ID { get; set; }
        public List<string> Options { get; set; }
        public List<int> Option_Index { get; set; }

        public QuestionModel(int qid, string header, string body, string qtype, int? marks, int teacherId, int examId)
        {
            QID = qid;
            Header = header;
            Body = body;
            QType = qtype;
            Marks = marks;
            Teacher_ID = teacherId;
            Exam_ID = examId;


        }
        public QuestionModel(int qid, string header, string body, string qtype, int? marks, int teacherId, int examId, List<string> options, List<int> option_Index)
        {
            QID = qid;
            Header = header;
            Body = body;
            QType = qtype;
            Marks = marks;
            Teacher_ID = teacherId;
            Exam_ID = examId;
            Options = options;
            Option_Index = option_Index;


        }
        protected QuestionModel()
        {
            
        }
        public abstract void ShowOptions();

    }
    public class TrueFalseQuestion : QuestionModel
    {
        public int CorrectAnswer { get; set; } // true or false

        public TrueFalseQuestion(int qid, string header, string body, int? marks, int teacherId, int examId, int correctAnswer)
            : base(qid, header, body, "TrueFalse", marks, teacherId, examId)
        {
            CorrectAnswer = correctAnswer;
        }
        public TrueFalseQuestion(int qid, string header, string body, string qtype, int? marks, int teacherId, int examId, int correctAnswer, List<string> options, List<int> option_Index)
        : base(qid, header, body, qtype, marks, teacherId, examId, options, option_Index)
        {
            CorrectAnswer = correctAnswer;
        }
        public TrueFalseQuestion()
        {
            
        }
        public override void ShowOptions()
        {
            // throw new NotImplementedException();
        }
    }
    public class ChooseOneQuestion : QuestionModel
    {
        public List<string> Options { get; set; } 
        public int CorrectAnswer { get; set; } 

        public ChooseOneQuestion(int qid, string header, string body, int? marks, int teacherId, int examId, List<string> options, int correctAnswer)
            : base(qid, header, body, "ChooseOne", marks, teacherId, examId)
        {
            Options = options;
            CorrectAnswer = correctAnswer;
        }
        public ChooseOneQuestion(int qid, string header, string body, string qtype, int? marks, int teacherId, int examId, int correctAnswer, List<string> options, List<int> option_Index)
        : base(qid, header, body, qtype, marks, teacherId, examId, options, option_Index)
        {
            CorrectAnswer = correctAnswer;
        }
        public ChooseOneQuestion()
        {
            
        }

        public override void ShowOptions()
        {
            // throw new NotImplementedException();
        }
    }

    public class ChooseAllQuestion : QuestionModel
    {
        public List<string> Options { get; set; } // Multiple choices
        public List<int> CorrectAnswer { get; set; } 

        public ChooseAllQuestion(int qid, string header, string body, int? marks, int teacherId, int examId, List<string> options, List<int> correctAnswer)
            : base(qid, header, body, "ChooseAll", marks, teacherId, examId)
        {
            Options = options;
            CorrectAnswer = correctAnswer;
        }
        public ChooseAllQuestion(int qid, string header, string body, string qtype, int? marks, int teacherId, int examId, List<int> correctAnswer, List<string> options, List<int> option_Index)
       : base(qid, header, body, qtype, marks, teacherId, examId, options, option_Index)
        {
            Options = options;
            CorrectAnswer = correctAnswer;
        }
        public ChooseAllQuestion()
        {
            
        }

        public override void ShowOptions()
        {
            // throw new NotImplementedException();
        }
    }

    public class QuestionList : List<QuestionModel>
    {
        public new void Add(QuestionModel question)
        {
            //make a business layer for adding a question and call it here 
            base.Add(question);
        }
    }



}

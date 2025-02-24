using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class AnswerListModel
    {
        public Dictionary<int, AnswerModel> Answers { get; set; } = new Dictionary<int, AnswerModel>();

        public void AddOrUpdateAnswer(int questionId, string studentAnswer, bool isCorrect,int mark)
        {
            if (Answers.ContainsKey(questionId))
            {
                Answers[questionId].StudentAnswer = studentAnswer;
                Answers[questionId].ISCorrect = isCorrect;
                Answers[questionId].Stud_Marks = mark;

            }
            else
            {
                Answers[questionId] = new AnswerModel
                {
                    Ques_ID = questionId,
                    StudentAnswer = studentAnswer,
                    ISCorrect = isCorrect,
                    Stud_Marks = mark


                };
            }
        }
        // calculate the total marks of the student 

        public int CalculateTotalMarks()
        {
            // get the marks for question id if the answer is correct
            for (int i = 0; i < Answers.Count; i++)
            {
                if (Answers.ElementAt(i).Value.ISCorrect)
                {
                    DataTable questionMark = BusinessLogic.ExamManager.getQuestionMarks(Answers.ElementAt(i).Value.Ques_ID);
                    int mark = Convert.ToInt32(questionMark.Rows[0]["Marks"]);
                    Answers.ElementAt(i).Value.Stud_Marks = mark ;
                }
                else
                {
                    Answers.ElementAt(i).Value.Stud_Marks = 0;
                }

            }
            // calculate the total marks
            int totalMarks = 0;

            for (int i = 0; i < Answers.Count; i++)
            {
                totalMarks += Answers.ElementAt(i).Value.Stud_Marks.Value;
            }
            return totalMarks;
        }
        public Dictionary<int, AnswerModel> getStudentAnswers()
        {

            return Answers;
        }
        public string GetStudentAnswer(int questionId)
        {
            if(Answers.ContainsKey(questionId))
            {
                return Answers[questionId].StudentAnswer;
            }

            return "";

        }
    }
}

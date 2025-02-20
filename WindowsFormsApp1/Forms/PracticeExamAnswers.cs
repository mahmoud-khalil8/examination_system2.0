using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{

    public partial class PracticeExamAnswers : Form
    {

        DataTable questions;
        PracticeExam practiceExam;
        string fullName;
        private Timer examTimer;
        private DateTime examEndTime;
        int questionCounter = 0;
        private AnswerListModel studentAnswers;
        int examTotalQuestions;




        public PracticeExamAnswers(PracticeExam practiceExam, AnswerListModel studentAnswers, string fullName)
        {
            this.practiceExam = practiceExam;
            this.fullName = fullName;

            this.studentAnswers = studentAnswers;
            InitializeComponent();
        }



        private void PracticeExamAnswers_Load(object sender, EventArgs e)
        {
            try
            {

                #region Loading ExamData


                if (practiceExam == null)
                {
                    throw new InvalidOperationException("Practice Exam not found.");
                }
                int examID = practiceExam.ExamID;
                string examName = practiceExam.ExamName;
                DateTime examDate;

                if (!DateTime.TryParse(practiceExam.StartTime.ToString(), out examDate))
                {
                    throw new InvalidOperationException("Invalid date format in the database.");
                }
                TimeSpan examDuration;

                if (!TimeSpan.TryParse(practiceExam.Time.ToString(), out examDuration))
                {
                    throw new InvalidOperationException("Invalid time format in the database.");
                }


                examTotalQuestions = practiceExam.NumberOfQuestions;
                int examTotalMarks = practiceExam.Marks;
                ExamNameLabel.Text = examName;
                totalQuestionLabel.Text = "Total Questions: " + examTotalQuestions;
                TotalMarksLabel.Text = "Total Marks: " + examTotalMarks;





                #endregion



                #region LoadQuestion






                // Load Questions
                questions = BusinessLogic.ExamManager.getExamQuestions(examID);
                if (questions.Rows.Count == 0)
                {
                    throw new InvalidOperationException("No questions found for the exam.");
                }

                LoadQuestion(questions.Rows[questionCounter]);
                #endregion


            }
            catch (Exception ex)
            {
                // Log the error and show a message to the user
                MessageBox.Show("An error occurred while loading the exam: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadQuestion(DataRow question)
        {
            // Set the question text
            questionLabel.Text = question["body"].ToString();
            questionNumberLabel.Text = "Question " + (questionCounter + 1) + " of " + examTotalQuestions;

            // Get the question type
            string questionType = question["QType"].ToString();

            // Get question options
            DataTable options = BusinessLogic.ExamManager.getQuestionOptions(Convert.ToInt32(question["QID"]));
            if (options.Rows.Count == 0)
            {
                throw new InvalidOperationException("No options found for the question.");
            }

            // Clear existing options

            // Get the stored answer for this question (if exists)
            int questionId = Convert.ToInt32(question["QID"]);
            string savedAnswer = studentAnswers.GetStudentAnswer(questionId);

            //get question Answer

            DataTable dataTable = BusinessLogic.ExamManager.GetCorrectAnswers(questionId);

            if (dataTable.Rows.Count == 0)
            {
                correctAnsLbl.Text = "No correct answer found.";  // Handle empty case properly
                return;
            }
           

            if (questionType.Equals("choose multiple", StringComparison.OrdinalIgnoreCase))
            {
                List<string> correctAnswers = new List<string>();

                foreach (DataRow row in dataTable.Rows)
                {
                    correctAnswers.Add(row["correctAnswer"].ToString());
                }

                correctAnsLbl.Text = string.Join(", ", correctAnswers);
            }
            else
            {
                correctAnsLbl.Text = dataTable.Rows[0]["correctAnswer"].ToString();
            }

            //get student Answer
            //  !!!!!!!!!!!!!!!!!!!!!




        }




        private void nextbtn_Click_1(object sender, EventArgs e)
        {
            if (questionCounter < questions.Rows.Count - 1)
            {
                questionCounter++;
                LoadQuestion(questions.Rows[questionCounter]);
            }
            else
            {

                MessageBox.Show("No more questions available.");
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (questionCounter > 0)
            {

                questionCounter--;
                LoadQuestion(questions.Rows[questionCounter]);
            }
            else
            {
                MessageBox.Show("No previous questions");
            }
        }
    }
}

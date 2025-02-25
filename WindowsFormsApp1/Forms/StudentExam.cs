using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1.Forms
{
    public partial class StudentExam : Form
    {
        DataTable questions;
        Exam exam;
        PracticeExam practiceExam;
        string fullName;
        private Timer examTimer;
        private DateTime examEndTime;
        int questionCounter = 0;
        int studentId= 0;
        private AnswerListModel studentAnswers = new AnswerListModel();
        int examTotalQuestions;
        UserControls.successSubmit successSubmit;

        
        public StudentExam(Exam exam,string fullName,int studentId)
        {
            this.exam= exam;
            this.fullName = fullName;
            this.studentId = studentId;
            InitializeComponent();
        }



        private void StudentExam_Load(object sender, EventArgs e)
        {
            try
            {
                #region Loading ExamData


                if (exam == null)
                {
                    throw new InvalidOperationException("Practice Exam not found.");
                }

                
               
                int examID = exam.ExamID;
                string examName = exam.ExamName;
                DateTime examDate=exam.StartTime;

                // Notify students when the exam starts

                if (!DateTime.TryParse(exam.StartTime.ToString(), out examDate))
                {
                    throw new InvalidOperationException("Invalid date format in the database.");
                }
                TimeSpan examDuration;

                if (!TimeSpan.TryParse(exam.Time.ToString(), out examDuration))
                {
                    throw new InvalidOperationException("Invalid time format in the database.");
                }


                 examTotalQuestions = exam.NumberOfQuestions;
                int examTotalMarks = exam.Marks;
                ExamNameLabel.Text = examName;
                totalQuestionLabel.Text = "Total Questions: " + examTotalQuestions;
                TotalMarksLabel.Text = "Total Marks: " + examTotalMarks;
                totalTimeLabel.Text = "Exam Duration: " + examDuration.ToString(@"hh\:mm\:ss");

                if(exam is PracticeExam)
                {
                    RemainingTimeLabel.Text = "Remaining Time : --:--:--";
                }
                else
                {

                examEndTime = examDate.Add(examDuration);

                examTimer = new Timer();
                examTimer.Interval = 1000;  
                examTimer.Tick += new EventHandler(UpdateRemainingTime);
                examTimer.Start();


                UpdateRemainingTime(null, null);
                }


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

        private void Exam_ExamStarted(string examName, DateTime startTime)
        {
            throw new NotImplementedException();
        }

        private void UpdateRemainingTime(object sender, EventArgs e)
        {
            TimeSpan remainingTime = examEndTime - DateTime.Now;

            if (remainingTime.TotalSeconds > 0)
            {
                RemainingTimeLabel.Text = "Remaining Time: " + remainingTime.ToString(@"hh\:mm\:ss");
            }
            else
            {
                RemainingTimeLabel.Text = "Exam Time Over";

                examTimer.Stop();
                //MessageBox.Show("Time Over! Your answers will be submitted automatically.", "Time Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                SubmitBtn.Visible = true;
                SubmitBtn.PerformClick();

                
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

           // MessageBox.Show(question["QID"].ToString());
            DataTable options = BusinessLogic.ExamManager.getQuestionOptions(Convert.ToInt32(question["QID"]));


            if (options.Rows.Count == 0)
            {
                throw new InvalidOperationException("No options found for the question.");
            }
            headerlbl.Text = question["header"].ToString();
            questionNumlbl.Text = $"{questionCounter+1})";

            DataTable subjects = BusinessLogic.ExamManager.getSubjects(exam.ExamID);
            subjectNameLbl.Text =$"Subject Name: {subjects.Rows[0]["subject_name"].ToString()}";
            // Clear existing options
            optionsPanel.Controls.Clear();

            // Get the stored answer for this question (if exists)
            int questionId = Convert.ToInt32(question["QID"]);
            string savedAnswer = studentAnswers.GetStudentAnswer(questionId);

            for (int i = 0; i < options.Rows.Count; i++)
            {
                string optionText = options.Rows[i]["options"].ToString();


                if (questionType.ToLower() == "truefalse" || questionType.ToLower() == "chooseone")
                {
                    RadioButton option = new RadioButton
                    {
                        Text = optionText,
                        Name = "option" + i,
                        AutoSize = true,
                        Font = new Font("Jetbrains Mono", 14),
                        Location = new Point(10, 10 + i * 50),
                        Checked = (optionText == savedAnswer) // Restore saved selection
                    };

                    optionsPanel.Controls.Add(option);
                }
                else if (questionType.ToLower() == "chooseall")
                {
                    CheckBox option = new CheckBox
                    {
                        Text = optionText,
                        Name = "option" + i,
                        AutoSize = true,
                        Font = new Font("Jetbrains Mono", 14),
                        Location = new Point(10, 10 + i * 50),
                        Checked = savedAnswer.Split(',').Contains(optionText) // Restore saved selections
                    };

                    optionsPanel.Controls.Add(option);
                }
            }
        }


        private void nextbtn_Click(object sender, EventArgs e)
        {

           SaveStudentAnswer();
            if (questionCounter < questions.Rows.Count - 1)
            {
                questionCounter++;
                LoadQuestion(questions.Rows[questionCounter]);
            }
            else
            {
                
               

                SubmitBtn.Visible = true;

                MessageBox.Show("No more questions available.");
            }

        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            SubmitBtn.Visible = false;


            if (questionCounter > 0)
            {

                questionCounter--;
                LoadQuestion(questions.Rows[questionCounter]);
            }
            else
            {
                MessageBox.Show("You have Reached the beggining of questions.");
            }
        }

        private void SaveStudentAnswer()
        {

            DataRow currentQuestion = questions.Rows[questionCounter];
            int questionId = Convert.ToInt32(currentQuestion["QID"]);
            string questionType = currentQuestion["QType"].ToString();
            string studentAnswer = "";

            // Loop through the controls in optionsPanel to get selected answers
            foreach (Control control in optionsPanel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    studentAnswer = radioButton.Text;
                }
                else if (control is CheckBox checkBox && checkBox.Checked)
                {
                    studentAnswer += checkBox.Text + ",";
                }
            }

            if (questionType.ToLower() == "choose multiple" && studentAnswer.EndsWith(","))
            {
                studentAnswer = studentAnswer.TrimEnd(','); // Remove last comma

            }
            // Check if the answer is correct (simplified for now)
            bool isCorrect = BusinessLogic.ExamManager.ValidateAnswer(questionId, studentAnswer);

            if (isCorrect) {

                DataTable questionMark = BusinessLogic.ExamManager.getQuestionMarks(questionId);
                int mark = Convert.ToInt32(questionMark.Rows[0]["Marks"]);
                studentAnswers.AddOrUpdateAnswer(questionId, studentAnswer, isCorrect, mark);
            }
            else
            {
                studentAnswers.AddOrUpdateAnswer(questionId, studentAnswer, isCorrect,0);
            }
            // Store the answer
//            studentAnswers.AddOrUpdateAnswer(questionId, studentAnswer, isCorrect);
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            //print student answers in message box
            string studentAnswersString = "";
            foreach (var answer in studentAnswers.getStudentAnswers())
            {

                //save answer in database student_answer table
                if(exam is FinalExam)
                {

                     BusinessLogic.ExamManager.StoreStudentAnswer(studentId, exam.ExamID, answer.Key, answer.Value.StudentAnswer, answer.Value.ISCorrect, answer.Value.Stud_Marks.Value);
                }
                studentAnswersString += $"Question ID: {answer.Key}, Answer: {answer.Value.StudentAnswer}, Is Correct: {answer.Value.ISCorrect}\n";
            }
          //  MessageBox.Show(studentAnswersString, "Student Answers", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

            
            
            int totalMarks = studentAnswers.CalculateTotalMarks();
//            MessageBox.Show($"Exam Completed! Your Total Score: {totalMarks}", "Exam Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(exam is FinalExam)
            {

             BusinessLogic.ExamManager.saveExamStudent(studentId, exam.ExamID, totalMarks);
            }



            backgroundPanel.Controls.Clear();

            panel1.Controls.Clear();
            panel1.Visible = false;
            successSubmit = new UserControls.successSubmit();
            backgroundPanel.Controls.Add(successSubmit);

            if(exam is PracticeExam)
            {

                backgroundPanel.Controls.Add(showAnswersBtn);
                showAnswersBtn.BringToFront();
                showAnswersBtn.Visible = true;
            }
            else
            {
                showAnswersBtn.Visible = false;

            }







            //if (exam is PracticeExam)
            //{
            //    DialogResult result = MessageBox.Show(
            //      $"Exam Completed!\nYour Total Score: {totalMarks}\n\nClick 'Show Results' to see detailed feedback.",
            //      "Exam Submission",
            //      MessageBoxButtons.OKCancel,
            //      MessageBoxIcon.Information
            //  );

            //    // If user clicks OK, open results screen
            //    if (result == DialogResult.OK)
            //    {
            //        ShowResults();
            //    }
            //}



            // Optionally save answers to the database
            // BusinessLogic.ExamManager.SaveStudentAnswers(studentAnswers);

        }

        private void ShowResults()
        {

            DataTable exam = BusinessLogic.ExamManager.getUserPracticeExam(studentId);

            if (exam.Rows.Count > 0)
            {
                DataRow row = exam.Rows[0];

                TimeSpan examDuration = TimeSpan.Parse(row["duration"].ToString());
                int numberOfQuestions = Convert.ToInt32(row["ques_num"]);
                string mode = row["mode"].ToString();
                string examName = row["examName"].ToString();
                string examType = row["examType"].ToString();
                int examID = Convert.ToInt32(row["exam_id"]);
                int marks = Convert.ToInt32(row["exam_marks"]);
                int subjectId = Convert.ToInt32(row["subject_id"]);
                int teacherId = Convert.ToInt32(row["teacher_id"]);
                DateTime startTime = Convert.ToDateTime(row["start_time"]);

                // Create PracticeExam instance
                practiceExam = new PracticeExam(examDuration, numberOfQuestions, mode, examName, examType, examID, marks, subjectId, teacherId, startTime);

            }



            PracticeExamAnswers practiceExamAnswers = new PracticeExamAnswers(practiceExam, studentAnswers, fullName);
            practiceExamAnswers.Show();
        }

        private void showAnswersBtn_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void backgroundPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }
       
        
    }
}

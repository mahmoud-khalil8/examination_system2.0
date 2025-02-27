using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BusinessLogic;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class Student : Form
    {
        UserModel student ;
        PracticeExam PracticeExam;
        FinalExam finalExam;
        int selectedExamID = 0;
        UserControls.PracticeExams practiceExams;
        public List<Control> originalControls;


        public Student( UserModel student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Student_Load(object sender, EventArgs e)
        {
            studentNameLabel.Text = student.FullName;
            
            dataGridView1.Visible = true;

            button2.Text = TranslationHelper.GetTranslation("start");
            WarmUpMessage.Text = TranslationHelper.GetTranslation("WarmUpMessage");

            //fill the datagridview with the exams
            DataTable exams = BusinessLogic.ExamManager.GetAvailableExams("final exam",student.UserID);

            refreshBtn.Text = TranslationHelper.GetTranslation("Refresh");


            if (exams.Rows.Count == 0)
            {
                noexamspic.Visible = true;
                nofinallbl.Visible = true;
                nofinallbl.Text = TranslationHelper.GetTranslation("NoFinalLabel");
                FinalExamslbl.Visible = true;
                FinalExamslbl.Text = TranslationHelper.GetTranslation("FinalExams");
                
            }
            else
            {
                noexamspic.Visible = false;
                nofinallbl.Visible = false;
                FinalExamslbl.Visible = false;

                dataGridView1.DataSource = exams;


                dataGridView1.CellClick += dataGridView1_CellClick;
                dataGridView1.Columns["Exam_ID"].Visible = false;
                dataGridView1.Columns["mode"].Visible = false;
                dataGridView1.Columns["examType"].Visible = false;
                dataGridView1.Columns["subjectId"].Visible = false;
                dataGridView1.Columns["userId"].Visible = false;
                dataGridView1.Columns["teacher_id"].Visible = false;
                dataGridView1.Columns["Ques_num"].HeaderText = "Total Questions";

                dataGridView1.ReadOnly = true;

            }
            PracticeExam.ExamStarted += OnExamStarted;
            FinalExam.ExamStarted += OnExamStarted;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            originalControls = ExamsListsPanel.Controls.Cast<Control>().ToList();

            ExamsListsPanel.Controls.Clear();

            practiceExams = new UserControls.PracticeExams(student.UserID, student.FullName, this);
            ExamsListsPanel.Controls.Add(practiceExams);
            button2.Enabled = false;

            //DataTable exam =BusinessLogic.ExamManager.getUserPracticeExam(student.UserID);

            //if (exam.Rows.Count > 0)
            //{
            //    DataRow row = exam.Rows[0];

            //    TimeSpan examDuration = TimeSpan.Parse(row["duration"].ToString());
            //    int numberOfQuestions = Convert.ToInt32(row["ques_num"]);
            //    string mode = row["mode"].ToString();
            //    string examName = row["examName"].ToString();
            //    string examType = row["examType"].ToString();
            //    int examID = Convert.ToInt32(row["exam_id"]);
            //    int marks = Convert.ToInt32(row["exam_marks"]);
            //    int subjectId = Convert.ToInt32(row["subject_id"]);
            //    int teacherId = Convert.ToInt32(row["teacher_id"]);
            //    DateTime startTime = Convert.ToDateTime(row["start_time"]);

            //    // Create PracticeExam instance
            //     PracticeExam= new PracticeExam(examDuration, numberOfQuestions, mode, examName, examType, examID, marks, subjectId, teacherId, startTime);

            //}



            //StudentExam studentExam = new StudentExam(PracticeExam, student.FullName,student.UserID);

            //studentExam.Show();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["exam_id"].Value != null && e.RowIndex< dataGridView1.Rows.Count-1)
            {
                int examId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["exam_id"].Value);
                selectedExamID = examId;
                startFinalBtn.Visible = true;
                startFinalBtn.Text = TranslationHelper.GetTranslation("Start");
                startFinalBtn.Enabled = true;
                
              //  MessageBox.Show($"Selected Exam ID: {examId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                startFinalBtn.Enabled = false;

              //  MessageBox.Show("Invalid selection. Please select a valid row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startFinalBtn_Click(object sender, EventArgs e)
        {

            DataTable checkExamTaken = BusinessLogic.ExamManager.checkExamTaken(student.UserID, selectedExamID);

            if (checkExamTaken.Rows.Count > 0)
            {
                MessageBox.Show("You have already taken this exam.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }




            DataTable exam = BusinessLogic.ExamManager.getExam(selectedExamID);

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

                if(startTime > DateTime.Now)
                {
                    MessageBox.Show("Exam has not started yet.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                else if(startTime.Add(examDuration) < DateTime.Now)
                {
                    MessageBox.Show("Exam has ended.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Create FinalExam instance
                finalExam = new FinalExam(examDuration, numberOfQuestions, mode, examName, examType, examID, marks, subjectId, teacherId, startTime);

            }
            


            StudentExam studentExam = new StudentExam(finalExam, student.FullName, student.UserID);

            studentExam.Show();
        }
        private void OnExamStarted(string examName, DateTime startTime)
        {

            BusinessLogic.ExamManager.startExam(examName);

            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() =>
                    MessageBox.Show($"The exam '{examName}' has started at {startTime}.",
                                    "Exam Notification",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information)
                ));
            }
            else
            {

                MessageBox.Show($"The exam '{examName}' has started at {startTime}.",
                                "Exam Notification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Unsubscribe to avoid memory leaks
            PracticeExam.ExamStarted -= OnExamStarted;
            FinalExam.ExamStarted -= OnExamStarted;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            DataTable finalExams = BusinessLogic.ExamManager.GetAvailableExams("Final Exam",student.UserID);

            

            // Check Final Exams
            foreach (DataRow row in finalExams.Rows)
            {
                DateTime startTime = Convert.ToDateTime(row["start_time"]);
                string examName = row["examName"].ToString();

                if (startTime <= DateTime.Now && startTime.Add(TimeSpan.Parse(row["duration"].ToString())) > DateTime.Now)
                {
                    // Trigger the event for final exams
                    Exam.NotifyExamStart(examName, startTime);
                }
            }
        }

        private void ExamsListsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nofinallbl_Click(object sender, EventArgs e)
        {

        }
    }
}

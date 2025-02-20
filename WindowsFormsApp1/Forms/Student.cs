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
    public partial class Student : Form
    {
        UserModel student ;
        PracticeExam PracticeExam;
        FinalExam finalExam;
        private int selectedExamID = 0; 

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

            //fill the datagridview with the exams
            DataTable exams = BusinessLogic.ExamManager.GetAvailableExams("final");

            if (exams.Rows.Count == 0)
            {
                noexamspic.Visible = true;
                nofinallbl.Visible = true;
            }
            else
            {
                noexamspic.Visible = false;
                nofinallbl.Visible = false;

                dataGridView1.DataSource = exams;


            dataGridView1.CellClick += dataGridView1_CellClick;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DataTable exam =BusinessLogic.ExamManager.getUserPracticeExam(student.UserID);
            
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
                 PracticeExam= new PracticeExam(examDuration, numberOfQuestions, mode, examName, examType, examID, marks, subjectId, teacherId, startTime);

            }



            StudentExam studentExam = new StudentExam(PracticeExam, student.FullName,student.UserID);

            studentExam.Show();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["exam_id"].Value != null && e.RowIndex< dataGridView1.Rows.Count-1)
            {
                int examId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["exam_id"].Value);
                startFinalBtn.Visible = true;
                startFinalBtn.Enabled = true;
                
                MessageBox.Show($"Selected Exam ID: {examId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                startFinalBtn.Enabled = false;

                MessageBox.Show("Invalid selection. Please select a valid row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void startFinalBtn_Click(object sender, EventArgs e)
        {

            DataTable exam = BusinessLogic.ExamManager.GetAvailableExams("final");

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
                finalExam = new FinalExam(examDuration, numberOfQuestions, mode, examName, examType, examID, marks, subjectId, teacherId, startTime);

            }



            StudentExam studentExam = new StudentExam(finalExam, student.FullName, student.UserID);

            studentExam.Show();
        }
    }
}

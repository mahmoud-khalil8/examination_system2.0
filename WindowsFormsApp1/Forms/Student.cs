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
            DataTable exams = BusinessLogic.ExamManager.GetExams();
            dataGridView1.DataSource = exams;




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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

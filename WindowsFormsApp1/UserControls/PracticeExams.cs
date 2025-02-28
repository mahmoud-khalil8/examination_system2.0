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
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Forms.admin;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls
{
    public partial class PracticeExams : UserControl
    {
        int studentId;
        int selectedExamID;
        string studentFullname;
        Student parentForm;


        public PracticeExams(int userId, string studentFullname, Student parentForm)
        {
            InitializeComponent();
            studentId = userId;
            this.studentFullname = studentFullname;
            this.parentForm = parentForm;

        }

        private void PracticeExams_Load(object sender, EventArgs e)
        {
            backBtn.Text = TranslationHelper.GetTranslation("Back");
            if (studentId == 0) {
                MessageBox.Show("Student ID is not set");
                return;
            }
            DataTable exams = BusinessLogic.ExamManager.GetAvailableExams("practical exam", studentId);

            if (exams.Rows.Count == 0)
            {
                noexamspic.Visible = true;
                nofinallbl.Visible = true;
                nofinallbl.Text = TranslationHelper.GetTranslation("NofinalLabel");
            }
            else
            {
                noexamspic.Visible = false;
                nofinallbl.Visible = false;

                dataGridView1.DataSource = exams;
                dataGridView1.CellClick += dataGridView1_CellClick;
                dataGridView1.Columns["Exam_ID"].Visible = false;
                dataGridView1.Columns["mode"].Visible = false;
                dataGridView1.Columns["examType"].Visible = false;
                dataGridView1.Columns["subject_id"].Visible = false;
                dataGridView1.Columns["teacher_id"].Visible = false;
                dataGridView1.ReadOnly = true;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dataGridView1.Rows[e.RowIndex].Cells["exam_id"].Value != null && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                int examId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["exam_id"].Value);
                selectedExamID = examId;
                startPracticeBtn.Visible = true;
                startPracticeBtn.Enabled = true;

                startPracticeBtn.Text = TranslationHelper.GetTranslation("Start");
                //  MessageBox.Show($"Selected Exam ID: {examId}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                startPracticeBtn.Enabled = false;

                //  MessageBox.Show("Invalid selection. Please select a valid row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void startPracticeBtn_Click(object sender, EventArgs e)
        {

            DataTable checkExamTaken = BusinessLogic.ExamManager.checkExamTaken(studentId, selectedExamID);

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
                DateTime startTime = DateTime.Parse(row["start_time"].ToString());

                PracticeExam practiceExam = new PracticeExam(examDuration, numberOfQuestions, mode, examName, examType, examID, marks, subjectId, teacherId, startTime);

                StudentExam studentExam = new StudentExam(practiceExam, studentFullname, studentId);

                studentExam.Show();
            }
            else
            {
                MessageBox.Show("Exam not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {

            // return to the original content in the form that got cleared when this usercontrol loaded
            if (parentForm != null && parentForm.originalControls != null)
            {
                parentForm.ExamsListsPanel.Controls.Clear();

                // Restore original controls to the panel
                foreach (Control control in parentForm.originalControls)
                {
                    parentForm.ExamsListsPanel.Controls.Add(control);
                    parentForm.button2.Enabled = true;

                }
            }


        }
    }
}

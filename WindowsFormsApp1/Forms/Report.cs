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

namespace WindowsFormsApp1.Forms
{
    public partial class Report : Form
    {
        public int STID { get; set; }
        public int EXID { get; set; }
        int teacherId { get; set; }

        public Report(int studentId, int examId,int _teacherId)
        {
            STID = studentId;
            EXID = examId;
            InitializeComponent();

            teacherId = _teacherId;
            this.Text = "Exam Details";
            this.Size = new System.Drawing.Size(900, 700);
            this.AutoScroll = true;
            this.Padding = new Padding(20); // Adds padding for better spacing

            // === FETCH DATA ===
            DataTable studentInfo = ViewAllStudentsUS_BL.GetFullName(EXID, STID);
            DataTable examName = ViewAllStudentsUS_BL.GetExamName(EXID, STID);
            DataTable examType = ViewAllStudentsUS_BL.GetExamType(EXID, STID);
            DataTable subjectName = ViewAllStudentsUS_BL.GetSubjectName(EXID, STID,teacherId);
            DataTable totalMarks = ViewAllStudentsUS_BL.GetTotalMarks(EXID, STID);
            DataTable studentMarks = ViewAllStudentsUS_BL.GetStudentMarks(EXID, STID);
            DataTable questionsData = ViewAllStudentsUS_BL.GetQuestionsAndCorrectAnswer(EXID, STID);
            DataTable studentAnswers = ViewAllStudentsUS_BL.GetStudentAnswers(EXID, STID);
            DataTable optionsData = ViewAllStudentsUS_BL.GetOptions(EXID, STID);

            // === PANEL SETUP ===
            Panel panel = new Panel() { Dock = DockStyle.Fill, AutoScroll = true };
            this.Controls.Add(panel);

            int y = 20; // Initial Y position

            // === STUDENT & EXAM DETAILS ===
            Panel studentDetailsPanel = new Panel()
            {
                Location = new Point(30, y),
                Size = new Size(800, 230),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGray
            };
            panel.Controls.Add(studentDetailsPanel);

            int detailsY = 15; // Inside panel spacing

            Label titleLabel = new Label()
            {
                Text = "📋 Student & Exam Details",
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(230, detailsY),
                AutoSize = true,
                ForeColor = Color.DarkBlue
            };
            studentDetailsPanel.Controls.Add(titleLabel);
            detailsY += 40; // Space after title

            // === STUDENT INFO (Aligned and Spaced) ===
            studentDetailsPanel.Controls.Add(CreateStyledLabel($"👤 Name:       {studentInfo.Rows[0]["FullName"]}", 30, ref detailsY, FontStyle.Bold));
            detailsY += 5;

            studentDetailsPanel.Controls.Add(CreateStyledLabel($"📝 Exam:       {examName.Rows[0]["ExamName"]}", 30, ref detailsY, FontStyle.Bold));
            detailsY += 5;

            studentDetailsPanel.Controls.Add(CreateStyledLabel($"📌 Exam Type:  {examType.Rows[0]["ExamType"]}", 30, ref detailsY, FontStyle.Bold));
            detailsY += 5;

            studentDetailsPanel.Controls.Add(CreateStyledLabel($"📚 Subject:    {subjectName.Rows[0]["Subject_Name"]}", 30, ref detailsY, FontStyle.Bold));
            detailsY += 5;

            studentDetailsPanel.Controls.Add(CreateStyledLabel($"🎯 Marks:      {studentMarks.Rows[0]["Student_Marks"]} / {totalMarks.Rows[0]["Exam_Marks"]}", 30, ref detailsY, FontStyle.Bold));

            y += 250; // Space after details section

            // === QUESTIONS & ANSWERS ===
            int questionNumber = 1;
            foreach (DataRow questionRow in questionsData.Rows)
            {
                string qid = questionRow["QID"].ToString();
                string correctAnswer = questionRow["CorrectAnswers"].ToString();
                string options = optionsData.Select($"QID = {qid}").Length > 0 ? optionsData.Select($"QID = {qid}")[0]["Options"].ToString() : "N/A";
                string studentAnswer = studentAnswers.Select($"Ques_ID = {qid}").Length > 0 ? studentAnswers.Select($"Ques_ID = {qid}")[0]["Answer"].ToString() : "N/A";

                // === Question Header ===
                panel.Controls.Add(CreateBoldLabel($"🔹 Q{questionNumber}: {questionRow["Header"]}", 40, ref y));
                questionNumber++;

                // === Question Details ===
                panel.Controls.Add(CreateLabel($"📄 Details: {questionRow["Body"]}", 60, ref y));

                // === Options ===
                panel.Controls.Add(CreateBoldLabel("📌 Options:", 60, ref y));
                string[] optionList = options.Split('+');
                for (int i = 0; i < optionList.Length; i++)
                {
                    panel.Controls.Add(CreateLabel($"   {i + 1}. {optionList[i].Trim()}", 80, ref y));
                }

                // === Correct Answer ===
                panel.Controls.Add(CreateColoredLabel($"✔️ Correct Answer: {correctAnswer}", 60, ref y, Color.Green));

                // === Student Answer (Color Coded) ===
                if (studentAnswer == correctAnswer)
                {
                    panel.Controls.Add(CreateColoredLabel($"✅ Student Answer: {studentAnswer}", 60, ref y, Color.Blue)); // Correct
                }
                else
                {
                    panel.Controls.Add(CreateColoredLabel($"❌ Student Answer: {studentAnswer}", 60, ref y, Color.Red)); // Incorrect
                }

                y += 40; // Space before next question
            }
        }

        // === HELPER METHODS ===

        // Create normal label
        private Label CreateLabel(string text, int x, ref int y)
        {
            Label label = new Label()
            {
                Text = text,
                AutoSize = true,
                Location = new System.Drawing.Point(x, y),
                Font = new System.Drawing.Font("Arial", 12)
            };
            y += 30; // Move down for the next control
            return label;
        }

        // Create bold label
        private Label CreateBoldLabel(string text, int x, ref int y)
        {
            Label label = CreateLabel(text, x, ref y);
            label.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            return label;
        }

        // Create colored label
        private Label CreateColoredLabel(string text, int x, ref int y, System.Drawing.Color color)
        {
            Label label = CreateLabel(text, x, ref y);
            label.ForeColor = color;
            label.Font = new System.Drawing.Font("Arial", 12, FontStyle.Bold);
            return label;
        }

        // Create styled label inside panel
        private Label CreateStyledLabel(string text, int x, ref int y, FontStyle fontStyle, Color? color = null)
        {
            Label label = new Label()
            {
                Text = text,
                AutoSize = true,
                Location = new Point(x, y),
                Font = new Font("Arial", 12, fontStyle),
                ForeColor = color ?? Color.Black
            };
            y += 30; // Move down for next control
            return label;
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}

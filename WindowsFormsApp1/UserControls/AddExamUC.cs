using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using WindowsFormsApp1.BusinessLogic;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls
{
    public partial class AddExamUC : UserControl
    {
        Exam exam = new Exam();
        Subject Subject = new Subject();
        public AddExamUC()
        {
            InitializeComponent();
            StartTimeTXB.MinDate = DateTime.Now;
            kryptonContextMenuItem2.Click += kryptonContextMenuItem_Click;
            kryptonContextMenuItem3.Click += kryptonContextMenuItem_Click;
            NumberOfQuestionsTXB.KeyPress += kryptonTextBox1_KeyPress;
            MarkTXB.KeyPress += kryptonTextBox1_KeyPress;
            SubjectTXB.Items.AddRange(AddExamUCBusiness.GetSubjects(intro.CurrentId).Rows.Cast<DataRow>().Select(x => x["Subject_Name"].ToString()).ToArray());
            DropDownMenu.Items.AddRange(new string[] { "Final Exam", "Practical Exam" });
            SubjectTXB.DropDownStyle = ComboBoxStyle.DropDownList;
            DropDownMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            DropDownMenu.Text = "Exam Type";

        }
        private void kryptonContextMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is KryptonContextMenuItem clickedMenuItem)
            {
                if (DropDownMenu != null)
                {
                    DropDownMenu.Text = clickedMenuItem.Text;
                }
            }
        }
        private void kryptonTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddExamUC_Load(object sender, EventArgs e)
        {

        }

        private void StartTimeTXB_ValueChanged(object sender, EventArgs e)
        {
            if (StartTimeTXB.Value < DateTime.Now)
            {
                StartTimeTXB.Value = DateTime.Now;
            }
        }

        private void AddExamBTN_Click(object sender, EventArgs e)
        {
            if (DropDownMenu.Text == "Exam Type" || string.IsNullOrWhiteSpace(DropDownMenu.Text))
            {
                MessageBox.Show("Please select an exam type from the dropdown menu.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(NumberOfQuestionsTXB.Text) || NumberOfQuestionsTXB.Text == "0")
            {
                MessageBox.Show("Please enter a valid number of questions (greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(SubjectTXB.Text))
            {
                MessageBox.Show("Please enter the subject name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(MarkTXB.Text) || MarkTXB.Text == "0")
            {
                MessageBox.Show("Please enter a valid mark per question (greater than 0).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(DurationTXB.Text) || DurationTXB.Text == "00:00")
            {
                MessageBox.Show("Please set a valid exam duration.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (StartTimeTXB.Value < DateTime.Now)
            {
                MessageBox.Show("Start time cannot be in the past. Please select a future time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                Subject.SubName = SubjectTXB.Text;
                Subject.TeacherID = intro.CurrentId;
                exam.ExamName = SubjectTXB.Text;
                exam.NumberOfQuestions = Convert.ToInt32(NumberOfQuestionsTXB.Text);
                exam.Marks = Convert.ToInt32(MarkTXB.Text);
                exam.Time = TimeSpan.Parse(DurationTXB.Text);
                exam.StartTime = StartTimeTXB.Value;
                exam.ExamType = DropDownMenu.Text;
                exam.TeacherId = intro.CurrentId;

                //var table = AddExamUCBusiness.GetSubject(Subject.SubName, Subject.TeacherID);
                //if (table.Rows.Count == 0)
                //{
                //    AddExamUCBusiness.InsertSubject(Subject.TeacherID , Subject.SubName);   
                //}
                var subjectID = AddExamUCBusiness.GetSubject(Subject.SubName, Subject.TeacherID).Rows[0]["Sub_ID"];
                exam.SubjectId = Convert.ToInt32(subjectID);
                var NoOfRowsAffected = AddExamUCBusiness.InsertExam(exam);
                var ExamID = AddExamUCBusiness.GetExam(exam).Rows[0]["Exam_ID"];
                TeacherDashoard.CurrentExamID = Convert.ToInt32(ExamID);
                if (NoOfRowsAffected == 1)
                {
                    MessageBox.Show("Exam Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Reset();
                }
                else
                {
                    MessageBox.Show("Something Wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetBTN_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        public void Reset()
        {
            DropDownMenu.Text = "Exam Type";
            SubjectTXB.Text = "";
            NumberOfQuestionsTXB.Text = "";
            MarkTXB.Text = "";
            DurationTXB.Text = "00:00";
            StartTimeTXB.Value = DateTime.Now;
        }

        private void MarkTXB_TextChanged(object sender, EventArgs e)
        {

        }

        private void DropDownMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownMenu.Text = DropDownMenu.SelectedItem.ToString();
        }

        private void SubjectTXB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

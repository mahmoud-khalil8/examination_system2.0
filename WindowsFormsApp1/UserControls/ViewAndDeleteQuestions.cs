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

namespace WindowsFormsApp1.UserControls
{
    public partial class ViewAndDeleteQuestions : UserControl
    {
        int id = intro.CurrentId;
        public ViewAndDeleteQuestions()
        {
            InitializeComponent();

            dgv.Enter += ClearLbout;
            cbexamid.Enter += ClearLbout;
        }

        private void ClearLbout(object sender, EventArgs e)
        {
            lbout.Text = "";
        }

        private void ViewAndDeleteQuestions_Load(object sender, EventArgs e)
        {
            cbexamid.Items.Clear();
            cbexamid.Items.Add("All Questions");
            DataTable dtEX = TeacherBL.GetAllExamsID(id);

            if (dtEX != null && dtEX.Rows.Count > 0)
            {
                foreach (DataRow row in dtEX.Rows)
                {
                    cbexamid.Items.Add(row[0].ToString());
                }
            }

            cbexamid.SelectedIndex = 0;

        }

        private void cbexamid_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbout.Text = "";
            lbout.ForeColor = Color.Black;

            if (cbexamid.Items.Count == 0)
            {
                lbout.Text = "The Exam ID list is empty!";
                lbout.ForeColor = Color.Red;
                return;
            }

            if (cbexamid.SelectedIndex == 0)
            {
                DataTable allQuestions = TeacherBL.GetAllQuestions(id);

                if (allQuestions != null && allQuestions.Rows.Count > 0)
                {
                    dgv.DataSource = allQuestions;
                }
                else
                {
                    dgv.DataSource = null;
                    lbout.Text = "No questions found for all exams.";
                    lbout.ForeColor = Color.Blue;
                }
                return;
            }

            if (int.TryParse(cbexamid.SelectedItem?.ToString(), out int examid))
            {
                DataTable dt = TeacherBL.GetAllQueationsById(examid, id);

                if (dt != null && dt.Rows.Count > 0)
                {
                    dgv.DataSource = dt;
                }
                else
                {
                    dgv.DataSource = null;
                    lbout.Text = "No questions found for the selected Exam ID.";
                    lbout.ForeColor = Color.Blue;
                }
            }
            else
            {
                dgv.DataSource = null;
                lbout.Text = "Please select a valid Exam ID.";
                lbout.ForeColor = Color.Red;
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];

                if (selectedRow.Cells["QID"].Value != null && selectedRow.Cells["ExamName"].Value != null)
                {
                    int qid = Convert.ToInt32(selectedRow.Cells["QID"].Value);
                    int examid = Convert.ToInt32(selectedRow.Cells["Exam_ID"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this question?",
                                                          "Delete Confirmation",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        int rowsAffected = TeacherBL.DeleteQuestion(qid, examid, id);

                        if (rowsAffected > 0)
                        {
                            lbout.Text = "Question deleted successfully!";
                            lbout.ForeColor = Color.Green;
                            dgv.Rows.Remove(selectedRow);
                        }
                        else
                        {
                            lbout.Text = "Failed to delete the question.";
                            lbout.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lbout.Text = "Deletion cancelled.";
                        lbout.ForeColor = Color.Blue;
                    }
                }
                else
                {
                    lbout.Text = "Invalid selection. Please select a valid question.";
                    lbout.ForeColor = Color.Red;
                }
            }
            else
            {
                lbout.Text = "Please select a row to delete.";
                lbout.ForeColor = Color.Red;
            }
        }

    }
}



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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls
{
    public partial class ViewAllStudentsUserControl : UserControl
    {
        int id = intro.CurrentId;


        public static int studid;
        public static int examid;

        public ViewAllStudentsUserControl()
        {
            InitializeComponent();

            dgv.Enter += ClearLbout;
            cbstud.Enter += ClearLbout;
            cbsubject.Enter += ClearLbout;
        }

        private void ClearLbout(object sender, EventArgs e)
        {
            lbout.Text = "";
        }

        DataTable table = new DataTable();

        private void ViewAllStudentsUserControl_Load(object sender, EventArgs e)
        {
            cbstud.Items.Clear();
            cbstud.Items.AddRange(new object[] { "All Students", "Top Five" });

            table = ViewAllStudentsUS_BL.GetStudentsName(id);
            if (table?.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    cbstud.Items.Add(row[0].ToString());
                }
            }
            cbstud.SelectedIndex = 0;

            cbsubject.Items.Clear();
            cbsubject.Items.Add("All Subjects");

            table = ViewAllStudentsUS_BL.GetSubjectName(id);
            if (table?.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    cbsubject.Items.Add(row[0].ToString());
                }
            }
            cbsubject.SelectedIndex = 0;
        }

        private void cbstud_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void cbsubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            lbout.Text = "";
            lbout.ForeColor = Color.Black;

            if (cbstud.Items.Count == 0 || cbsubject.Items.Count == 0)
            {
                ShowMessage("The lists are empty!", Color.Red);
                return;
            }

            string studentName = cbstud.SelectedItem?.ToString() ?? "All Students";
            string subjectName = cbsubject.SelectedItem?.ToString() ?? "All Subjects";

            if (studentName == "All Students" && subjectName == "All Subjects")
            {
                LoadData(ViewAllStudentsUS_BL.GetStudentData(id), "No Students Found For All Exams.");
            }
            else if (studentName == "Top Five")
            {
                if (subjectName == "All Subjects")
                {
                    LoadData(ViewAllStudentsUS_BL.GetTopFive(id), "No Students Found For All Exams.");
                }
                else
                {
                    LoadData(ViewAllStudentsUS_BL.GetTopFive(id, subjectName), "No Students Found For This Subject.");
                }
            }
            else if (studentName != "All Students" && subjectName == "All Subjects")
            {
                LoadData(ViewAllStudentsUS_BL.GetStudentDataByName(id, studentName), "No Students found.");
            }
            else if (studentName == "All Students" && subjectName != "All Subjects")
            {
                LoadData(ViewAllStudentsUS_BL.GetStudentDataBySubject(id, subjectName), "No Students found for this subject.");
            }
            else if (studentName != "All Students" && subjectName != "All Subjects")
            {
                LoadData(ViewAllStudentsUS_BL.GetStudentDataByNameAndSubject(id, studentName, subjectName), "No Students found for this name and subject.");
            }
        }

        private void LoadData(DataTable data, string noDataMessage)
        {
            if (data?.Rows.Count > 0)
            {
                dgv.DataSource = data;
            }
            else
            {
                dgv.DataSource = null;
                ShowMessage(noDataMessage, Color.Blue);
            }
        }

        private void ShowMessage(string message, Color color)
        {
            lbout.Text = message;
            lbout.ForeColor = color;
        }


        private void btndetails_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];

                studid = Convert.ToInt32(selectedRow.Cells["Student ID"].Value);
                examid = Convert.ToInt32(selectedRow.Cells["Exam ID"].Value);

                Report report = new Report(studid, examid);
                report.Show();
            }
            else
            {
                lbout.Text = "Please select a row to view the details.";
                lbout.ForeColor = Color.Red;
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (.xlsx)|.xlsx",
                DefaultExt = "xlsx",
                FileName = $"StdRepo_{DateTime.Now:yyyyMMdd_HHmmss}"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveExcel.SaveDataTableToExcel(table, saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


    }
}

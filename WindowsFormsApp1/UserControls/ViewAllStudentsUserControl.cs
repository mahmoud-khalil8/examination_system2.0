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
    public partial class ViewAllStudentsUserControl : UserControl
    {
        int id ;


        public static int studid;
        public static int examid;

        public ViewAllStudentsUserControl(int id)
        {
            InitializeComponent();

            this.id = id;
            dgv.Enter += ClearLbout;
            cbstud.Enter += ClearLbout;
        }

        private void ClearLbout(object sender, EventArgs e)
        {
            lbout.Text = "";
        }


        private void ViewAllStudentsUserControl_Load(object sender, EventArgs e)
        {
            cbstud.Items.Clear();
            cbstud.Items.Add("All Students");
            cbstud.Items.Add("Top Five");

            table = ViewAllStudentsUS_BL.GetStudentsName(id);

            if (table != null && table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    cbstud.Items.Add(row[0].ToString());
                }
            }

            cbstud.SelectedIndex = 0;
        }
        DataTable table = new DataTable();

        private void cbstud_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbout.Text = "";
            lbout.ForeColor = Color.Black;

            if (cbstud.Items.Count == 0)
            {
                lbout.Text = "The Student ID list is empty!";
                lbout.ForeColor = Color.Red;
                return;
            }


            if (cbstud.SelectedIndex == 0)
            {
                table = ViewAllStudentsUS_BL.GetStudentData(id);

                if (table != null && table.Rows.Count > 0)
                {
                    dgv.DataSource = table;
                }
                else
                {
                    dgv.DataSource = null;
                    lbout.Text = "No Students Found For All Exams.";
                    lbout.ForeColor = Color.Blue;
                }
                return;
            }
            if (cbstud.SelectedIndex == 1)
            {
                table = ViewAllStudentsUS_BL.GetTopFive(id);

                if (table != null && table.Rows.Count > 0)
                {
                    dgv.DataSource = table;
                }
                else
                {
                    dgv.DataSource = null;
                    lbout.Text = "No Students Found For All Exams.";
                    lbout.ForeColor = Color.Blue;
                }
                return;
            }

            string StudentName = cbstud.SelectedItem.ToString();
            table = ViewAllStudentsUS_BL.GetStudentDataByName(id, StudentName);
            if (cbstud.SelectedIndex > 1)
            {
                if (table != null && table.Rows.Count > 0)
                {
                    dgv.DataSource = table;
                }
                else
                {
                    dgv.DataSource = null;
                    lbout.Text = "No Students found.";
                    lbout.ForeColor = Color.Blue;
                }
            }
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];

                studid = Convert.ToInt32(selectedRow.Cells["Student ID"].Value);
                examid = Convert.ToInt32(selectedRow.Cells["Exam ID"].Value);

                Report report = new Report(studid, examid,id);
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

using ADMIN.BusinessLogicLayer;
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

namespace WindowsFormsApp1.UserControls.StdUC
{
    public partial class RemoveStd : UserControl
    {
        public RemoveStd()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DgvRemove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //DgvRemove.DataSource = BusinessLogicLayer.StudentBLL.GetALLStudents();
        }

        private void DltStdUCBtn_Click(object sender, EventArgs e)
        {
            if (DgvRemove.SelectedRows.Count > 0)
            {
                int stdID = Convert.ToInt32(DgvRemove.SelectedRows[0].Cells["UserID"].Value);
                // DataGridViewRow selectedRow = DgvRemove.SelectedRows[0];
                //   

                DialogResult result = MessageBox.Show("Are you sure you want to delete this student", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        bool isDeleted = StudentBLL.DeleteStudent(stdID);
                        if (isDeleted)
                        {
                            MessageBox.Show("Student has been deleted successfully");
                            DgvRemove.DataSource = StudentBLL.GetAllStudents();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete this Student, Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                    }
                }


            }
            else
            {
                MessageBox.Show("select student frst");
            }
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            //DgvRemove.DataSource = BusinessLogicLayer.StudentBLL.GetALLStudents();
        }

        private void RemoveStd_Load(object sender, EventArgs e)
        {
            DgvRemove.DataSource = StudentBLL.GetAllStudents();
        }

        public void LoadStudentsData()
        {
            try
            {
                DataTable dt = StudentBLL.GetAllStudents();
                List<UserModel> students = new List<UserModel>();

                foreach (DataRow row in dt.Rows)
                {
                    students.Add(new UserModel
                    {
                        UserID = Convert.ToInt32(row["UserID"]),
                        FullName = row["StudentName"].ToString(),
                        UserName = row["UserName"].ToString(),
                        Email = row["Email"].ToString(),
                        Password = row["Password"].ToString(),
                        Address = row["Address"].ToString(),
                        Gender = row["Gender"].ToString(),
                        Phone = row["Phone"].ToString(),
                        BirthDate = row["BirthDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["BirthDate"])
                    });
                }

                DgvRemove.DataSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

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

namespace WindowsFormsApp1.UserControls.TeacherUC
{
    public partial class DeleteTeacherUC : UserControl
    {
        public DeleteTeacherUC()
        {
            InitializeComponent();
        }


        private void DgvTchRemove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadTeachersData()
        {
            try
            {
                DataTable dt = TeacherBLL.GetAllTeachers();
                List<UserModel> teachers = new List<UserModel>();

                foreach (DataRow row in dt.Rows)
                {
                    teachers.Add(new UserModel
                    {
                        UserID = Convert.ToInt32(row["UserID"]),
                        FullName = row["UserName"].ToString(),
                        UserName = row["UserName"].ToString(),
                        Email = row["Email"].ToString(),
                        Password = row["Password"].ToString(),
                        Address = row["Address"].ToString(),
                        Gender = row["Gender"].ToString(),
                        Phone = row["Phone"].ToString(),
                        BirthDate = row["BirthDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["BirthDate"]),
                        Age = Convert.ToInt32(row["Age"])
                    });

                }


                DgvTchRemove.DataSource = teachers;
                string[] hiddenColumns = { "Role", "CreatedBy", "SupervisedBy" };
                foreach (DataGridViewColumn Column in DgvTchRemove.Columns)
                {
                    if (hiddenColumns.Contains(Column.Name))
                        Column.Visible = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading teachers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DltTchUCBtn_Click(object sender, EventArgs e)
        {
            if (DgvTchRemove.SelectedRows.Count > 0)
            {
                int TeacherID = Convert.ToInt32(DgvTchRemove.SelectedRows[0].Cells["UserID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this teacher", "Confirm Deletion", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                if (result == DialogResult.OK)
                {
                    try
                    {
                        bool isDeleted = TeacherBLL.DeleteTeacher(TeacherID);
                        if (isDeleted)
                        {
                            MessageBox.Show("Teacher has been deleted successfully");
                            DgvTchRemove.DataSource = TeacherBLL.GetAllTeachers();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete this Teacher");
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
                MessageBox.Show("Select Teacher first !");
            }
        }

        private void DeleteTeacherUC_Load(object sender, EventArgs e)
        {

        }
    }
}

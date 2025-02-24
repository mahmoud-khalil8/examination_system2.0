using ADMIN.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls.TeacherUC
{
    public partial class UpdTeacherUC : UserControl
    {
        private int SelectedUserID = -1;
        public UpdTeacherUC()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IDchUpdBtn.Text, out int ID))
            {
                SearchTchByID(ID);
            }
            else
            {
                MessageBox.Show("Invalid ID format. Please enter a valid numeric ID.");
            }
        }

        private void IDchUpdBtn_TextChanged(object sender, EventArgs e)
        {
            string input = IDchUpdBtn.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter Teacher Id");
                return;
            }
        }
        private void SearchTchByID(int ID)
        {
            DataTable dt = TeacherBLL.GetTeacherById(ID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                UserModel Teacher = new UserModel
                {
                    UserID = Convert.ToInt32(row["UserID"]),
                    FullName = row["FullName"].ToString(),
                    UserName = row["UserName"].ToString(),
                    Email = row["Email"].ToString(),
                    Password = row["Password"].ToString(),
                    Phone = row["Phone"].ToString(),
                    BirthDate = Convert.ToDateTime(row["BirthDate"]),
                    Address = row["Address"].ToString(),
                    Gender = row["Gender"].ToString()
                };
                //Fill textboxes with the data
                FNameChUpdBtn.Text = Teacher.FullName;
                UNchUpdBtn.Text = Teacher.UserName;
                EmailChUpdBtn.Text = Teacher.Email;
                PassChUpdBtn.Text = Teacher.Password;
                AddChUpdBtn.Text = Teacher.Address;
                GenderChUpdTxt.Text = Teacher.Gender;
                PhChUpdBtn.Text = Teacher.Phone;
                kryptonChDateTimePicker1.Value = Teacher.BirthDate.GetValueOrDefault(DateTime.Now);
                SelectedUserID = Teacher.UserID;
            }
            else
            {
                MessageBox.Show("This Teacher is not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SvChChangesBtn_Click(object sender, EventArgs e)
        {
            if (SelectedUserID == -1)
            {
                MessageBox.Show("Please enter an ID first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(PhChUpdBtn.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone number must contain only numbers!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(EmailChUpdBtn.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gender = GenderChUpdTxt.Text.Trim().ToLower();
            if (gender != "male" && gender != "female")
            {
                MessageBox.Show("Gender must be either 'Male' or 'Female'!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserModel teacher = new UserModel
            {
                UserID = SelectedUserID,
                FullName = FNameChUpdBtn.Text,
                UserName = UNchUpdBtn.Text,
                Email = EmailChUpdBtn.Text,
                Password = PassChUpdBtn.Text,
                Address = AddChUpdBtn.Text,
                Gender = char.ToUpper(gender[0]) + gender.Substring(1),
                Phone = PhChUpdBtn.Text,
                BirthDate = kryptonChDateTimePicker1.Value,

            };
            bool success = TeacherBLL.UpdateTeacher(teacher);

            if (success)
            {
                MessageBox.Show("Teacher Data Updated Successfuly", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Failed to update this Teacher data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CancelUpdBtnCh_Click(object sender, EventArgs e)
        {
            FNameChUpdBtn.Clear();
            UNchUpdBtn.Clear();
            EmailChUpdBtn.Clear();
            PassChUpdBtn.Clear();
            AddChUpdBtn.Clear();
            GenderChUpdTxt.Clear();
            PhChUpdBtn.Clear();
            kryptonChDateTimePicker1.Value = DateTime.Now;
            IDchUpdBtn.Clear();
        }

        private void UpdTeacherUC_Load(object sender, EventArgs e)
        {

        }
    }
}

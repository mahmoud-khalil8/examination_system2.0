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

namespace WindowsFormsApp1.UserControls.StdUC
{
    public partial class UpdateStdUc : UserControl
    {
        //private List<TextBox> subjectTextBoxes = new List<TextBox>();
        //private int startY = 300; 
        //private int spacing = 30;
        private int SelectedUserID = -1;

        public UpdateStdUc()
        {
            InitializeComponent();
        }


        private void UpdateStdUc_Load(object sender, EventArgs e)
        {



        }

        private void IDUpdBtn_TextChanged(object sender, EventArgs e)
        {
            string input = IDUpdBtn.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please enter student Id");
                return;
            }

        }
        private void SearchByID(int ID)
        {
            DataTable dt = StudentBLL.GetStudentById(ID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                UserModel student = new UserModel
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
                FNameUpdBtn.Text = student.FullName;
                UNUpdBtn.Text = student.UserName;
                EmailUpdBtn.Text = student.Email;
                PassUpdBtn.Text = student.Password;
                AddUpdBtn.Text = student.Address;
                GenderUpdTxt.Text = student.Gender;
                PhUpdBtn.Text = student.Phone;
                kryptonChDateTimePicker1.Value = student.BirthDate.GetValueOrDefault(DateTime.Now);
                SelectedUserID = student.UserID;
            }
            else
            {
                MessageBox.Show("This student is not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //private void LoadGender()
        //{
        //    //GUpd.Items.Clear();
        //    GUpd.Items.Add("Male");
        //    GUpd.Items.Add("Female");
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SvChangesBtn_Click(object sender, EventArgs e)
        {
            if (SelectedUserID == -1)
            {
                MessageBox.Show("Please enter an ID first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(PhUpdBtn.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone number must contain only numbers!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(EmailUpdBtn.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string gender = GenderUpdTxt.Text.Trim().ToLower();
            if (gender != "male" && gender != "female")
            {
                MessageBox.Show("Gender must be either 'Male' or 'Female'!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserModel student = new UserModel
            {
                UserID = SelectedUserID,
                FullName = FNameUpdBtn.Text,
                UserName = UNUpdBtn.Text,
                Email = EmailUpdBtn.Text,
                Password = PassUpdBtn.Text,
                Address = AddUpdBtn.Text,
                Gender = char.ToUpper(gender[0]) + gender.Substring(1),
                Phone = PhUpdBtn.Text,
                BirthDate = kryptonChDateTimePicker1.Value,
                //Role="Student"
            };
            bool success = StudentBLL.UpdateStudent(student);

            if (success)
            {
                MessageBox.Show("Student Data Updated Successfuly", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Failed to update this student data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(IDUpdBtn.Text, out int userID))
            {
                SearchByID(userID);
            }
            else
            {
                MessageBox.Show("Invalid ID format. Please enter a valid numeric ID.");
            }



        }

        private void CancelUpdBtn_Click(object sender, EventArgs e)
        {
            FNameUpdBtn.Clear();
            UNUpdBtn.Clear();
            EmailUpdBtn.Clear();
            PassUpdBtn.Clear();
            AddUpdBtn.Clear();
            GenderUpdTxt.Clear();
            PhUpdBtn.Clear();
            kryptonChDateTimePicker1.Value = DateTime.Now;
            IDUpdBtn.Clear();

            //design 

        }
    }
}

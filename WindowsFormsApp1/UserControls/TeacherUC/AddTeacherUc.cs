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
using WindowsFormsApp1.BusinessLogic;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.UserControls.TeacherUC
{
    public partial class AddTeacherUc : UserControl
    {
        public AddTeacherUc()
        {
            InitializeComponent();
        }


        private void SaveTchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FNameChTxt.Text) ||
                    string.IsNullOrWhiteSpace(EmailChTxt.Text) ||
                    string.IsNullOrWhiteSpace(PassChTxt.Text) ||
                    string.IsNullOrWhiteSpace(UserNameChTxt.Text) ||
                     string.IsNullOrWhiteSpace(AddChTxt.Text) ||
                    string.IsNullOrWhiteSpace(GenderChBox.Text) ||
                    string.IsNullOrWhiteSpace(PhoneChTxt.Text) ||
                    string.IsNullOrWhiteSpace(AssSubject.Text)

                   )
                {
                    // MessageBox.Show("All Data are required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }
                if (!BDteacher.Checked)
                {
                    MsgLbl.Text = "Please select a date.";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                }
                // Check Phone format
                if (!Regex.IsMatch(PhoneChTxt.Text, @"^\d+$"))
                {
                    // MessageBox.Show("Phone number must contain only numbers!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgLbl.Text = " Phone number must contain only numbers!";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }
                // check Email format
                if (!Regex.IsMatch(EmailChTxt.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    //MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgLbl.Text = "Invalid email format!";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }
                //Check gender is male or female only
                string gender = GenderChBox.Text.Trim().ToLower();
                if (gender != "male" && gender != "female")
                {
                    //MessageBox.Show("Gender must be either 'Male' or 'Female'!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgLbl.Text = "Gender must be either 'Male' or 'Female'!";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }
                UserModel newTeacher = new UserModel
                {
                    UserName = UserNameChTxt.Text.Trim(),
                    FullName = FNameChTxt.Text.Trim(),
                    Email = EmailChTxt.Text.Trim(),
                    Password = PassChTxt.Text.Trim(),
                    Address = AddChTxt.Text.Trim(),
                    Gender = char.ToUpper(gender[0]) + gender.Substring(1),
                    BirthDate = BDteacher.Value,
                    Phone = PhoneChTxt.Text.Trim(),

                    //Subjects = AssSubject.Text.Trim()


                };







                int subjectExist = TeacherBLL.GetSubject(AssSubject.Text);

                if (subjectExist > 1)
                {
                    MsgLbl.Text = "This subject already exist with a teacher!";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }







                int result = TeacherBLL.AddTeacher(newTeacher);
                if (result == -1)
                {
                    MessageBox.Show("This Email is already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (result > 0)
                {





                    //get teacherId
                    int teacherId = TeacherBLL.getTeacherId(EmailChTxt.Text);

                    //check if subject already exist 
                    



                    TeacherBLL.AssignSubjectToTeacher(teacherId, AssSubject.Text);
                    MessageBox.Show("New Teacher is added successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add Teacher", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ResetAddTch_Click(object sender, EventArgs e)
        {
            UserNameChTxt.Clear();
            FNameChTxt.Clear();
            EmailChTxt.Clear();
            PassChTxt.Clear();
            AddChTxt.Clear();
            GenderChBox.Clear();
            BDteacher.Value = DateTime.Now;
            PhoneChTxt.Clear();
            AssSubject.Clear();



        }

        private void AddTeacherUc_Load(object sender, EventArgs e)
        {

        }

        private void GenderChBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AssSubject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

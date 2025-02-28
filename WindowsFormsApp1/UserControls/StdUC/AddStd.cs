using ADMIN.BusinessLogicLayer;
using ComponentFactory.Krypton.Toolkit;
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
    public partial class AddStd : UserControl
    {
        private List<TextBox> subjectTextBoxes = new List<TextBox>();

        public AddStd()
        {
            InitializeComponent();
        }


        private void AddStd_Load(object sender, EventArgs e)
        {

        }

        private void SaveStdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FNameTxt.Text) ||
                    string.IsNullOrWhiteSpace(EmailTxt.Text) ||
                    string.IsNullOrWhiteSpace(PassTxt.Text) ||
                    string.IsNullOrWhiteSpace(UserNameTxt.Text) ||
                    string.IsNullOrWhiteSpace(AddTxt.Text) ||
                    string.IsNullOrWhiteSpace(GenderBox.Text) ||
                    string.IsNullOrWhiteSpace(PhoneTxt.Text)
                   //string.IsNullOrWhiteSpace(RoleTxt.Text)
                   )
                {
                    // MessageBox.Show("All Data are required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }
                if (!kryptonDateTimePicker1.Checked)
                {
                    MsgLbl.Text = "Please select a date.";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                }
                // Check Phone format
                if (!Regex.IsMatch(PhoneTxt.Text, @"^\d+$"))
                {
                    //MessageBox.Show("Phone number must contain only numbers!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgLbl.Text = " Phone number must contain only numbers!";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }
                // Check Email format
                if (!Regex.IsMatch(EmailTxt.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    //MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgLbl.Text = "Invalid email format!";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }
                //Check gender is male or female only
                string gender = GenderBox.Text.Trim().ToLower();
                if (gender != "male" && gender != "female")
                {
                    //MessageBox.Show("Gender must be either 'Male' or 'Female'!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgLbl.Text = "Gender must be either 'Male' or 'Female'!";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }
                //Check if there is a value for subject 
                List<string> subjects = new List<string>();
                foreach (var txt in subjectTextBoxes)
                {
                    if (!string.IsNullOrWhiteSpace(txt.Text))
                    {
                        subjects.Add(txt.Text.Trim());
                    }






                    int res = TeacherBLL.GetSubject(txt.Text.Trim());
                    if (res == 0)
                    {
                        MsgLbl.Text = "student must be registered only in existing subjects";
                        MsgLbl.Visible = true;
                        MsgLbl.ForeColor = Color.Red;
                        return;
                    }







                }

                if (subjects.Count == 0)
                {
                    MsgLbl.Text = "Please enter at least one subject!";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }


                UserModel newStudent = new UserModel
                {
                    UserName = UserNameTxt.Text.Trim(),
                    FullName = FNameTxt.Text.Trim(),
                    Email = EmailTxt.Text.Trim(),
                    Password = PassTxt.Text.Trim(),
                    Address = AddTxt.Text.Trim(),
                    Gender = char.ToUpper(gender[0]) + gender.Substring(1),
                    BirthDate = kryptonDateTimePicker1.Value,
                    Phone = PhoneTxt.Text.Trim(),
                    Subjects = subjects
                    //Subjects = AssSubject.Text.Trim()
                };
                int result = StudentBLL.CreateStudent(newStudent);
                if (result == -1)
                {
                    // MessageBox.Show("This Email is already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MsgLbl.Text = "This Email is already exists !";
                    MsgLbl.Visible = true;
                    MsgLbl.ForeColor = Color.Red;
                    return;
                }

                else if (result > 0)
                {
                    MessageBox.Show("New Student is added successfully", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add Student", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ResetAddStd_Click(object sender, EventArgs e)
        {
            UserNameTxt.Clear();
            FNameTxt.Clear();
            EmailTxt.Clear();
            PassTxt.Clear();
            AddTxt.Clear();
            GenderBox.Clear();
            kryptonDateTimePicker1.Value = DateTime.Now;
            PhoneTxt.Clear();
            AssSubject.Clear();


        }

        private void AssSubject_TextChanged(object sender, EventArgs e)
        {
            foreach (var txt in subjectTextBoxes)
            {
                this.Controls.Remove(txt);
            }
            subjectTextBoxes.Clear();
            if (int.TryParse(AssSubject.Text, out int subjectCount) && subjectCount > 0)
            {
                int startY = AssSubject.Bottom + 10;

                for (int i = 0; i < subjectCount; i++)
                {
                    TextBox txtSubject = new TextBox
                    {
                        Name = "txtSubject" + (i + 1),
                        Width = 200,
                        Location = new Point(AssSubject.Left, startY + (i * 30)),
                        Text = $"Enter Subject {i + 1} "

                    };
                    subjectTextBoxes.Add(txtSubject);
                    this.Controls.Add(txtSubject);
                }
            }
        }

        //private void btnGenerateSub_Click(object sender, EventArgs e)
        //{
        //    int subjectCount;
        //    if (int.TryParse(AssSubject.Text, out subjectCount) && subjectCount > 0)
        //    {
        //        //pnlSubjects.Controls.Clear(); // إزالة أي مواد قديمة
        //        subjectTextBoxes.Clear();

        //        for (int i = 0; i < subjectCount; i++)
        //        {
        //            TextBox txtSubject = new TextBox
        //            {
        //                Name = $"txtSubject{i + 1}",
        //                //PlaceholderText = $"المادة {i + 1}",
        //                Width = 200,
        //                Margin = new Padding(5)
        //            };
        //            subjectTextBoxes.Add(txtSubject);
        //            //pnlSubjects.Controls.Add(txtSubject);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter subjects ");
        //    }
        //}
    }
}


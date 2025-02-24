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
                    string.IsNullOrWhiteSpace(UserNameTxt.Text)
                   //string.IsNullOrWhiteSpace(RoleTxt.Text)
                   )
                {
                    MessageBox.Show("All Data are required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Check Phone format
                if (!Regex.IsMatch(PhoneTxt.Text, @"^\d+$"))
                {
                    MessageBox.Show("Phone number must contain only numbers!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Check Email format
                if (!Regex.IsMatch(EmailTxt.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Invalid email format!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Check gender is male or female only
                string gender = GenderBox.Text.Trim().ToLower();
                if (gender != "male" && gender != "female")
                {
                    MessageBox.Show("Gender must be either 'Male' or 'Female'!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    Phone = PhoneTxt.Text.Trim()
                    // Role=RoleTxt.Text.Trim(),


                };
                int result = StudentBLL.CreateStudent(newStudent);
                if (result == -1)
                {
                    MessageBox.Show("This Email is already exists !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
    }
}

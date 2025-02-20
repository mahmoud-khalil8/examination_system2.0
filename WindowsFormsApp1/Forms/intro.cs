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

namespace WindowsFormsApp1.Forms
{
    public partial class intro : Form
    {
        public intro()
        {
            InitializeComponent();
            passwordtb.PasswordChar = '*';
        }

        private void intro_Load(object sender, EventArgs e)
        {

            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            string email = emailtb.Text.Trim();
            string password = passwordtb.Text;


            DataTable studentInformation = BusinessLogic.StudentManager.getStudent(email,password);

            if (studentInformation.Rows.Count > 0)
            {
                WrongStatement.Visible = false;

                string studentRole = studentInformation.Rows[0]["Role"].ToString();
                if (studentRole == "Student")
                {
                    UserModel student = new UserModel();
                    student.UserID = Convert.ToInt32(studentInformation.Rows[0]["UserID"]);
                    student.Email = studentInformation.Rows[0]["Email"].ToString();
                    student.Password = studentInformation.Rows[0]["Password"].ToString();
                    student.Role = studentInformation.Rows[0]["Role"].ToString();
                    student.FullName = studentInformation.Rows[0]["FullName"].ToString();
                    student.UserName = studentInformation.Rows[0]["Username"].ToString();

                    Student studentForm = new Student(student);
                    studentForm.Show();
                }
                
                
            }
            else
            {
                WrongStatement.Visible = true;
            }



        }
    }
}

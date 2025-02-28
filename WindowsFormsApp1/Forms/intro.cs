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
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Forms
{
    public partial class intro : Form
    {
        public static int CurrentId;
        public intro()
        {
            InitializeComponent();
            passwordtb.PasswordChar = '*';
        }

        private void intro_Load(object sender, EventArgs e)
        {

            headerlbl.Text = TranslationHelper.GetTranslation("ExamTitle");
            kryptonButton2.Text = TranslationHelper.GetTranslation("Settings");
            label2.Text = TranslationHelper.GetTranslation("Email");
            label4.Text = TranslationHelper.GetTranslation("Password");
            kryptonButton1.Text = TranslationHelper.GetTranslation("Login");
            label1.Text = TranslationHelper.GetTranslation("WelcomeMessage");

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            string email = emailtb.Text.Trim();
            string password = passwordtb.Text;



            DataTable userInformation = ExamManager.getStudent(email,password);

            if (userInformation.Rows.Count > 0)
            {
                WrongStatement.Visible = false;

                string userRole = userInformation.Rows[0]["Role"].ToString();
                if (userRole.ToLower() == "student")
                {
                    UserModel student = new UserModel();
                    student.UserID = Convert.ToInt32(userInformation.Rows[0]["UserID"]);
                    student.Email = userInformation.Rows[0]["Email"].ToString();
                    student.Password = userInformation.Rows[0]["Password"].ToString();
                    student.Role = userInformation.Rows[0]["Role"].ToString();
                    student.FullName = userInformation.Rows[0]["FullName"].ToString();
                    student.UserName = userInformation.Rows[0]["Username"].ToString();
                    //checknullhere first in supervised by 
                    if (userInformation.Rows[0]["supervised_by"] == DBNull.Value)
                    {
                        student.SupervisedBy = 0;
                    }
                    else
                    {
                        student.SupervisedBy = Convert.ToInt32(userInformation.Rows[0]["supervised_by"]);
                    }



                    CurrentId = student.UserID;
                    Student studentForm = new Student(student);
                    studentForm.Show();
                }
                else if (userRole.ToLower() == "admin")
                {

                    UserModel admin = new UserModel();
                    admin.UserID = Convert.ToInt32(userInformation.Rows[0]["UserID"]);
                    admin.Email = userInformation.Rows[0]["Email"].ToString();
                    admin.Password = userInformation.Rows[0]["Password"].ToString();
                    admin.Role = userInformation.Rows[0]["Role"].ToString();
                    admin.FullName = userInformation.Rows[0]["FullName"].ToString();
                    admin.UserName = userInformation.Rows[0]["Username"].ToString();
                    CurrentId = admin.UserID;


                    admin.Form1 form1 = new admin.Form1(admin);
                    form1.Show();
                }
                else if(userRole.ToLower() == "teacher")
                {

                    UserModel teacher = new UserModel();
                    teacher.UserID = Convert.ToInt32(userInformation.Rows[0]["UserID"]);
                    teacher.Email = userInformation.Rows[0]["Email"].ToString();
                    teacher.Password = userInformation.Rows[0]["Password"].ToString();
                    teacher.Role = userInformation.Rows[0]["Role"].ToString();
                    teacher.FullName = userInformation.Rows[0]["FullName"].ToString();
                    teacher.UserName = userInformation.Rows[0]["Username"].ToString();
                    CurrentId = teacher.UserID;


                    TeacherDashoard teacherDashoard = new TeacherDashoard();
                    teacherDashoard.Show();

                }
                
                
            }
            else
            {
                WrongStatement.Visible = true;
                WrongStatement.Text = TranslationHelper.GetTranslation("WrongCredentials");

            }



        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
